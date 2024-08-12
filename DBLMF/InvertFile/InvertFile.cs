// -----* InvertFile.cs Version: 1.1.0 *----- //
using System;
using System.IO;
using System.Data.SQLite;
using System.Diagnostics;

namespace InvertFile
{
    /// <summary>
    /// Provides functionality to invert the bytes of a specified file and log the process to a database.
    /// </summary>
    public class InvertFile
    {
        private static readonly string ExpectedFileName =
            "89bb4eb5637df3cd96c463a795005065 " +
            "98c4f00b8ed6655bce4b6f80cd0e1164" +
            "1e9cfb7afa8f0df06590c0954af9025" +
            "a565be8b11d263294cd2a71676db860" +
            "ad460dc54bb5769d65f436afc02ed8ae";

        private static readonly string ConnectionString = "Data Source=processing_log.db;Version=3;";
        private static TraceSource traceSource;
        
        static InvertFile()
        {
            traceSource = new TraceSource("FileProcessorTraceSource");
            traceSource.Listeners.Add(new ConsoleTraceListener());
            traceSource.Switch = new SourceSwitch("sourceSwitch", "Verbose");

            InitializeDatabase();
        }

        /// <summary>
        /// Initializes the SQLite database to log file processing events.
        /// </summary>
        private static void InitializeDatabase()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();
                    string createTableQuery = @"
                        CREATE TABLE IF NOT EXISTS ProcessingLog (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            FileName TEXT NOT NULL,
                            ProcessedAt TEXT NOT NULL,
                            Status TEXT NOT NULL,
                            ErrorMessage TEXT
                        )";
                    SQLiteCommand command = new SQLiteCommand(createTableQuery, connection);
                    command.ExecuteNonQuery();
                }

                traceSource.TraceEvent(TraceEventType.Information, 0, "Database initialized successfully.");
            }
            catch (Exception ex)
            {
                traceSource.TraceEvent(TraceEventType.Error, 0, $"Failed to initialize database: {ex.Message}");
            }
        }

        /// <summary>
        /// Processes the specified file by inverting its bytes if the file name matches the expected name.
        /// Logs the processing status to a database.
        /// </summary>
        /// <param name="filePath">The path of the file to process.</param>
        public static void ProcessFile(string filePath)
        {
            string fileName = Path.GetFileName(filePath);

            if (fileName != ExpectedFileName)
            {
                traceSource.TraceEvent(TraceEventType.Error, 0, $"Unexpected file name: {fileName}");
                LogToDatabase(fileName, "Failed", "Unexpected file name");
                return;
            }

            traceSource.TraceEvent(TraceEventType.Information, 0, $"Processing file: {fileName}");

            try
            {
                byte[] fileBytes = File.ReadAllBytes(filePath);

                for (int i = 0; i < fileBytes.Length; i++)
                {
                    fileBytes[i] = (byte)(~fileBytes[i] + 256);
                }

                File.WriteAllBytes(filePath, fileBytes);

                traceSource.TraceEvent(TraceEventType.Information, 0, "File processed successfully.");
                LogToDatabase(fileName, "Success", null);
            }
            catch (Exception ex)
            {
                traceSource.TraceEvent(TraceEventType.Error, 0, $"An error occurred: {ex.Message}");
                LogToDatabase(fileName, "Failed", ex.Message);
            }
        }

        /// <summary>
        /// Logs the processing status of a file to the database.
        /// </summary>
        /// <param name="fileName">The name of the processed file.</param>
        /// <param name="status">The processing status (e.g., Success, Failed).</param>
        /// <param name="errorMessage">An optional error message if the processing failed.</param>
        private static void LogToDatabase(string fileName, string status, string errorMessage)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();
                    string insertQuery = @"
                        INSERT INTO ProcessingLog (FileName, ProcessedAt, Status, ErrorMessage)
                        VALUES (@FileName, @ProcessedAt, @Status, @ErrorMessage)";
                    SQLiteCommand command = new SQLiteCommand(insertQuery, connection);
                    command.Parameters.AddWithValue("@FileName", fileName);
                    command.Parameters.AddWithValue("@ProcessedAt", DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss"));
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@ErrorMessage", errorMessage);
                    command.ExecuteNonQuery();
                }

                traceSource.TraceEvent(TraceEventType.Information, 0, "Processing log updated.");
            }
            catch (Exception ex)
            {
                traceSource.TraceEvent(TraceEventType.Error, 0, $"Failed to log to database: {ex.Message}");
            }
        }

        /// <summary>
        /// Reads the processing logs from the database and prints them to the console.
        /// </summary>
        public static void DisplayProcessingLogs()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();
                    string selectQuery = "SELECT * FROM ProcessingLog";
                    SQLiteCommand command = new SQLiteCommand(selectQuery, connection);
                    SQLiteDataReader reader = command.ExecuteReader();

                    Console.WriteLine("Processing Logs:");
                    while (reader.Read())
                    {
                        Console.WriteLine(
                            $"ID: {reader["Id"]}, FileName: {reader["FileName"]}, " +
                            $"ProcessedAt: {reader["ProcessedAt"]}, Status: {reader["Status"]}, " +
                            $"ErrorMessage: {reader["ErrorMessage"]}");
                    }
                }
            }
            catch (Exception ex)
            {
                traceSource.TraceEvent(TraceEventType.Error, 0, $"Failed to read processing logs: {ex.Message}");
            }
        }

        /// <summary>
        /// Clears all processing logs from the database.
        /// </summary>
        public static void ClearProcessingLogs()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM ProcessingLog";
                    SQLiteCommand command = new SQLiteCommand(deleteQuery, connection);
                    command.ExecuteNonQuery();

                    traceSource.TraceEvent(TraceEventType.Information, 0, "Processing logs cleared.");
                }
            }
            catch (Exception ex)
            {
                traceSource.TraceEvent(TraceEventType.Error, 0, $"Failed to clear processing logs: {ex.Message}");
            }
        }
    }
}

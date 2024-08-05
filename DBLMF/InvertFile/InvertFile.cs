using System;
using System.IO;
using System.Diagnostics;

namespace InvertFile
{
    /// <summary>
    /// Provides functionality to invert the bytes of a specified file.
    /// </summary>
    public class InvertFile
    {
        private static readonly string ExpectedFileName = 
            "89bb4eb5637df3cd96c463a795005065 " +
            "98c4f00b8ed6655bce4b6f80cd0e1164" +
            "1e9cfb7afa8f0df06590c0954af9025" +
            "a565be8b11d263294cd2a71676db860" +
            "ad460dc54bb5769d65f436afc02ed8ae";

        /// <summary>
        /// Processes the specified file by inverting its bytes if the file name matches the expected name.
        /// </summary>
        /// <param name="filePath">The path of the file to process.</param>
        public static void ProcessFile(string filePath)
        {
            TraceSource traceSource = new TraceSource("FileProcessorTraceSource");
            traceSource.Listeners.Add(new ConsoleTraceListener());
            traceSource.Switch = new SourceSwitch("sourceSwitch", "Verbose");

            string fileName = Path.GetFileName(filePath);

            if (fileName != ExpectedFileName)
            {
                traceSource.TraceEvent(TraceEventType.Error, 0, $"Unexpected file name: {fileName}");
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
            }
            catch (Exception ex)
            {
                traceSource.TraceEvent(TraceEventType.Error, 0, $"An error occurred: {ex.Message}");
            }
        }
    }
}

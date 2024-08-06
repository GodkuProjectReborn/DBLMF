// EditSleeve.cs
// Made by Godku Project

using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace DBLMF
{
    public static class FileProcessor
    {
        private static readonly string ExpectedFileName = "98c4f00b8ed6655bce4b6f80cd0e1164";
        private static readonly string SleeveIdPattern = @"""selectedSleeveId"": \d+";

        /// <summary>
        /// Inverts the bytes of the provided byte array.
        /// </summary>
        /// <param name="fileContent">The byte array to invert.</param>
        /// <returns>The inverted byte array.</returns>
        private static byte[] InvertBytes(byte[] fileContent)
        {
            for (int i = 0; i < fileContent.Length; i++)
            {
                fileContent[i] = (byte)(~fileContent[i] + 256);
            }
            return fileContent;
        }

        /// <summary>
        /// Validates the file against predefined security checks.
        /// </summary>
        /// <param name="filePath">The path to the file to validate.</param>
        /// <returns>True if validation passes; otherwise, false.</returns>
        private static bool ValidateFile(string filePath)
        {
            try
            {
                var fileName = Path.GetFileName(filePath);
                if (fileName != ExpectedFileName)
                {
                    Console.WriteLine("Error: Unexpected file name.");
                    return false;
                }

                // adding more security checks soon, such as verifying file hash

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Validation error: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Computes the SHA256 hash of a file.
        /// </summary>
        /// <param name="filePath">The path to the file.</param>
        /// <returns>The SHA256 hash as a hexadecimal string.</returns>
        private static string ComputeFileHash(string filePath)
        {
            using (var sha256 = SHA256.Create())
            {
                using (var stream = File.OpenRead(filePath))
                {
                    byte[] hash = sha256.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        /// <summary>
        /// Processes the file by modifying its content based on the provided sleeve ID.
        /// </summary>
        /// <param name="filePath">The path to the file to process.</param>
        /// <param name="newSleeve">The new sleeve ID to insert.</param>
        public static void ProcessFile(string filePath, int newSleeve)
        {
            if (!ValidateFile(filePath))
            {
                throw new InvalidOperationException("File validation failed.");
            }

            try
            {
                byte[] fileContent = File.ReadAllBytes(filePath);
                byte[] invertedContent = InvertBytes(fileContent);

                string fileStr = Encoding.UTF8.GetString(invertedContent);
                string modifiedFileStr = Regex.Replace(fileStr, SleeveIdPattern, $@"""selectedSleeveId"": {newSleeve}");

                byte[] processedContent = InvertBytes(Encoding.UTF8.GetBytes(modifiedFileStr));
                File.WriteAllBytes(filePath, processedContent);

                Console.WriteLine($"File '{filePath}' processed successfully.");
            }
            catch (IOException ioEx)
            {
                throw new ApplicationException("I/O error while processing the file.", ioEx);
            }
            catch (UnauthorizedAccessException uaEx)
            {
                throw new ApplicationException("Access denied while processing the file.", uaEx);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An unexpected error occurred while processing the file.", ex);
            }
        }
    }
}

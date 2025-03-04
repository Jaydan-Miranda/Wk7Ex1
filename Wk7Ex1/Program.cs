using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace Wk7Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = "sample.txt"; // Ensure this file exists 
            
            try
            {
                // Call the CountWords method
                int wordCount = CountWords(fileName);
                // Display the word count
                Console.WriteLine($"Total word count: {wordCount}");
            }
            // Catch the exception and display the error message
            catch (Exception er)
            {
                Console.WriteLine($"Error: {er.Message}");
            }
        }

        // Method to count the number of words in a file
        static int CountWords(string fileName)
        {
            // Check if the file exists
            if (!File.Exists(fileName))
                throw new FileNotFoundException("The file does not exist.");

            // Read the file content
            string content = File.ReadAllText(fileName);
            if (string.IsNullOrWhiteSpace(content))
                return 0;
            // Split the content into words not considering spaces
            string[] words = content.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
    }
}

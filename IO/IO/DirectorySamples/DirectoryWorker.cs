using IO.DirectorySamples.Services;
using System;
using System.IO;

namespace IO.DirectorySamples
{
    public class DirectoryWorker
    {
        public void DirectoryListAndDetails()
        {
            DirectoryService.DirectoryDetails();
        }

        public void ListDirectories()
        {
            var directories = Directory.EnumerateDirectories(@"C:\");

            Console.WriteLine("List all directories in C:");
            foreach(var directory in directories)
            {
                Console.WriteLine($"--> Name: {directory}");
            }

            Console.WriteLine(Environment.NewLine);
        }

        public void GetCurrentDirectory()
        {
            var currentDirectory = Directory.GetCurrentDirectory();

            Console.WriteLine($"Application is running from here: {currentDirectory}");
            Console.WriteLine(Environment.NewLine);
        }

        public void DirectoryOperations()
        {
            DirectoryService.DirectoryOperations();
        }
    }
}

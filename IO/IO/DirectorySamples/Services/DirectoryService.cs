using System;
using System.IO;

namespace IO.DirectorySamples.Services
{
    public static class DirectoryService
    {
        public static void DirectoryDetails()
        {
            var drives = Directory.GetLogicalDrives();

            var directories = Directory.EnumerateDirectories(drives[0]);

            Console.WriteLine($"List and details of directories in {drives[0]}:");
            foreach(var directory in directories)
            {
                var directoryInfo = new DirectoryInfo(directory);

                Console.WriteLine("-> Directory details:");
                Console.WriteLine($"--> Name: {directoryInfo.Name}");
                Console.WriteLine($"--> Full name: {directoryInfo.FullName}");
                Console.WriteLine($"--> Extension: {directoryInfo.Extension}");
                Console.WriteLine($"--> Parent: {directoryInfo.Parent}");
                Console.WriteLine($"--> Root: {directoryInfo.Root}");
            }

            Console.WriteLine(Environment.NewLine);
        }

        public static void DirectoryOperations()
        {
            var directoryPath = @"C:\Game of Thrones";
            DirectoryInfo directory;

            if(Directory.Exists(directoryPath))
            {
                Console.WriteLine($"Directory {directoryPath} already exists!");
                directory = new DirectoryInfo(directoryPath);
            }
            else
            {
                directory = Directory.CreateDirectory(directoryPath);
                Console.WriteLine($"Directory {directoryPath} was created!");
            }

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Directory details:");
            Console.WriteLine($"-> Creation time: {directory.CreationTime}");
            Console.WriteLine(Environment.NewLine);

            var insideDirectories = directory.GetDirectories();

            if(insideDirectories.Length > 0)
            {
                PrintDirectories(insideDirectories);
            }

            var insideFiles = directory.GetFiles();

            if(insideFiles.Length > 0)
            {
                PrintFiles(insideFiles);
            }
        }

        private static void PrintDirectories(DirectoryInfo[] directories)
        {
            foreach(var directory in directories)
            {
                Console.WriteLine("-> Directory details:");
                Console.WriteLine($"--> Name: {directory.Name}");
                Console.WriteLine($"--> Full name: {directory.FullName}");
                Console.WriteLine($"--> Extension: {directory.Extension}");
            }

            Console.WriteLine(Environment.NewLine);
        }

        private static void PrintFiles(FileInfo[] files)
        {
            foreach(var file in files)
            {
                Console.WriteLine("-> File details:");
                Console.WriteLine($"--> Name: {file.Name}");
                Console.WriteLine($"--> Full name: {file.FullName}");
                Console.WriteLine($"--> Extension: {file.Extension}");
            }
        }
    }
}

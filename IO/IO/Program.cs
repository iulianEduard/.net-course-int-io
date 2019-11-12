using IO.DirectorySamples;
using IO.FileSamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryExamples();

            FileExamples();
        }

        private static void DirectoryExamples()
        {
            var directoryWorker = new DirectoryWorker();

            directoryWorker.DirectoryListAndDetails();

            directoryWorker.ListDirectories();

            directoryWorker.GetCurrentDirectory();

            directoryWorker.DirectoryOperations();

            Console.ReadKey();
        }

        private static void FileExamples()
        {
            FileWorker.CreateAndOpenFileStream();

            FileWorker.ReadFileStream();

            FileWorker.CreateAndOpenFileUsingStreamWriter();

            FileWorker.ReadFileUsingStreamReader();

            Console.ReadKey();
        }
    }
}

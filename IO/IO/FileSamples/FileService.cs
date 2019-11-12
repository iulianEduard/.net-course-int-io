using System;
using System.IO;
using System.Text;

namespace IO.FileSamples
{
    public static class FileService
    {
        private const string ROOT_DIRECTORY = @"C:\Game of thrones";

        public static void CreateFileUsingFileStream()
        {
            Console.WriteLine("Creating file Cities.txt");
            var filePath = $@"{ROOT_DIRECTORY}\Cities.txt";
            var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite);

            fileStream.WriteByte(Convert.ToByte(1));
            fileStream.WriteByte(Convert.ToByte(2));
            fileStream.WriteByte(Convert.ToByte(3));

            fileStream.Close();
        }

        public static void ReadFileUsingFileStream()
        {
            Console.WriteLine("Reading file Cities.txt");
            var filePath = $@"{ROOT_DIRECTORY}\Cities.txt";
            var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite);

            fileStream.Position = 0;
            for (int i = 0; i <= 2; i++)
            {
                Console.Write(fileStream.ReadByte() + " ");
            }

            fileStream.Close();
        }

        public static void CreateFileUsingStreamWriter()
        {
            Console.WriteLine("Creating file Characters.txt");
            var filePath = $@"{ROOT_DIRECTORY}\Characters.txt";

            StreamWriter stringWriter = new StreamWriter(filePath);
            stringWriter.WriteLine("Jon Snow");
            stringWriter.WriteLine("Sansa Stark");

            stringWriter.Close();
        }

        public static void ReadFileUsingStreamReader()
        {
            Console.WriteLine("Reading file Characters.txt");
            var filePath = $@"{ROOT_DIRECTORY}\Characters.txt";

            string line = string.Empty;
            using (var streamReader = new StreamReader(filePath))
            {
                while ((line = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine($"->> {line}");
                }
            }
        }

        public static void CreateFileUsingFileClass()
        {
            Console.WriteLine("Creating file Armies.txt");
            var filePath = $@"{ROOT_DIRECTORY}\Armies.txt";

            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Unsullied");
            stringBuilder.Append("Northmen");
            stringBuilder.AppendLine("Dragons");

            File.WriteAllText(filePath, stringBuilder.ToString());
        }
    }
}

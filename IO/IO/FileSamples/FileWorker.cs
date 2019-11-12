namespace IO.FileSamples
{
    public static class FileWorker
    {
        public static void CreateAndOpenFileStream()
        {
            FileService.CreateFileUsingFileStream();
        }

        public static void ReadFileStream()
        {
            FileService.ReadFileUsingFileStream();
        }

        public static void CreateAndOpenFileUsingStreamWriter()
        {
            FileService.CreateFileUsingStreamWriter();
        }

        public static void ReadFileUsingStreamReader()
        {
            FileService.ReadFileUsingStreamReader();
        }
    }
}

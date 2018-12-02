namespace Logger
{
    using Contracts;

    using System;
    using System.IO;

    public class FileLogger : ILogFile
    {
        private const string DEFAULT_PATH = "./data/";

        public FileLogger(string file)
        {
            this.Path = DEFAULT_PATH + file;
        }

        public string Path { get; }

        public int Size { get; private set; }

        public void WriteToFile(string error)
        {
            File.AppendAllText(this.Path, error);

            foreach (var item in error)
            {
                this.Size += (int)item;
            }
        }
    }
}

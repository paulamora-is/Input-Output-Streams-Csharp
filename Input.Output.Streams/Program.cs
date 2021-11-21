using Input.Output.Streams.Constants;
using System;
using System.IO;

namespace Input.Output.Streams
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var file = FileConst.FilePath;

            using (var fileStream = new FileStream(file, FileMode.Open))

            using (var reader = new StreamReader(fileStream))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    Console.WriteLine(line);
                }

            }

            Console.ReadLine();
        }
    }
}

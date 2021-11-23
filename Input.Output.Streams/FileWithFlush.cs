using Input.Output.Streams.Constants;
using System;
using System.IO;
using System.Text;

namespace Input.Output.Streams
{
    partial class Program
    {
        static void CreateFileWithFlushMethod()
        {
            var fileCsv = FileConst.FilePathWithFlushMethod;

            using var fileStream = new FileStream(fileCsv, FileMode.Create);
            using var writer = new StreamWriter(fileStream, Encoding.UTF8);

            for (var i = 0; i < 10000; i++)
            {
                writer.WriteLine($"This is line number {i}");
                writer.Flush();
                Console.WriteLine($"Line {i} was written to file. Hit 'enter' to add one more");
                Console.ReadLine();
            }
        }
    }
}

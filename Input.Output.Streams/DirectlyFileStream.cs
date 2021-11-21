using Input.Output.Streams.Constants;
using System;
using System.IO;
using System.Text;

namespace Input.Output.Streams
{
    partial class Program
    {
        static void HandleDirectlyFileStream()
        {
            var file = FileConst.FilePath;
            using (var fileStream = new FileStream(file, FileMode.Open))
            {
                var buffer = new byte[1024];

                var numberOfBytesRead = -1;
                while (numberOfBytesRead != 0)
                {
                    numberOfBytesRead = fileStream.Read(buffer, 0, 1024);
                    WriteBuffer(buffer);
                }
            }

            Console.ReadLine();
        }
        static void WriteBuffer(byte[] buffer)
        {
            var enconding = new UTF8Encoding();
            var text = enconding.GetString(buffer);
            Console.WriteLine(text);
        }
    }
}

using Input.Output.Streams.Constants;
using System;
using System.IO;

namespace Input.Output.Streams
{
    partial class Program
    {
        static void UseConsoleInputStream()
        {
            using var consoleByteStream = Console.OpenStandardInput();
            using var fileStream = new FileStream(FileConst.FilePathConsoleBytes, FileMode.Create);
            //To get information from the Console, we rarely use Stream. We use the return from the Console.ReadLine() method;

            var buffer = new byte[1024];
            while (true)
            {
                var bytesRead = consoleByteStream.Read(buffer, 0, 1024);
                fileStream.Write(buffer, 0, 1024);
                fileStream.Flush();
                Console.WriteLine($"Bytes read from Console: {bytesRead}");
            }
        }
    }
}

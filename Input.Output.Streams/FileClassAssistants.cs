using Input.Output.Streams.Constants;
using System;
using System.IO;

namespace Input.Output.Streams
{
    partial class Program
    {
        static void UseFileClassHelpers()
        {
            File.WriteAllText(FileConst.FilePathFileClassHelpers, "Testing File.WriteAllText");
            Console.WriteLine("File criated!");

            var byteFile = File.ReadAllBytes(FileConst.FilePathAccounts);
            Console.WriteLine($"File account.txt has {byteFile.Length} bytes");

            var lines = File.ReadAllLines(FileConst.FilePathAccounts);
            Console.WriteLine($"The file account.txt has {lines.Length} lines");
        }
    }
}

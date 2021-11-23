using Input.Output.Streams.Constants;
using System;
using System.IO;

namespace Input.Output.Streams
{
    partial class Program
    {
        static void CreateBinaryFile()
        {
            var filePathBinary = FileConst.FilePathBinary;

            using var fileStream = new FileStream(filePathBinary, FileMode.Create);
            using var binaryWriter = new BinaryWriter(fileStream);

            binaryWriter.Write(456);
            binaryWriter.Write(45685);
            binaryWriter.Write(5000.78);
            binaryWriter.Write("Maria Silva");
            Console.WriteLine(binaryWriter);
        }

        static void ReadBinaryFile()
        {
            var filePathBinary = FileConst.FilePathBinary;

            using var fileStream = new FileStream(filePathBinary, FileMode.Open);
            using var binaryReader = new BinaryReader(fileStream);

            var branch = binaryReader.ReadInt32();
            var accountNumber = binaryReader.ReadInt32();
            var balance = binaryReader.ReadDouble();
            var holder = binaryReader.ReadString();

            Console.WriteLine($"Branch: {branch} / AccountNumber: {accountNumber} / Balance: {balance} / Holder: {holder}");
        }
    }
}

using Input.Output.Streams.Constants;
using System.IO;
using System.Text;

namespace Input.Output.Streams
{
    partial class Program
    {
        static void CreateFile()
        {
            var fileCsv = FileConst.FilePathCsv;

            using var fileStream = new FileStream(fileCsv, FileMode.Create);
            using var writer = new StreamWriter(fileStream, Encoding.UTF8);
            writer.WriteLine("456,65465,456.0,Pedro");
        }
    }
}

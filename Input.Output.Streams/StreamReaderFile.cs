using Input.Output.Streams.Constants;
using Input.Output.Streams.Models;
using System;
using System.IO;
using System.Text;

namespace Input.Output.Streams
{
    partial class Program
    {
        static void HandleFileWithStreamReader()
        {
            var file = FileConst.FilePath;

            using (var fileStream = new FileStream(file, FileMode.Open))

            using (var reader = new StreamReader(fileStream, Encoding.UTF8))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    var currentAccount = ConvertFileToCurrentAccount(line);
                    var mesage = $"{currentAccount.Holder.Name} : Conta número { currentAccount.NumberAccount}, ag. { currentAccount.Branch}, Saldo { currentAccount.Balance}";

                    Console.WriteLine(mesage);
                }
            }

            Console.ReadLine();
        }

        static CurrentAccount ConvertFileToCurrentAccount(string line)
        {
            var fields = line.Split(',');

            var parsedBranch = int.Parse(fields[0]);
            var parsedNumberAccount = int.Parse(fields[1]);
            var parsedBalance = double.Parse(fields[2].Replace('.', ','));

            var holder = new Client
            {
                Name = fields[3]
            };
            var result = new CurrentAccount(parsedBranch, parsedNumberAccount);
            result.Deposit(parsedBalance);
            result.Holder = holder;
            return result;
        }
    }
}

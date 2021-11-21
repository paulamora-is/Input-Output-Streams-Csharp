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

            var branch = fields[0];
            var numberAccount = fields[1];
            var balance = fields[2];
            var nameHolder = fields[3];

            var parsedBranch = int.Parse(branch);
            var parsedNumberAccount = int.Parse(numberAccount);
            var parsedBalance = double.Parse(balance.Replace('.', ','));

            var holder = new Client
            {
                Name = nameHolder
            };
            var result = new CurrentAccount(parsedBranch, parsedNumberAccount);
            result.Deposit(parsedBalance);
            result.Holder = holder;
            return result;
        }
    }
}

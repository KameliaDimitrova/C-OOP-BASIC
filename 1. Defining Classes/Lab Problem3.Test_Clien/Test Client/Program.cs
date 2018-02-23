using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Test_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var accounts = new Dictionary<int, BankAccount>();
            while (input != "End")
            {
                var data = input
                    .Split(' ')
                    .ToArray();
                var command = data[0];
                var commandId = int.Parse(data[1]);
                if (command == "Create")
                {
                    if (accounts.ContainsKey(commandId))
                    {
                        Console.WriteLine("Account already exists");
                    }
                    else
                    {
                        accounts[commandId] = new BankAccount { Id = commandId };

                    }
                }
                else if (command == "Deposit")
                {
                    if (!accounts.ContainsKey(commandId))
                    {
                        Console.WriteLine("Account does not exist");
                    }
                    else
                    {
                        var currDeposit = int.Parse(data[2]);
                        accounts[commandId].Deposit(currDeposit);
                    }
                }
                else if (command == "Withdraw")
                {
                    if (!accounts.ContainsKey(commandId))
                    {
                        Console.WriteLine("Account does not exist");
                    }
                    else
                    {
                        var currWithdraw = int.Parse(data[2]);
                        if (currWithdraw > accounts[commandId].Balance)
                        {
                            Console.WriteLine("Insufficient balance");
                        }
                        else
                        {
                            accounts[commandId].Withdraw(currWithdraw);
                        }
                    }
                }
                else if (command == "Print")
                {
                    var idForPrint = int.Parse(data[1]);
                    if (!accounts.ContainsKey(idForPrint))
                    {
                        Console.WriteLine("Account does not exist");
                    }
                    else
                    {
                        Console.WriteLine($"Account ID{accounts[commandId].Id}, balance {accounts[commandId].Balance:f2}");
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine();
        }
    }
}

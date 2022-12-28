using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3_dotNET_POO_com_Csharp.Models
{
    public class CurrentAccount
    {
        public CurrentAccount(int acountNumber, decimal initialBalance)
        {
            AccountNumber = acountNumber;
            balance = initialBalance;
        }

        public int AccountNumber { get; set; }
        private decimal balance;

        public void Withdraw(decimal value)
        {
            if (balance >= value)
            {
                balance -= value;
                Console.WriteLine("Successful withdrawal");
            }
            else
            {
                Console.WriteLine("Desired amount is greater than available balance.");
            }
        }

        public void DisplayBalance()
        {
            Console.WriteLine($"Your available balance is: {balance}");
        }
    }
}
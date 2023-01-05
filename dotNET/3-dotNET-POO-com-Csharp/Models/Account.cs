using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3_dotNET_POO_com_Csharp.Models
{
    public abstract class Account
    {
        protected decimal balance;

        public abstract void Credit(decimal value);
        public void ShowBalance()
        {
            Console.WriteLine($"Your balance is: {balance}");
        }
    }
}
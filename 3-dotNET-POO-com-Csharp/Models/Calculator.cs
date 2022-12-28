using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _3_dotNET_POO_com_Csharp.Interfaces;

namespace _3_dotNET_POO_com_Csharp.Models
{
    public class Calculator : ICalculator
    {
        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Sum(int num1, int num2) 
        {
            return num1 + num2;
        }

        public int Sum(int num1, int num2, int num3) 
        {
            return num1 + num2 + num3;
        }
    }
}
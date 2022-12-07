using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNET_Solution.Common.Models
{
    public class Calculator
    {
        public void Sum(int x, int y) 
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Subtract(int x, int y) 
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiply(int x, int y) 
        {
            Console.WriteLine($"{x} x {y} = {x * y}");
        }

        public void Divide(int x, int y) 
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void Power(int x, int y) 
        {
            double pow = Math.Pow(x, y);
            Console.WriteLine($"{x}^{y} = {pow}");
        }

        public void Sine(double angle)
        {
            double radian = angle * Math.PI / 180;
            double sine = Math.Sin(radian);
            Console.WriteLine($"Sine of {angle} = {Math.Round(sine, 4)}");
        }

        public void Cosine(double angle)
        {
            double radian = angle * Math.PI / 180;
            double cosine = Math.Cos(radian);
            Console.WriteLine($"Cosine of {angle} = {Math.Round(cosine, 4)}");
        }

         public void Tangent(double angle)
        {
            double radian = angle * Math.PI / 180;
            double tangent = Math.Tan(radian);
            Console.WriteLine($"Tangent of {angle} = {Math.Round(tangent, 4)}");
        }

        public void SquareRoot(double x)
        {
            double root = Math.Sqrt(x);
            Console.WriteLine($"Square root of {x} = {root}");
        }
        
    }
}
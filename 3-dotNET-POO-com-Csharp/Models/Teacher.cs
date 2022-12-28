using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3_dotNET_POO_com_Csharp.Models
{
    public class Teacher : Person
    {
        public decimal Salary { get; set; }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, my name is {Name}, I'm {Age} years old, I'm a teacher and earn a salary of {Salary}");
        }   
    }
}
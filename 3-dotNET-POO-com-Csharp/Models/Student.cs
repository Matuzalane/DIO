using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3_dotNET_POO_com_Csharp.Models
{
    public class Student : Person
    {
        public double Grade { get; set; }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, my name is {Name}, I'm have {Age} years old, and I'm a student grade {Grade}");
        }
    }
}
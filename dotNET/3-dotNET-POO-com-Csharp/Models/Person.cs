using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3_dotNET_POO_com_Csharp.Models
{
    public class Person
    {
        public Person()
        {
            
        }
        public Person(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public virtual void Introduce()
        {
            Console.WriteLine($"Hi, my name is {Name} and I'm {Age} years old!");
        }
    }
}
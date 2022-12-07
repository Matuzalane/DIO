using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNET_Introducao.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string NameOfLegalRepresentantOfPhysicalPerson { get; set; }
        public int Age { get; set; }

        public void Present()
        {
            Console.WriteLine($"Hi, my Name is {Name}, and I am {Age} years old");
        }
    }
}
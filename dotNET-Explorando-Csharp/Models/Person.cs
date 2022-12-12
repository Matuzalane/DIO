using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNET_Explorando_Csharp.Models
{
    public class Person
    {
        // Class Constructor
        public Person()
        {

        }
        public Person(string name, string lastname)
        {
            Name = name;
            LastName = lastname;
        }

        private string _name;
        private int _age;

        public string Name 
        { 
            get => _name.ToUpper();
            
            set
            {
                if(value == "")
                {
                    throw new ArgumentException("The name cannot be empty");
                }

                _name = value;
            }
        }

        public string LastName { get; set; }
        public string FullName => $"{Name} {LastName}".ToUpper();

        public int Age 
        {
            get => _age;
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("The age cannot be less than zero");

                    _age = value;
                }
            }
        
        }

        public void Introduce()
        {
            Console.WriteLine($"Name: {FullName}, Age: {Age}");
        }
    }
}
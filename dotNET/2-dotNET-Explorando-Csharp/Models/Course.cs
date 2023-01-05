using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNET_Explorando_Csharp.Models
{
    public class Course
    {
        public string Name { get; set; }
        public List<Person> Students { get; set; }

        public void AddStudent(Person student)
        {
            Students.Add(student);
        }
        public int GetNumberOfEnrolledStudents()
        {
            int quantity = Students.Count;
            return quantity;
        }
        public bool RemoveStudent(Person student)
        {
            return Students.Remove(student);
        }
        public void ListStudent()
        {
            Console.WriteLine($"Students from the course: {Name}");

            for (int i = 0; i < Students.Count; i++)
            {
                // string text = "Nº " + i + " - " + Students[i].FullName;
                string text = $"Nº {i + 1} - {Students[i].FullName}";
                Console.WriteLine(text);
            }

        }
    }
}
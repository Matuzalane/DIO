using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNET_Explorando_Csharp.Models
{
    public class FileReading
    {
        public (bool Success, string[] Lines, int NumberOfLines) ReadFile(string path)
        {
            try
            {
                string[] lines = File.ReadAllLines(path);
                return (true, lines, lines.Count());
            } 
            catch(Exception)
            {
                return (false, new string[0], 0);
            }
        }
    }
}
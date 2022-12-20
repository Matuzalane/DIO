using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNET_Explorando_Csharp.Models
{
    public class ExceptionExemple
    {
        public void Method1()
        {
            try
            {
                Method2();
            } catch(Exception ex)
            {
                Console.WriteLine($"Exception handled. {ex.Message}");
            }
            
        }
        public void Method2()
        {
            Method3();
        }
        public void Method3()
        {
            Method4();
        }
        public void Method4()
        {
            throw new Exception("A exception has ocorred!");
        }
    }
}
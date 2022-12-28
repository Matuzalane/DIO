using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3_dotNET_POO_com_Csharp.Models
{
    // Sealed class example
    public class Principal : Teacher
    {
         public override void Introduce()
        {
            Console.WriteLine("Principal");
        }  
    }
}
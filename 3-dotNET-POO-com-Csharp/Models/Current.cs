using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3_dotNET_POO_com_Csharp.Models
{
    public class Current : Account
    {
        public override void Credit(decimal value)
        {
            balance += value;
        }
    }
}
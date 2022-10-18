using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula73
{
    internal class Calculadora
    {
        public static void Triplo(ref int x)
        {
            x = x * 3;
        }

        public static void TriploDois(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}

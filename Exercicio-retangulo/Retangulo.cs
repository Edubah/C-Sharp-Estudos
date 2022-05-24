using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_retangulo
{
    public class Retangulo
    {
        public double Base;
        public double Altura;


        public double Area()
        {
            return Base * Altura;
        }

        public double Perimetro()
        {
            return 2 * (Base + Altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Base * Base + Altura * Altura);

        }
    }
}

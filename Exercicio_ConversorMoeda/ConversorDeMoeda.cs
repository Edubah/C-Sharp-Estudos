using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_ConversorMoeda
{
     class ConversorDeMoeda
    {
        /*
        public static double Iof = 0.06;
        public double Cot, Dolares; 

        public double Cotacao()
        {
            return Dolares * Cot;
        }

         public double Conversao()
        {
            return Cotacao() + (Cotacao() * Iof);
        }
        */
        public static double Iof = 6.0;
        public static double DolarParaReal(double quantia, double cotacao)
        {
            double total = quantia * cotacao;
            return total + total * Iof / 100.0;
        }

    }


}

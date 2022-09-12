using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercício
{
    internal class ContaBancaria
    {
        private string _titular;
        public string Resposta;
        public int Conta { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria() { }

        public ContaBancaria(int conta, string titular, double saldo)
        {
            Conta = conta;
            Titula = titular;
            Saldo = saldo;
        }

        public string Titula
        {
            get { return _titular; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _titular = value;
                }
            }
        }

        public void Deposito(double saldo)
        {
            Saldo += saldo;
        }

        public void Saque(double saldo)
        {
            Saldo -= saldo - 5.00;
        }

       


        public override string ToString()
        {
            return "Conta: "
                + Conta
                + ", "
                + "Titular: "
                + _titular
                + ", "
                + "Saldo: "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

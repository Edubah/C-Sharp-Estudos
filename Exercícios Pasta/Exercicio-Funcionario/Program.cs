using System;
using System.Globalization;

namespace Exercicio_Funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            Console.WriteLine("Nome: ");
            f.Nome = Console.ReadLine();

            Console.WriteLine("Salário Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário: " + f);

            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            double pct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarSalario(pct);

            Console.WriteLine("Dados Atualizados: " + f);
        }
    }
}
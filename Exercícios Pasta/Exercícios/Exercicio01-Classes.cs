// See https://aka.ms/new-console-template for more information

using System.Globalization;

   namespace Exercícios
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa01 n1, i1, s1;
            n1 = new Pessoa01();
            i1 = new Pessoa01();
            s1 = new Pessoa01();

            Pessoa02 n2, i2, s2;
            n2 = new Pessoa02();
            i2 = new Pessoa02();
            s2 = new Pessoa02();

            /*
            Console.WriteLine("Dados da primeira pessoa:");
            Console.WriteLine("Nome: " + n1.nome1);
            Console.WriteLine("Idade: " + i1.idade1);

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.WriteLine("Nome: " + n2.nome2);
            Console.WriteLine("Idade: " + i2.idade2);
            */

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.WriteLine("Nome: " + n1.nomeS);
            Console.WriteLine("Salário: " + s1.salario);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.WriteLine("Nome: " + n2.nomeS);
            Console.WriteLine("Salário: " + s2.salario);

            double media = (s1.salario + s2.salario) / 2.0;
            Console.WriteLine("Salário médio: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}


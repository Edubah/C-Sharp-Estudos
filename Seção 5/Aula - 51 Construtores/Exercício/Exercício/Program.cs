// See https://aka.ms/new-console-template for more information

using Exercício;
using System.Globalization;


    class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entre o número da conta: ");
        int conta = int.Parse(Console.ReadLine());

        Console.WriteLine("Entre com o titular da conta: ");
        string titular = Console.ReadLine();

        //Console.WriteLine("Haverá depósito inicial? (s/n)");
        Console.WriteLine("Entre com o valor do depósito: ");
        double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        ContaBancaria cb = new ContaBancaria(conta, titular, saldo);
    }
}
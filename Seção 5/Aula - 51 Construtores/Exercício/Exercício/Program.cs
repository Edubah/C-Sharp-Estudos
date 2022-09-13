// See https://aka.ms/new-console-template for more information

using Exercício;
using System.Globalization;

ContaBancaria conta; //Instancia CONTA como ContaBanncaria(Classe)


Console.Write("Entre o número da conta: ");
int numero = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.Write("Entre com o titular da conta: ");
string titular = Console.ReadLine();

Console.WriteLine("Haverá depósito inicial? (s/n)");
string resp = Console.ReadLine();

if (resp == "s" || resp == "S")
{
    Console.WriteLine();
    Console.Write("Entre com o valor do depósito inicial: ");
    double dinicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    conta = new ContaBancaria(numero, titular, dinicial); //Instanciando conta com parâmetros específicos dentro do IF
}
else
{
    conta = new ContaBancaria(numero, titular);
}


Console.WriteLine();
Console.Write("Dados da Conta: " + conta);
Console.WriteLine();

Console.WriteLine();
Console.Write("Entre com o valor do depósito: ");
double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Deposito(saldo);

Console.WriteLine();
Console.WriteLine("Dados atualizados:" + conta);

Console.WriteLine();
Console.Write("Entre com o valor do saque: ");
saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Saque(saldo);

Console.WriteLine();
Console.WriteLine("Dados atualizados: " + conta);

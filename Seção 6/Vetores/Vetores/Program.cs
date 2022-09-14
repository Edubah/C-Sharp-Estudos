// See https://aka.ms/new-console-template for more information


using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Net.Http.Headers;
using System.Numerics;
using Vetores;

/* Declaração de um vetor!!
Console.Write("Entre com o tamanho do vetor: ");
int n = int.Parse(Console.ReadLine());

double[] vect = new double[n];

for (int i = 0; i < n; i++)
{
    Console.Write("Entre com a medida: ");
    vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}

double soma = 0.00;
for (int i = 0; i < n; i++)
{
    soma += vect[i];
}

double med = soma / n;

Console.WriteLine("Média = " + med.ToString("F2", CultureInfo.InvariantCulture));

*/

/*
Console.Write("Entre com o tamanho do vetor: ");
int n = int.Parse(Console.ReadLine());

double[] vect = new double[n];

for (int i = 0; i < n; i++)
{
    Console.Write("Nome do Produto: ");
    string prod = Console.ReadLine();
    Console.Write("Entre com o preço: ");
    vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}

double soma = 0.00;
for (int i = 0; i < n; i++)
{
    soma += vect[i];
}

double med = soma / n;

Console.WriteLine("Média = " + med.ToString("F2", CultureInfo.InvariantCulture));

*/

//Usando Classe

Console.Write("Entre com o tamanho do vetor: ");
int n = int.Parse(Console.ReadLine());

//Criando o vetor como classe
Produto[] vet = new Produto[n];

for(int i = 0; i < n; i++)
{
    Console.Write("Nome do Produto: ");
    string name  = Console.ReadLine();
    Console.Write("Preço do Produto: ");
    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    //Instanciando o produto
    vet[i] = new Produto { Name = name, Preco = preco }; //Sintaxe de instanciação automática!
}

double soma = 0.00;
for (int i = 0 ; i < n ; i++)
{
    soma += vet[i].Preco; //Soma percorrerá vet na posição I visando apenas o preço!!!!
}


double media = soma / n;

Console.WriteLine("Média = " + media.ToString("F2", CultureInfo.InvariantCulture));
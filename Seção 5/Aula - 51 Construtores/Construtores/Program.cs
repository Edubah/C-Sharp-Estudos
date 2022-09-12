using Construtores;
using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        //Produto p = new Produto("TV", 900, 10); //Indica a instância "P" como nulo! Automaticamente já vem zerado!

        //É criada variáveis auxiliares para o usuário poder entrar com os dados para que depois eu possa instanciar com o Construtor!        
        Console.WriteLine("Entre com os dados do produto: ");
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Preço: ");
        double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Quantidade no Estoque: ");
       int quantidade = int.Parse(Console.ReadLine());

        Produto p = new Produto(nome, preco, quantidade); //Produto instanciado já com as info passadas pelo usuário.

        Console.WriteLine();
        Console.WriteLine("Dados do Produto: " + p);

        Console.WriteLine();
        Console.Write("Digite o número de produtos a ser adicionado no estoque: ");
        int qte = int.Parse(Console.ReadLine());
        p.AdicionarProdutos(qte);

        Console.WriteLine();
        Console.WriteLine("Dados Atualizados!!" + p);

        Console.WriteLine();
        Console.Write("Digite o número de produtos a ser excluído do estoque: ");
        qte = int.Parse(Console.ReadLine());
        p.RemoverProdutos(qte);

        Console.WriteLine();
        Console.WriteLine("Dados Atualizados!!" + p);
        

    }
}
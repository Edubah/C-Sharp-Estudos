// See https://aka.ms/new-console-template for more information
using Propriedades;
class Program
{
    static void Main(string[] args)
    {
        Produto p = new Produto("TV", 900, 50);

        p.Nome = "TV 4K";

        Console.WriteLine(p.Nome);
        Console.WriteLine(p.GetPreco());
    }
}
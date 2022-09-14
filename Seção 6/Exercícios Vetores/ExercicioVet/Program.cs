// See https://aka.ms/new-console-template for more information


using ExercicioVet;

Console.Write("Quantos quartos serão alugados? ");
int n = int.Parse(Console.ReadLine());

Estudante[] vet = new Estudante[10];

for (int i = 0; i < 10; i++)
{
    Console.WriteLine();
    Console.Write("Aluguel #" + vet[i]);
    Console.WriteLine();
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("E-mail: ");
    string email = Console.ReadLine();

    vet[i] = new Estudante { Nome = nome, Email = email };

    Console.Write("Quarto: ");
    int quarto = int.Parse(Console.ReadLine()); 
}

Console.WriteLine();
Console.WriteLine("Quartos ocupados:" + vet);
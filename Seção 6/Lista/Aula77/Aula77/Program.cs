// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

List<string> list = new List<string>();

//list.add <<- Método para adicionar um elemento na lista
list.Add("Eduardo");
list.Add("Ana");
list.Add("Alex");

//list.Insert <<- Método para adicionar a um ponto específico da lista (INSERIR)
list.Insert(2, "Manuel");

foreach(string obj in list)
{
    Console.WriteLine(obj);
}

//list.Count <<- Equivale ao tamanho da lista
Console.WriteLine("Tamanho da lista: " + list.Count);

//list.Find <<- Serve para procurar um elemento na lista e espera um "PREDICADO", o predicado no caso é uma função
//Predicado é uma função que pegar um valor e retorna "VERDADEIRO" ou "FALSO" conforme a lógica implementada nele 
string s1 = list.Find(x => x[0] == 'A'); //Expressão LAMBDA. TAL QUE (=>)
string s2 = list.FindLast(x => x[0] == 'A');

int pos1 = list.FindIndex(x => x[0] == 'A');
int pos2 = list.FindLastIndex(x => x[0] == 'A');

//Fazendo um filtro na lista;
//Será necessário declarar uma lista
//Procura nomes com mais de 5 caracteres 
List<string> list2 = list.FindAll(X => X.Length == 7); 






Console.WriteLine("-------------------------------------");
foreach (string obj in list2) { Console.WriteLine(obj); }   
Console.WriteLine("-------------------------------------");
Console.WriteLine("Primeiro nome com a letra A:" + s1);
Console.WriteLine("O último nome com a letra A:" + s2);
Console.WriteLine("Primeira posição: " + pos1);
Console.WriteLine("Última posição: " + pos2);


/*Função
 static bool Test(string s) { 
    return s[0] == 'A'; 
}
*/
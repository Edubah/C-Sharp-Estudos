// See https://aka.ms/new-console-template for more information

//Modificado REF

using Aula73;

int a = 10;         //Criou a variável "a
//Ao chamar esta função foi criado um escopo ao ir para a classe criando um escopo provisório com o 'x' valendo 10. Porém a conta será feita dentro da variável x e ao voltar para o
//main a variável 'a' não terá mudança alguma.
//Calculadora.Triplo(a);          
//Console.WriteLine(a);

//Para que o parâmetro passado se torne uma referência, utiliza-se o método REF para isso, fica assim:
Calculadora.Triplo(ref a);
Console.WriteLine(a);



//Modificador OUT:  é similar ao ref (faz o parâmetro ser uma referência para a variável original), mas não exige que a variável original seja iniciada.
//Neste exemplo inicio as 2 variáveis
int b = 10;
int triplo;
//Quando iniciar o programa passando o 'b' e o 'out triplo', vai ser criado o escopo da função ao iniciar na classe
//Com a variável oringin que será uma cópia da variável 'b' e a 'out int result' << Variável da classe, será referência para a variável que passou 'triplo'
//Então na classe, após guardar a conta na variável 'result' a mesma retornará para a variável 'triplo' já que faz referência.
Calculadora.TriploDois(b, out triplo);
Console.WriteLine(triplo);

/*
 Diferença:
• A variável passada como parâmetro ref DEVE ter sido iniciada

• A variável passada como parâmetro out não precisa ter sido iniciada

• Conclusão: ambos são muito similares, mas ref é uma forma de fazer

o compilador obrigar o usuário a iniciar a variável.

• Nota: ambos são considerados "code smells" (design ruim) e devem
ser evitados.
*/
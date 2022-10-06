// See https://aka.ms/new-console-template for more information


/*É um processo que automatiza o gerenciamento de memória de um
programa em execução

O garbage collector monitora os objetos alocados dinamicamente
pelo programa (no heap), desalocando aqueles que não estão mais
sendo utilizados.
*/


//Desalocação por Escopo
/*void metodo1()
{
    int x = 10;                                                     //No stack, haverá um método onde a variável x estará valendo 10
    if (x > 0)                                                      //Nesta parte quando entrar no IF, vai ser criada uma variável Y, pertecente ao escopo do IF e que está dentro do escopo do método 1
    {
        int y = 20;
    }
    Console.WriteLine(x);                                           //No momento em 
}
*/


//Outro Exemplo

/*
void metodo1()                                                      //Método entra no stack
{
    Product p = new metodo2();                                      //Declarando uma variável 'Product p' recebendo o resultado do método 2.
    Console.WriteLine(p.Nome); 
}

Product metodo2()                                                   //Criação do escopo deste método
{
    Product prod = new Product('TV', 900.0, 0);                     //Outra variável prod do tipo 'Produto' recebendo um new. A intância NEW cria um ligação no Heap. Em resumo a variável prod aponta para o novo objeto
    return prod                                                     //E aqui no final, ele retorna o conteúdo da variável prod
}                                                                   // Ao finalizar, o método 2 irá sumir e o metodo 1 apontará para onde o metodo 2 estava apontando

//Em resumo:
//Objetos alocados dinamicamente, quando não possuem mais referências para eles, serão desalocados pelo GARBAGE COLLECTOR

//Variáveis locais são desalocadas imediatamente após o seu escopo local sair de execução.

*/


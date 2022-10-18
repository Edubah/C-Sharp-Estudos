// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
/*Listas:

- Lista é uma estrutura de dados:
    * Homogênea(Logo os dados são do mesmo tipo)
    * Ordenada(OSPlatform elementos são acessados por meio de posições)
    * Inicia vazia, e seus elementos são alocados sob demanda.
    * Cada Elemento ocupa um 'nó' (ou nodo) da lista.
    * 
    * Classe: List
    * Namespace: Systema.Collections.Generic <- nome que vai no USING no começo do código
    * 
    * Vantagens: 
    *   Tamanho Variável;
    *   Facilidade para se realizar inserções e deleções;
    * Desvantagens:
    *   Acesso Sequencial aos elementos;
*/

List<string> list = new List<string>(); //Sintaxe da lista!

List<string> list2 = new List<string>() { "Maria", "Alex" }; //Lista já com elementos



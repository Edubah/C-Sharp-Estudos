// See https://aka.ms/new-console-template for more information

//NULLABLE

//É um recurso do C# para que os dados do tipo valor(Structs) possam receber o valor null
//Uso comum:
//Campos de bancos de dados que podem receber null(data de nascimento/ algum valor numérioco, etc)
//Dados e parâmetros adicionais

//double x = null; 

//Nullable<double> x = null;                                       //Forma 1 de fazer x ser nulo
//double? x = null;                                               //Forma 2 de fazer x ser nulo


//double? x = null;
//double? y = null;

//Console.WriteLine(x.GetValueOrDefault(); //O método faz a coleta do VALOR do x, caso não encontrar ele colocar o número padrão, neste caso 0, no caso de y é 10.0
//Console.WriteLine(x.HasValue); //Neste caso SE tiver valor na variável ele retorna uma resposta boleana
//Console.WriteLine(x.Value); //Este método lança um erro se chamá-la caso um objeto NULL estiver valendo NULL


//Operador de Coalescência nula
//retorna o valor do seu operando à esquerda - se não estiver null; caso contrário, avalia o operando manual direito - e retorna seu resultado.
//Obs. ?? <<- Este é o operador. 

//DEMO

double? x = null;
double? y = 10.0;

double a = x ?? 5;
double b = y ?? 5;

Console.WriteLine(a);
Console.WriteLine(b);



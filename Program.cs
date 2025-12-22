using System.Data;
using System.Reflection;
using BootCamp.Net__TIVIT.Models;


//Convertendo tipos de variáveis
//Cast implícito: acontece quando você quer converter um tipo de dado em um tipo de dado que é maior, na teoria o tipo de dado original "cabe" no outro tipo, então não precisa usar comando de conversão. 
int a = 5;
double b = a;

Console.WriteLine(b);

//Cast Explicito 
/*int inteiro = 5;
string a = inteiro.ToString(); //Unico comando necessário para converter qualquer tipo em string. 
Console.WriteLine(a);

A diferença entre os dois comandos é o tratamento de valores nulos (null, vazio), no convert se você passar um valor nulo ele converte para 0. Já no int.Parse, ele dá erro (o valor não pode ser nulo), ele não aceita e encerra o programa. Sendo assim, a melhor opção é usar sempre o Convert.  
int a = Convert.ToInt32("5"); convertendo a string em inteiro
int a = int.Parse("5c"); outra forma de converter string em inteiro
Console.WriteLine(a);*/

//Operador de atribuição 
/*int a = 10;
int b = 20;

int c = a + b;

//c = c + 5;
c += 5;
Console.WriteLine(c);*/

//DateTime
/*DateTime dataAtual = DateTime.Now.AddDays(5);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:MM"));*/


//Declarando os tipos de variáveis/Manipulando variáveis
/*string apresentacao = "olá, seja bem vindo";

int quantidade = 1;
Console.WriteLine("valor da variavel quantidade: " + quantidade);

quantidade = 10;
Console.WriteLine("valor da variavel quantidade: " + quantidade);


double altura = 1.63;

decimal preco = 1.80M; //para representar que é um decimal direto 

bool condicao = true;

Console.WriteLine("valor da variavel apresentacao: " + apresentacao);
Console.WriteLine("valor da variavel quantidade: " + quantidade);
Console.WriteLine("valor da variavel altura: " + altura.ToString("0.00")); //ToString(0.00) significa que o número ter vai ter 2 casas decimais. 
Console.WriteLine("valor da variavel preco: " + preco);
Console.WriteLine("valor da variavel condicao: " + condicao);*/


//Usando a classe Pessoa
/* Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Bitinha";
pessoa1.Idade = 23;
pessoa1.Apresentar(); */

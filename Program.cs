using System.Data;
using System.Dynamic;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.Serialization.Formatters;
using BootCamp.Net__TIVIT.Models;

//A principal diferença entre Listas e Arrays (embora listas sejam internamente arrays também) é a quantidade de métodos, as listas são mais completas por isso é sempre bom preferir usar listas ao invés de arrays sempre que possível. 

//Listas
List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");
listaString.Add("RJ");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("SC");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Remove("MG");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

/*Console.WriteLine("Percorrendo a lista com for");
//Percorrendo a lista com for
for (int contador = 0; contador < listaString.Count; contador++)
{
    Console.WriteLine($"Posição Nº {contador} - {listaString[contador]}");
}
//Percorrendo a lista com foreach
Console.WriteLine("Percorrendo a lista com foreach");
int contadorForeach = 0;
foreach (string item in listaString)
{
    Console.WriteLine($"Posição Nº {contadorForeach} - {item}");
    contadorForeach++;
}*/

/*Arrays
int[] arrayInteiros = new int[4];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;
arrayInteiros[3] = 1;

//Copiando elementos de um array antigo para um novo array.
int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

//redimensionando um array
Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

Console.WriteLine("Percorrendo o array com o FOR");
for (int contador = 0; contador < arrayInteiros.Length; contador++) //contador começa em 0 e vai incrementando até a capacidade máxima (length) 
{
    Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");
}

//Foreach (para cada) - percorre a lista ou o array sem depender de um contador. A desvantagem é não conseguir retornar qual a posição de um elemento no array, o que só é possível utilizando um contador. 

Console.WriteLine("Percorrendo o array com o FOREACH");

int contadorForeach = 0;
foreach (int valor in arrayInteiros)
{
    Console.WriteLine($"Posição Nº {contadorForeach} - {valor}");
    contadorForeach++;
}*/


/*string opcao;
bool exibirMenu = true;

while(exibirMenu)
{
    //Console.Clear();
    Console.WriteLine("Digite uma opção");
    Console.WriteLine("1 - Cadastrar Cliente");
    Console.WriteLine("2 - Buscar Cliente");
    Console.WriteLine("3 - Apagar Cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de Cliente");
            break;

        case "2":
            Console.WriteLine("Busca de Cliente");
            break;

        case "3":
            Console.WriteLine("Apagar de Cliente");
            break;

        case "4":
            Console.WriteLine("Encerrar");
        //    Environment.Exit(0);
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

}
Console.WriteLine("Programa encerrado");*/


//DO WHILE
// int soma = 0, numero = 0;

// do
// {
//     Console.WriteLine("Digite um número (0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// } while (numero != 0);

// Console.WriteLine($"Total da soma dos números digitados é: {soma}");


//Laço While (enquanto for verdadeiro) *Ter cuidado para não entrar em loop infinito. 
// int numero = 5;
// int contador = 0;
// //so precisa passar a condição
// while (contador <= 10)
// {
//     Console.WriteLine($"{contador + 1} Execução: {numero} x {contador} = {numero * contador} ");
//     contador++;

// }

//Laço de repetição FOR
// int numero = 10;
// //variavel, condição, incremento
// for (int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }

/*Calculadora calc = new Calculadora();
calc.Somar(10, 30);
calc.Subtrair(10, 50);
calc.Multiplicar(15, 45);
calc.Dividir(2, 2);
calc.Potencia(3, 3);
calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30);

int numeroIncremento = 10;
Console.WriteLine(numeroIncremento);
Console.WriteLine("Incrementando o 10");
numero = numero + 1;
numeroIncremento++;
Console.WriteLine(numeroIncremento);

int numeroDecremento = 20;
Console.WriteLine("Decrementando o 20");
numeroDecremento--;
Console.WriteLine(numeroDecremento);
calc.RaizQuadrada(9);*/

//Operador condicional

/*Operador NOT !!
bool choveu = true;
bool estaTarde = false;

if (!choveu && !estaTarde)
{
    Console.WriteLine("Vou pedalar");
}
else
{
    Console.WriteLine("Vou pedalar outro dia.");
}*/

/*Operador AND &&
bool possuiPresencaMinima = true;
double media = 6.5;

if(possuiPresencaMinima && media >= 7)
{
    Console.WriteLine("Aprovado");
}
else
{
    Console.WriteLine("Reprovado!");
}*/

/*Operador OR ||
bool ehMaiorDeIdade = false;
bool possuiAutorizacaoDoResponsavel = false;

if(ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
{
    Console.WriteLine("Entrada Liberada!");
}
else
{
    Console.WriteLine("Entrada não liberada.");
}*/

/*switch case 
Console.WriteLine("Digite um letra: ");
string letra = Console.ReadLine();

switch(letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;

    default:
        Console.WriteLine("Não é uma vogal.");
        break;
}

if (letra == "a" ||
    letra == "e" ||
    letra == "i" ||
    letra == "o" ||
    letra == "u")
{
    Console.WriteLine("Vogal");
}
else
{
    Console.WriteLine("Não é uma vogal.");
}*/

/*If Aninhado
int quantidadeEmEstoque = 10;
int quantidadeCompra = 0;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

if (quantidadeCompra == 0)
{
    Console.WriteLine("venda inválida.");
}
else if (possivelVenda)
{
    Console.WriteLine("Venda realizada!");
} 
else
{
    Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque.");
}*/

//Convertendo tipos de variáveis
/*TryParse - Conversão segura. 
string a = "15-";
int b = 0;
int.TryParse(a, out b); // a lógica no tryparse: eu vou tentar converter o a, porém o a pode não ser um número e isso fará gerar o erro, o valor de a apresentando um erro, meu valor de saída será o valor de b.

Console.WriteLine(b);
Console.WriteLine("Conversão realizada com sucesso");*/

/*Cast implícito: acontece quando você quer converter um tipo de dado em um tipo de dado que é maior, na teoria o tipo de dado original "cabe" no outro tipo, então não precisa usar comando de conversão. 
int a = 5;
double b = a;

Console.WriteLine(b);*/

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

pessoa1.Nome = "Gabriela";
pessoa1.Idade = 23;
pessoa1.Apresentar(); */

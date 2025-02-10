using Menu;
using Microsoft.VisualBasic;
class Program{

public static decimal IsNumber()
{
    decimal valor = 0;
    while(!decimal.TryParse(Console.ReadLine(), out valor))
    {
        Console.Write("Valor inválido, tente outro: ");
    }

    return valor;
}





static void Main(string[]args){

string opcao = "";
decimal n1 = 0;
decimal n2 = 0;

Console.Write("Teste");
opcao = Navegacao.ImprimirMenu();

IsNumber();

Console.Write("Digite o primeiro número: ");
while(!decimal.TryParse(Console.ReadLine(), out n1))
{
    Console.Write("Digite um número válido: ");
}

Console.Write("Digite o segundo número: ");
while(!decimal.TryParse(Console.ReadLine(), out n2))
{
    Console.Write("Digite um número válido: ");
}

switch (opcao)
{
    case "1":
        Console.Write($"{n1} + {n2} = {Math.Round(n1 + n2)}");
        break;
    case "2":
        Console.Write($"{n1} - {n2} = {Math.Round(n1 - n2)}");
        break;
    case "3":
        Console.Write($"{n1} x {n2} = {Math.Round(n1 * n2)}");
        break;
    case "4":
        Console.Write($"{n1} / {n2} = {Math.Round(n1 / n2)}");
        break;
    default:
        Console.Write("Erro inesperado!");
        break;
}
}
}
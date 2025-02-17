
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Security.AccessControl;
using Layout;
using GerenciarTarefa;

public class Program
{
    static void Main(string[]args)
    {
        int opcao;

        do
        {
            opcao = Formatacao.ImprimirCabecalho();

            switch(opcao)
            {
                case 1:
                    Console.Write("Digite o nome da tarefa: ");
                    string nomeTarefa = Console.ReadLine();
                    GerenciarTarefa.GerenciarTarefa.NovaTarefa($"{nomeTarefa}");
                    break;
                case 2:
                    GerenciarTarefa.GerenciarTarefa.ExibirTarefa();
                    break;
                case 3:
                    Console.Write("Digite a tarefa deseja concluir: ");
                    int con;
                    while(!int.TryParse(Console.ReadLine(), out con))
                    {
                        Console.Write("Valor inválido, tente novamente: ");
                    }
                    GerenciarTarefa.GerenciarTarefa.Concluir(con);
                    Console.Write(con);
                    break;
                case 4:
                    Console.Write("Digite o ID que deseja remover: ");
                    int del;
                    while(!int.TryParse(Console.ReadLine(), out del))
                    {
                        Console.Write("Valor inválido, tente novamente: ");
                    }
                    GerenciarTarefa.GerenciarTarefa.RemoverTarefa(del);
                    break;
                case 0:
                    Console.Write("Saindo...");
                    break;
                default:
                    Console.Write("Erro!");
                    break;
            }
        }while(opcao != 0);

    }
}



using System.Diagnostics;
using System.Reflection.Metadata;
using System.Security.AccessControl;
using Layout;
using GerenciarTarefa;

public class Program
{
    public static int ConferirNumero(int valor)
    {
        int id;

        while(!int.TryParse(Console.ReadLine(), out id))
        {
            Console.Write("Valor inválido, tente novamente: ");
        }
    
        return id;
    }

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
                    int con = 0;
                    ConferirNumero(con);
                    GerenciarTarefa.GerenciarTarefa.Concluir(con);
                    Console.Write(con);
                    break;
                case 4:
                    Console.Write("Digite o ID que deseja remover: ");
                    int del = 0;
                    ConferirNumero(del);
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



using System.Diagnostics;
using System.Reflection.Metadata;
using System.Security.AccessControl;
using Layout;
using Tarefa;
using GerenciarTarefa;

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
            int con = int.Parse(Console.ReadLine());
            
            GerenciarTarefa.GerenciarTarefa.Concluir(con);
            break;
        case 4:
            Console.Write("Digite o ID que deseja remover: ");
            int del = int.Parse(Console.ReadLine());

            GerenciarTarefa.GerenciarTarefa.RemoverTarefa(del);
            break;
        default:
            Console.Write("Erro!");
            break;
    }
}while(opcao != 0);


//Loop no Program não aceita opção 0
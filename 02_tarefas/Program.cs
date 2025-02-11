
using System.Diagnostics;

public class Tarefas
{
    public int Id {get; set;}
    private static int contId = 1;
    public bool Concluida {get; set;}
    public string Nome {get; set;}
    public static List<Tarefas> tarefas = new List<Tarefas>();

    public Tarefas(string nome)
    {
        Id = contId++;
        Concluida = false;
        Nome = nome;
    }

    public static void NovaTarefa(string nome)
    {
        tarefas.Add(new Tarefas(nome));
    }

    public static void Concluir(int id)
    {   
        var tarefa = tarefas.FirstOrDefault(t => t.Id == id);  // Procura a tarefa pelo ID
        if (tarefa != null)
        {
            tarefa.Concluida = true;  // Marca a tarefa como concluída
            Console.WriteLine($"Tarefa {tarefa.Id} concluída!");
        }
        else
        {
            Console.WriteLine("Tarefa não encontrada!");
        }
    }
}

class Program
{
static void Main(string[]args)
{
    int opcao;
    do
    {
        Console.WriteLine("Gerenciador de Tarefas");
        Console.WriteLine("1. Adicionar tarefa");
        Console.WriteLine("2. Listar tarefas");
        Console.WriteLine("3. Concluir tarefa");
        Console.WriteLine("4. Remover tarefa");
        Console.WriteLine("0. Sair");
        Console.Write("Escolha uma opção: ");

        while(!int.TryParse(Console.ReadLine(), out opcao) || opcao < 0 || opcao > 4)
        {
            Console.Write("Erro! Escolha uma opção válida: ");
        }


        switch(opcao)
        {
            case 1:
                Console.Write("Digite o nome da tarefa: ");
                string nomeTarefa = Console.ReadLine();
                Tarefas.NovaTarefa($"{nomeTarefa}");
                break;
            case 2:
                foreach(var tarefa in Tarefas.tarefas)
                {
                    string status = tarefa.Concluida == true ? "X" : " ";
                    Console.WriteLine($"[{status}] {tarefa.Id} - {tarefa.Nome}");
                }
                break;
            case 3:
                Console.Write("Digite a tarefa deseja concluir: ");
                int con = int.Parse(Console.ReadLine());

                Tarefas.Concluir(con);
                break;
            case 4:
                Console.Write("Digite o ID que deseja remover: ");
                int del = int.Parse(Console.ReadLine());

                Tarefas.tarefas.RemoveAt(del - 1);
                break;
            default:
                Console.Write("Erro!");
                break;
        }
    }while(opcao != 0);

}
}


using Tarefa;

namespace GerenciarTarefa
{
    public class GerenciarTarefa
    {
        public static void NovaTarefa(string nome)
        {
            Tarefas.tarefas.Add(new Tarefas(nome));
        }

        public static void Concluir(int id)
        {   
            var tarefa = Tarefas.tarefas.FirstOrDefault(t => t.Id == id);  // Procura a tarefa pelo ID
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

        public static void ExibirTarefa()
        {
            foreach(var tarefa in Tarefas.tarefas)
            {
                string status = tarefa.Concluida == true ? "X" : " ";
                Console.WriteLine($"[{status}] ID: {tarefa.Id} - {tarefa.Nome}");
            }
        }

        public static void RemoverTarefa(int id)
        {   
            var tarefa = Tarefas.tarefas.FirstOrDefault(t => t.Id == id);  // Procura a tarefa pelo ID
            if (tarefa != null)
            {
                Tarefas.tarefas.Remove(tarefa);  // Remove a tarefa da lista
                Console.WriteLine($"Tarefa {tarefa.Id} removida com sucesso!");
            }
            else
            {
                Console.WriteLine("Tarefa não encontrada!");
            }
        }
    }
}
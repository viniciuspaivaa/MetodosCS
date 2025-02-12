namespace Tarefa
{
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
    }
}
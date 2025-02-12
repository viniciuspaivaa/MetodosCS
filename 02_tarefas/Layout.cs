using GerenciarTarefa;

namespace Layout
{
    public class Formatacao
    {
        public static void Cor(string msg, string cor)
        {
            ConsoleColor novaCor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), cor, true);
            Console.ForegroundColor = novaCor;
            Console.Write(msg);
            Console.ResetColor();
        }

        public static int ImprimirCabecalho()
        {
            int opcao;

            Console.Clear();

            GerenciarTarefa.GerenciarTarefa.ExibirTarefa();

            Console.WriteLine($"╔{new string('═', 24)}╗");
            Console.WriteLine($"║ Gerenciador de Tarefas ║");
            Console.WriteLine($"╚{new string('═', 24)}╝");

            Console.WriteLine("1. Adicionar tarefa");
            Console.WriteLine("2. Listar tarefas");
            Console.WriteLine("3. Concluir tarefa");
            Console.WriteLine("4. Remover tarefa");
            Console.WriteLine("0. Sair");
            Console.Write("\nEscolha uma opção: ");

            while(!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.Write("Digite um valor válido: ");
            }

            return opcao;
        }
    }
}


List<string> tarefas = new List<string>();

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
            string nomeTarefa = Console.ReadLine();
            int qntd = tarefas.Count() + 1;
            for(int i = 0; i)
            tarefas.Add($"[ ] ID: {qntd}  - {nomeTarefa}");
            break;
        case 2:
            foreach(string tarefa in tarefas)
            {
                Console.WriteLine(tarefa);
            }
            break;
        case 3:
            
            break;
        case 4:
            Console.Write("Digite o ID que deseja remover: ");
            int del = int.Parse(Console.ReadLine());

            tarefas.RemoveAt(del - 1);
            break;
        default:
            Console.Write("Erro!");
            break;
    }
}while(opcao != 0);


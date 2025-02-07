namespace Menu
{
    public class Navegacao
    {
        public static string ImprimirMenu()
        {
            string opcao = "";

            do
            {
                Console.Clear();

                Console.Write("Bem-vindo à Calculadora!");
                Console.Write("\n\n1. Soma");
                Console.Write("\n2. Subtração");
                Console.Write("\n3. Multiplicação");
                Console.Write("\n4. Divisão");
                Console.Write("\ns. Sair");
                Console.Write("\n\nQual cálculo deseja realizar: ");
                return opcao = Console.ReadLine();

            } while(opcao != "s");
        }
    }
}
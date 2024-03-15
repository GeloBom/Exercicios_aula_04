namespace Exercicio._20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Bem-vindo ao Programa de Ordenação Decrescente!\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();

                double numero = double.Parse(GetInput("Por favor, insira o numero:"));
                if (numero % 2 != 0)
                {
                    Console.WriteLine($"\nO número {numero} é ímpar.");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                else
                {
                    Console.WriteLine($"\nO número {numero} é par.");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
            }
        }

        static string GetInput(string mensagem)
        {
            Console.WriteLine(mensagem);
            string userInput = Console.ReadLine();
            return userInput;
        }
    }
}

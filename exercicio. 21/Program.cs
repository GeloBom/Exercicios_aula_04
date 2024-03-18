namespace Exercicio._21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Programa de operação similar!\nPressione qualquer tecla para continuar...");
            Console.ReadKey();

            double numeroA = double.Parse(GetInput("Por favor, insira o primeiro número:"));
            double numeroB = double.Parse(GetInput("Por favor, insira o segundo número:"));
            double numeroC = 0;

            if (numeroA == numeroB)
            {
                numeroC = numeroA + numeroB;
            }
            else if (numeroA != numeroB)
            {
                numeroC = numeroA * numeroB;
            }

            Console.WriteLine($"O valor de C é: {numeroC}");

            string getInput(string mensagem)
            {
                Console.WriteLine(mensagem);
                string userInput = Console.ReadLine();
                return userInput;
            }
        }
    }
}
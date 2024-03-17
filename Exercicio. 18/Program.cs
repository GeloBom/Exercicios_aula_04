namespace Exercicio._18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Programa de Ordenação Decrescente!\nPressione qualquer tecla para continuar...");
            Console.ReadKey();

            double numero01 = double.Parse(GetInput("Por favor, insira o primeiro número:"));
            double numero02 = double.Parse(GetInput("Por favor, insira o segundo número:"));
            double numero03 = double.Parse(GetInput("Por favor, insira o terceiro número:"));

            double[] numeros = { numero01, numero02, numero03 };

            Array.Sort(numeros);
            Array.Reverse(numeros);

            Console.WriteLine("Números em ordem decrescente:");
            foreach (double numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }

         string GetInput(string mensagem)
        {
            Console.WriteLine(mensagem);
            string userInput = Console.ReadLine();
            return userInput;
        }
    }
}

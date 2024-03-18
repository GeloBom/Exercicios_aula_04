namespace Exercicio._25_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Programa de calculo de fatorial!\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
           
            int numeroInput = int.Parse(GetInput("Por favor, insira o número para calcular o fatorial:"));

            if (numeroInput < 0)
            {
                Console.WriteLine("Operação inválida! Por favor, digite um número positivo:");
            }
            else
            {
                int fatorial = 1;
                string sequencia = "";

                for (int numeroReal = numeroInput; numeroReal > 0; numeroReal--)
                {
                    fatorial *= numeroReal;

                    if (numeroReal != numeroInput)
                    {
                        sequencia += " x ";
                    }
                    sequencia += numeroReal;
                }

                Console.WriteLine($"{numeroInput}! = {sequencia} = {fatorial}");
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
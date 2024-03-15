namespace Exercicio._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao programa de conversao de Cº para Fº!\nDigite qualquer tecla para continuar...");
            Console.ReadKey();

            double valorCelcius = double.Parse(getInput("informe o valor em Cº para a conversao (Fº)"));
            double resultadoConversao = (valorCelcius * 9 / 5) + 32;

            Console.WriteLine($"Seu valor em Fº é de:{resultadoConversao}Fº");

            string getInput(string mensagem)
            {
                Console.WriteLine(mensagem);
                string userInput = Console.ReadLine();
                return userInput;
            }
        }
    }
}
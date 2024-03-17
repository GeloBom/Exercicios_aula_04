namespace Exercicios_aula_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao programa de conversao de Fº para Cº!\nDigite qualquer tecla para continuar...");
            Console.ReadKey();

            int valorFahrenheit = int.Parse(getInput("informe o valor em Fº para a conversao (Cº"));
            
            double resultadoConversao = 9 / 5 * (valorFahrenheit - 32);

            Console.WriteLine($"Seu valor em Cº é de:{resultadoConversao:F2},Cº");

            string getInput(string mensagem)
            {
                Console.WriteLine(mensagem);
                string userInput = Console.ReadLine();
                return userInput;
            }
        }
    }
}
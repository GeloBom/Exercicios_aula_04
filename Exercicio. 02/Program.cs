namespace Exercicios_aula_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valorCelcius = int.Parse(getInput("informe o valor em Cº para a conversao (Fº"));
            double resultadoConversao = (valorCelcius * 9 / 5) + 32;

            Console.WriteLine($"Seu valor em Fº é de:{resultadoConversao:F2},Fº");

            string getInput(string mensagem)
            {
                Console.WriteLine(mensagem);
                string userInput = Console.ReadLine();
                return userInput;
            }
        }
     }
}
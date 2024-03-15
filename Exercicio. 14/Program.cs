namespace Exercicio._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao programa de calculo de dias vividos!\nDigite qualquer tecla para continuar...");
            Console.ReadKey();

            Console.WriteLine("Por favor, digite o seu nome:");    
            string nomeIndividuo = Console.ReadLine();
            
            int idade = int.Parse(getInput("Por favor, informe a sua idade para prosseguir:"));

            int idadeDias = idade * 365;

            Console.WriteLine($"Olá, {nomeIndividuo}! Você já viveu aproximadamente {idadeDias} dias.");
            Console.ReadKey();

            string getInput(string mensagem)
            {
                Console.WriteLine(mensagem);
                string userInput = Console.ReadLine();
                return userInput;
            }
        }
    }
}

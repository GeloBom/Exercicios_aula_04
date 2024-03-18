namespace Exercicio._24_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Bem-vindo ao Programa leitor devariaveis 1 a 10 e aplicalas a tabuada!\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();

                int numeroUsuario = int.Parse(GetInput("Por favor, insira um número entre 1 e 10:"));

                if (numeroUsuario < 1 || numeroUsuario > 10)
                {
                    Console.WriteLine("Número inválido! Por favor, insira um número entre 1 e 10.\nDigite uma tecla para continuar...");
                    Console.ReadKey();  
                    Console.Clear();
                    continue;
                }
                else
                {
                    Console.WriteLine($"Tabuada de {numeroUsuario}:");
                    Console.WriteLine("------------------------------------");

                    for (int operacaoTabuada = 1; operacaoTabuada <= 10; operacaoTabuada++)
                    {
                        int resultado = numeroUsuario * operacaoTabuada;
                        Console.WriteLine($"{numeroUsuario} x {operacaoTabuada} = {resultado}");
                    }
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

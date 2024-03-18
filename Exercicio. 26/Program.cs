namespace Exercicio._26
{
    namespace Exercicio._26
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Bem-vindo ao Programa leitor de sequencia de Fibonacci!\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();

                while (true)
                {
                    int numero = int.Parse(GetInput("Digite um número para a sequência de Fibonacci: "));

                    Console.WriteLine("Sequência de Fibonacci até " + numero + ":");

                    int a = 0;
                    int b = 1;

                    while (a <= numero)
                    {
                        Console.WriteLine(a);
                        int proximo = a + b;
                        a = b;
                        b = proximo;

                        if (b > numero)
                        {
                            Console.WriteLine($"{a}");
                            Console.WriteLine($"O próximo número é maior que o valor inserido.\nPróximo número na sequência: {proximo}");
                            Console.WriteLine("Pressione uma tecla para tentar novamente...");
                            Console.ReadKey();
                            Console.Clear();
                            break;
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
}
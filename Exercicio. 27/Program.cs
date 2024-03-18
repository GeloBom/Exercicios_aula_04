namespace Exercicio._27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Programa de numeração (1 a 100) com os nomes fizz para multiplos por 3, buzz para multiplos por 5 e FizzBuzz para multiplos pelos 2 numeros.\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
            
            for (int numero = 1; numero <= 100; numero++)
            {
                if (numero % 3 == 0 && numero % 5 == 0)
                {
                    Console.WriteLine($"{numero} = FizzBuzz (Multiplo de 3 e 5)");
                }
                else if (numero % 3 == 0)
                {
                    Console.WriteLine($"{numero} = Fizz (Multiplo por 3)");
                }
                else if (numero % 5 == 0)
                {
                    Console.WriteLine($"{numero} = Buzz (Multiplo por 5)");
                }
                else
                {
                    Console.WriteLine(numero);
                }
            }
        }
    }
}

namespace Exercicio._28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Programa de tabuada em tabelas dos numeros 1 a 10!\nPressione qualquer tecla para continuar...");
            Console.ReadKey();

            Console.WriteLine("Tabuada de Multiplicação (1 a 10):\n");

            Console.WriteLine("  +-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+");

            for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
            {
                Console.Write("  |");

                for (int multiplicando = 1; multiplicando <= 10; multiplicando++)
                {
                    int resultado = multiplicador * multiplicando;
                    Console.Write($" {resultado,3} |");
                }

                Console.WriteLine();
                Console.WriteLine("  +-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+");
            }
        }
    }
}
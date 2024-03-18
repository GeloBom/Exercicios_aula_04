namespace Exercicio._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Programa de reconhecimento de valores impares entre 100 e 200!\nPressione qualquer tecla para continuar...");
            Console.ReadKey();

            Console.WriteLine("\nNumeros impares entre 100 e 200 são respectivamente:");

            for (int numero = 100; numero <= 200; numero++)
            {
                if (numero % 2 != 0)
                {
                    Console.WriteLine(numero);
                }

            }
        }
    }
}

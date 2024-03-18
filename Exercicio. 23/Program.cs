namespace Exercicio._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Programa de soma de numeros multiplos de 3 até 500!\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            int soma = 0;

            for (int numero = 1; numero <= 500; numero++) // For = usado para repetição de numeros (incialização, condição, incremento);
            {
                if (numero % 2 != 0 && numero % 3 == 0) // (numero % 2 != 0) Verifica se é ímpar, numero % 3 == 0) Confirma se é multiplo de 3;
                {
                    soma += numero;
                }
            }
            Console.WriteLine($"A soma dos números ímpares múltiplos de três de 1 até 500 é de: {soma}");
            Console.ReadKey();
        }
    }
}

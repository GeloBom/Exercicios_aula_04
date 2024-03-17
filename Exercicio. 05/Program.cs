namespace Exercicio._05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Programa de calculo de volume da esfera!\nPressione qualquer tecla para continuar...");
            Console.ReadKey();


            double raio = double.Parse(GetInput("Por favor, insira o raio do cilindro:\n"));
            Console.Clear();

            Console.WriteLine($"O valor de raio inserido foi de {raio:F}m³.\nPara mostrar o resultado da area da esfera, aperte qualquer tecla...");
            Console.ReadKey();
            Console.Clear();

            double resultado = (4 / 3 * Math.PI) * Math.Pow(3, raio);
            Console.WriteLine($"O resultado foi de {resultado.ToString("F")}m³");
            Console.ReadKey();

            string GetInput(string mensagem)
            {
                Console.WriteLine(mensagem);
                string userInput = Console.ReadLine();
                return userInput;


            }
        }
    }
}

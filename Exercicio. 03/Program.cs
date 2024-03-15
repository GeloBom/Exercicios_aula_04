namespace Exercicio._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao programa para o calculo do volume do cilindro!\n\nDigite qualquer tecla para continuar...\n");
            Console.ReadKey();
            Console.Clear();

            double raio = double.Parse(getInput("Por Favor, informe o raio do cilindro:"));
            double altura = double.Parse(getInput("\nPor Favor, informe a altura do cilindro:"));
            Console.Clear();    

            Console.WriteLine($"O valor de raio informado é de {raio}m²\n\nE o valor da altura é de {altura}m\n\nDigite qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            double resultadoVolumeCilindro = (Math.PI * Math.Pow(raio, 2)) * altura;
            Console.WriteLine($"O volume do cilindro é de: {resultadoVolumeCilindro.ToString("F")}m³");
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

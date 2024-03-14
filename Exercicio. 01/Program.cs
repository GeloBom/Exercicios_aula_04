namespace Exercicios_aula_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao programa para calculo do volume de retangulo!\n Digite qualquer tecla para continuar...");
            Console.ReadKey();
            
            double valorComprimento = double.Parse(getInput("informe o valor de comprimento em (m) para prosseguir"));
            double valorAltura = double.Parse(getInput("informe o valor de altura em (m) para prosseguir"));
            double valorLargura = double.Parse(getInput("informe o valor largura em (m) para prosseguir"));
            double ResultadoOperação = (valorComprimento * valorAltura * valorLargura);

            Console.WriteLine($"O volume do retangulo é de:{ResultadoOperação:F2}m³");

            string getInput(string mensagem)
            {
                Console.WriteLine(mensagem);
                string userInput = Console.ReadLine();
                return userInput;
            }
        }
    }
}

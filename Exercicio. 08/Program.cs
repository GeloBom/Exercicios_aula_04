namespace Exercicio._08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao programa de calculo de volume em uma lata de óleo!\nDigite Qualquer tecla para continuar...");
            Console.ReadKey();

            double raio = double.Parse(getInput("informe o raio da lata de óleo em (m):"));
            double altura = double.Parse(getInput("informe a altura da lata de óleo (m):"));

            double Volume = Math.PI * Math.Pow(2, raio) * altura;

            Console.WriteLine($"O volume total da lata de óleo é de:{Volume}m³");
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

namespace Exercicio._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao programa de calculo da padaroa HotPão!\n Digite qualquer tecla para continuar...");
            Console.ReadKey();

            double paesVendidos = double.Parse(getInput("informe o numero de pães vendidos para prosseguir"));
            double valorPaes = paesVendidos * 0.12;
            Console.WriteLine($"O valor arrecadado com a venda de pães foi: {valorPaes}");

            
            double broaVendidas = double.Parse(getInput("informe o numero de broas vendidas para prosseguir"));
            double valorBroas = broaVendidas * 1.5;
            Console.WriteLine($"O valor arrecadado com a venda de broas foi: {valorBroas}");

            double vendaTotal = valorPaes  + valorBroas;

            Console.WriteLine($"O valor total arrecadado:{vendaTotal}");
            
            double poupanca = (vendaTotal * 0.1);
            Console.WriteLine($"O valor a ser reservado para poupança de 10%, deve ser de: {poupanca.ToString("F")}");

            string getInput(string mensagem)
            {
                Console.WriteLine(mensagem);
                string userInput = Console.ReadLine();
                return userInput;
            }
        }
    }
}

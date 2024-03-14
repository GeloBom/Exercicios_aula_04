namespace Exercicio._07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao programa de calculo de salario mensal!\nDigite Qualquer tecla para continuar...");
            Console.ReadKey();
            
            double salarioBase = int.Parse(getInput("informe seu salario base:"));
            double vendas = int.Parse(getInput("informe seu salario base:"));
            double comissaoFixa = int.Parse(getInput("informe seu salario base:"));

            double salarioTotal = salarioBase + (vendas * (comissaoFixa / 100));
           
            Console.WriteLine($"Seu salário total é de:{salarioTotal:F2}R$");
            
            string getInput(string mensagem)
            {
                Console.WriteLine(mensagem);
                string userInput = Console.ReadLine();
                return userInput;
            }
        }
    }
}

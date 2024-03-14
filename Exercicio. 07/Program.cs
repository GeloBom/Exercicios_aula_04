namespace Exercicio._07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao programa de calculo de salario mensal!\nDigite Qualquer tecla para continuar...");
            Console.ReadKey();
            
            double salarioBase = double.Parse(getInput("informe seu salario base:"));
            double vendas = double.Parse(getInput("informe o valor total de vendas nesse mês"));
            double comissaoFixa = double.Parse(getInput("informa a porcentagem de comissão fixa:"));

            double salarioTotal = salarioBase + (vendas * (comissaoFixa / 100));
           
            Console.WriteLine($"Seu salário total é de:{salarioTotal:F2}R$");
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

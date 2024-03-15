namespace Exercicio._16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao programa de calculo de  aumento salarial!\nDigite qualquer tecla para continuar...");
            Console.ReadKey();

            Console.WriteLine("Digite o seu nome para continuar:");
            string nomeUsuario =  Console.ReadLine();

            double salarioIncial = double.Parse(getInput("informe o seu salario:"));

            double aumentoSalarial = 0.15 * salarioIncial;
            double salarioPosAumento = aumentoSalarial + salarioIncial;
            Console.WriteLine($"Parabéns, {nomeUsuario}! Seu aumento salarial é de: {aumentoSalarial:C}");

            double descontoSalarial = 0.08 * salarioPosAumento;
            double salarioFinal = salarioPosAumento - descontoSalarial;
            Console.WriteLine($"{nomeUsuario}, seu salário após o aumento é de: {salarioFinal:C}. \nDescontado com os impostos de: {descontoSalarial:C}");

            string getInput(string mensagem)
            {
                Console.WriteLine(mensagem);
                string userInput = Console.ReadLine();
                return userInput;
            }
        }
    }
}

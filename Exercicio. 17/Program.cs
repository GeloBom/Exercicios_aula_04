namespace Exercicio._17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Bem vindo ao programa para calculo de valores A, B e C!\nDigite qualquer tecla para continuar...");
                Console.ReadKey();

                double valorA = double.Parse(getInput("informe o valor de A para prosseguir"));
                double valorB = double.Parse(getInput("informe o valor de B para prosseguir"));
                double valorC = double.Parse(getInput("informe o valor de C para prosseguir"));

                double resultadoAB = (valorA + valorB);

                if (resultadoAB > valorC)
               
                {
                    Console.WriteLine($"A soma dos valores A + B = {resultadoAB}  é maior que {valorC}\ndigite qualquer tecla para tentar novamente!");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                
                double resultado = (valorA + valorB + valorC);
                Console.WriteLine($"A soma dos valores A + B + C é de {resultado}");
                
                Console.WriteLine("Digite qualquer tecla para continuar...");
                Console.ReadKey();

               
                Console.Clear();
            }
            
            string getInput(string mensagem)
            {
                Console.WriteLine(mensagem);
                string userInput = Console.ReadLine();
                return userInput;
            }
        }
    }
}

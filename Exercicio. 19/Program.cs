namespace Exercicio._19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Programa de Cálculo de IMC (Índice de Massa Corporal)\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            double pesoKg = double.Parse(GetInput("Por favor, informe o seu peso em Kg para prosseguir:"));
            Console.Clear();

            double alturaM = double.Parse(GetInput("Por favor, informe a sua altura em metros para prosseguir:"));
            Console.Clear();
            
            Console.WriteLine($"O peso informado foi de: {pesoKg}Kg e sua altura é de: {alturaM} m.\nPara calcular seu IMC (Índice de Massa Corporal), pressione qualquer tecla...\n");
            Console.ReadKey();
            Console.Clear();

            double indiceMassaCorporal = pesoKg / Math.Pow(alturaM, 2);

            string resultadoIMC;

            switch (indiceMassaCorporal)
            {
                case double imc when imc < 18.5:
                    resultadoIMC = "Abaixo do peso";
                    break;
                case double imc when imc >= 18.5 && imc < 25:
                    resultadoIMC = "Peso normal";
                    break;
                case double imc when imc >= 25 && imc < 30:
                    resultadoIMC = "Sobrepeso";
                    break;
                case double imc when imc >= 30 && imc < 35:
                    resultadoIMC = "Obesidade grau I";
                    break;
                case double imc when imc >= 35 && imc < 40:
                    resultadoIMC = "Obesidade grau II (severa)";
                    break;
                default:
                    resultadoIMC = "Obesidade grau III (mórbida)";
                    break;
            }
            Console.WriteLine("Tabela de Índice de Massa Corporal (IMC):\n");
            Console.WriteLine("| IMC             | Classificação                   |");
            Console.WriteLine("|-----------------|--------------------------------|");
            Console.WriteLine("| Abaixo de 18.5  | Abaixo do peso                 |");
            Console.WriteLine("| 18.5 - 24.9     | Peso normal                    |");
            Console.WriteLine("| 25 - 29.9       | Sobrepeso                      |");
            Console.WriteLine("| 30 - 34.9       | Obesidade grau I               |");
            Console.WriteLine("| 35 - 39.9       | Obesidade grau II (severa)     |");
            Console.WriteLine("| 40 ou mais      | Obesidade grau III (mórbida)   |\n");

            Console.WriteLine($"Seu IMC é de: {indiceMassaCorporal:F2}. Isso é classificado como: {resultadoIMC}\n Digite qualquer tecla para sair do programa...");
            Console.ReadKey();

            static string GetInput(string mensagem)
            {
                Console.WriteLine(mensagem);
                string userInput = Console.ReadLine();
                return userInput;
            }


        }
    }
}
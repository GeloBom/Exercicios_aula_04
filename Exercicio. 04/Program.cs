namespace Exercicio._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Bem-vindo ao Programa de calculo de consumo de combustivel por km!\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();

                double kminicial = double.Parse(GetInput("Por favor, insira a quilometragem inicial:"));
                double kmfinal = double.Parse(GetInput("Por favor, insira a quilometragem final:"));

                if (kminicial > kmfinal)
                {
                    Console.WriteLine("Operação invalida. A quilometragem inical deve ser menor que a final.\nDigite uma tecla para tentar novamente...");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                double consumoCombustivel = double.Parse(GetInput("Por favor, insira a quantidade de combustivel usado durante o trajeto:"));
                Console.Clear();
                Console.WriteLine($"Os valores informados foram de:\n- Quilometragem Inicial: {kminicial:F}km\n- Quilometragem Final: {kmfinal:F} km\n- Consumo de combustivel: {consumoCombustivel:F} km");

                double resultado = (kminicial - kmfinal) / consumoCombustivel;
                Console.WriteLine($"\nO consumo de combustivel por km é de: {consumoCombustivel:F} km/l\n\n\nDigite uma tecla para efetuar a operação novamente...");
                Console.ReadKey();
                Console.Clear();


            }

            static string GetInput(string mensagem)
            {
                Console.WriteLine(mensagem);
                string userInput = Console.ReadLine();
                return userInput;
            }
        }
    }
}

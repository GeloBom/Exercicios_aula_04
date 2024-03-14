namespace Exercicio._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Bem-vindo ao Calculador de Área de Retângulo!\r\nEste programa vai te ajudar a calcular a área de um retângulo.\r\nDigite qualquer tecla para continuar...");
                Console.ReadKey();

                double comprimento = double.Parse(getInput("Informe o comprimento do terreno para prosseguir"));
                double largura = double.Parse(getInput("Informe a largura do terreno para prosseguir"));

                if (comprimento == largura)
                {
                    Console.WriteLine("O comprimento não pode ser igual à largura. Por favor, insira valores diferentes.\nDigite qualquer tecla para continuar...");
                    Console.ReadKey();  
                    Console.Clear();    
                    continue;
                }

                double areaDoRetangulo = (comprimento * largura);

                Console.WriteLine($"A área do retângulo é: {areaDoRetangulo}");
                
                Console.WriteLine("Deseja Fazer Outra operação? (S/N");
                string resposta = Console.ReadLine();
                if (resposta != "s" && resposta !="S") ;
                    break;
            }
        }

        static string getInput(string mensagem)
        {
            Console.WriteLine(mensagem);
            string userInput = Console.ReadLine();
            return userInput;
        }
    }
}

namespace Exercicios_aula_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao programa para calculo do volume de retangulo!\n Digite qualquer tecla para continuar...");
            Console.ReadKey();

            double comprimento = ObterValor("informe o valor de comprimento em (m) para prosseguir");
            double altura = ObterValor("informe o valor de altura em (m) para prosseguir");
            double largura = ObterValor("informe o valor largura em (m) para prosseguir");

            double volume = CalcularVolume(comprimento, altura, largura);

            Console.WriteLine($"O volume do retângulo é de: {volume:F2} m³");

        }

        static double ObterValor(string mensagem)
        {
            Console.WriteLine(mensagem);
            double valor;

            while (!double.TryParse(Console.ReadLine(), out valor) || valor < 0)
            {
                Console.WriteLine("valor inválido.Por favor, insira um valor válido maior que zero.");
            }
            return valor;
        }

        static double CalcularVolume(double comprimento, double altura, double largura)
        {
            double volume= comprimento * altura * largura;
            return volume;
        }
    }
}

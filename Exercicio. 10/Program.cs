namespace Exercicio._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao programa de calculo para media ponderada de provas!\n Digite qualquer tecla para continuar...");
            Console.ReadKey();

            double peso01 = double.Parse(getInput("informe o peso da primeira nota para prosseguir"));
            double nota01 = double.Parse(getInput("informe a primeira nota para prosseguir"));
            double peso02 = double.Parse(getInput("informe o peso da segunda nota para prosseguir"));
            double nota02 = double.Parse(getInput("informe a segunda nota para prosseguir"));

            double mediaAluno = ((peso01 * nota01) + (peso02 * nota02)) / (peso01 + peso02);

            Console.WriteLine($"A media do aluno é de:{mediaAluno}");
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

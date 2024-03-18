namespace Exercicio._09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao programa de calculo para media de notas!\n Digite qualquer tecla para continuar...");
            Console.ReadKey();

            double nota01 = double.Parse(getInput("informe a primeira nota para prosseguir"));
            double nota02 = double.Parse(getInput("informe a segunda nota para prosseguir"));
            double nota03 = double.Parse(getInput("informe a terceira nota para prosseguir"));
            double nota04 = double.Parse(getInput("informe a quarta nota para prosseguir"));

            double mediaAluno = 4 / ((1 / nota01) + (1 / nota02) + (1 / nota03) + (1 / nota04));

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


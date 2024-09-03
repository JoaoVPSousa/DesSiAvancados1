public class Program
{

    public static void MostrarMensagem(string mensagem)
    {
        Console.WriteLine("Mensagem: " + mensagem);
    }
    public static int Somar(int a, int b)
    {
        return a + b;
    }
    public static void Main(string[] args)
    {
        Action<string> action = MostrarMensagem;
        action("Olá,eu sou Henrique!");
        Func<int, int, int> operacao = Somar;
        Console.WriteLine("Soma: " + operacao(5, 3));
        Action<int, int> exibirOperacoes = (a, b) =>
        {
            Console.WriteLine("Soma: " + (a + b));
            Console.WriteLine("Subtração: " + (a - b));
            Console.WriteLine("Multiplicação: " + (a * b));
            Console.WriteLine("Divisão: " + (a / b));
        };
        exibirOperacoes(5, 3);

        Func<int, int> calcularQuadrado = x => x * x;

        Func<int, int, int> executarOperacao = (a, b) =>
        {
            return calcularQuadrado(a) + calcularQuadrado(b);
        };

        Console.WriteLine("Quadrado de 5 é: " + calcularQuadrado(5));
        Console.WriteLine("Resultado da operação: " + executarOperacao(4, 6));
    }
}
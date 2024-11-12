public class Program
{
    /*
    - O Action<T1, T2>: Representa um método que aceita até 16 parâmetros e
    não retorna valor (void).

    - O Func<T, TResult>: Representa um método que aceita até 16 parâmetros e
    retorna um valor do tipo TResult.
    */
    public static void MostrarMensagem(string mensagem)
    {
        Console.WriteLine("Mensagem: " + mensagem);
    }

    public static int Somar(int a, int b)
    {
        return a + b;
    }

    public static int Multiplicar(int a, int b)
    {
        return a * b;
    }

    public static void Main()
    {
        // Usando Action para referenciar o método MostrarMensagem
        Action<string> action = MostrarMensagem;

        // Chamando o método através do delegate Action
        action("Olá, mundo!");

        Func<int, int, int> operacao;

        operacao = Somar;
        Console.WriteLine("Soma: " + operacao(5, 3));  // Saída: Soma: 8

        operacao = Multiplicar;
        Console.WriteLine("Multiplicação: " + operacao(5, 3));  // Saída: Multiplicação: 15

        // Usando Action com uma expressão lambda
        //(parametros) => expressão ou bloco de código
        /*
        Uma expressão lambda em C# é uma maneira concisa de representar um método anônimo,
        ou seja, um método que não tem um nome explícito.As lambdas permitem que você escreva
        funções inline sem a necessidade de definir um método separado. Elas são frequentemente
        usadas em conjunto com delegates, como Func<T,TResult> e Action<T>, para passar blocos de
        código como parâmetros.
        */
        
        Action<int, int> exibirOperacoes = (x, y) =>
        {
            Console.WriteLine("Soma: " + (x + y));
            Console.WriteLine("Multiplicação: " + (x * y));
        };

        // Usando Func com uma expressão lambda para calcular o quadrado de um número
        Func<int, int> calcularQuadrado = x => x * x;

        // Executando as operações
        exibirOperacoes(4, 2);  // Saída: Soma: 6, Multiplicação: 8

        Console.WriteLine("Quadrado de 5: " + calcularQuadrado(5));  // Saída: Quadrado de 5: 25

        // Criando uma função de ordem superior que aceita Func como parâmetro
        Func<int, int, int> executarOperacao = (x, y) =>
        {
            return calcularQuadrado(x) + calcularQuadrado(y);
        };

        Console.WriteLine("Resultado da operação: " + executarOperacao(3, 4));  // Saída: Resultado da operação: 25
        
        
    }
}
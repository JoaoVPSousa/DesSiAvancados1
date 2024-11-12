/*
Explicação:
Conversão Implícita (Implicit Casting):

Ocorre automaticamente quando não há perda de dados. Exemplo: de int para double.
Conversão Explícita (Explicit Casting):

Necessária quando pode haver perda de dados. Exemplo: de double para int.
Conversão Usando Métodos Convert:

Métodos da classe Convert são usados para converter entre diferentes tipos. Exemplo: de string para int.
Conversão Usando Parse:

O método Parse de um tipo converte uma string para aquele tipo específico. Exemplo: de string para double.
Conversão Usando TryParse:

Similar ao Parse, mas retorna true ou false indicando se a conversão foi bem-sucedida, evitando exceções.
Conversão de Tipos Compatíveis:

Exemplo de conversão de char para int, onde o valor ASCII do caractere é obtido.
*/

using System;

class Program
{
    static void Main()
    {
        // Conversão implícita (implicit casting)
        int numeroInt = 42;
        double numeroDouble = numeroInt;
        Console.WriteLine("Conversão implícita de int para double:");
        Console.WriteLine($"Int: {numeroInt}, Double: {numeroDouble}");
        Console.WriteLine();

        // Conversão explícita (explicit casting)
        double valorDouble = 9.78;
        int valorInt = (int)valorDouble;
        Console.WriteLine("Conversão explícita de double para int:");
        Console.WriteLine($"Double: {valorDouble}, Int: {valorInt}");
        Console.WriteLine();

        // Conversão usando métodos Convert
        string textoNumero = "123";
        int numeroConvertido = Convert.ToInt32(textoNumero);
        Console.WriteLine("Conversão usando Convert.ToInt32:");
        Console.WriteLine($"String: {textoNumero}, Int: {numeroConvertido}");
        Console.WriteLine();

        // Conversão usando Parse
        string textoDecimal = "12.34";
        double decimalConvertido = double.Parse(textoDecimal);
        Console.WriteLine("Conversão usando double.Parse:");
        Console.WriteLine($"String: {textoDecimal}, Double: {decimalConvertido}");
        Console.WriteLine();

        // Conversão usando TryParse
        string textoParaTentar = "99";
        bool sucesso = int.TryParse(textoParaTentar, out int resultado);
        Console.WriteLine("Conversão usando int.TryParse:");
        Console.WriteLine($"String: {textoParaTentar}, Sucesso: {sucesso}, Resultado: {resultado}");
        Console.WriteLine();

        // Conversão de tipos compatíveis (exemplo: char para int)
        char caractere = 'A';
        int codigoAscii = (int)caractere;
        Console.WriteLine("Conversão de char para int (código ASCII):");
        Console.WriteLine($"Char: {caractere}, Código ASCII: {codigoAscii}");
        Console.WriteLine();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        //Conversão implicita
        int numInt = 45;
        double numDouble = numInt;
        Console.WriteLine("Conversão implicita de int para double: ");
        Console.WriteLine($"Inteiro: {numInt}, Double: {numDouble}");

        //Conversão usando o Convert
        double valorDouble = 7.45;
        int valorConvertidoInt = Convert.ToInt32(valorDouble);
        string textoValor = "123";
        int textoConvertidoInt = Convert.ToInt32(textoValor);
        Console.WriteLine($"Double: {valor}, Inteiro{valorConvertidoInt}");
        Console.WriteLine($"String: {textoValor}, Inteiro{textoConvertidoInt}");

    }
}
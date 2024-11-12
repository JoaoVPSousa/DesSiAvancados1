using System;

public class Program
{
    // Definindo um delegate que pode apontar para métodos que recebem um int e retornam void
    public delegate void MostrarMensagem(int numero);

    public static void ExibirNumero(int numero)
    {
        Console.WriteLine("O número é: " + numero);
    }

    public static void ExibirQuadrado(int numero)
    {
        Console.WriteLine("O quadrado do número é: " + (numero * numero));
    }
    
    public static void ExibirCubo(int numero)
    {
        Console.WriteLine("O cubo do número é: " + (numero * numero * numero));
    }


    public static void Main()
    {
        // Instanciando o delegate e apontando para o método ExibirNumero
        MostrarMensagem meuDelegate = ExibirNumero;

        
        meuDelegate += ExibirQuadrado;
        
        // Adicionando um método anônimo
        
        meuDelegate += delegate (int numero) 
        {
            Console.WriteLine("O dobro do número é: " + (numero * 2));
        };
        
        meuDelegate += ExibirCubo;
        

        // Chamar o delegate resultará na execução de todos os métodos atribuídos
        meuDelegate(10);
        
        meuDelegate -= ExibirCubo; // Remover métodos 
        meuDelegate(10);

    }
}

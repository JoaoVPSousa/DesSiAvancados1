using System;
using System.Collections.Generic;		
// Program.cs
class Program
{
    static void Main(string[] args)
    {       
        // Coletando dados do professor
        Console.WriteLine("Digite os dados da Pessoa:");
        Console.Write("Nome: ");
        string nomePessoa = Console.ReadLine();
        
        Console.Write("Idade: ");
        int idadePessoa = int.Parse(Console.ReadLine());
        
        Pessoa pessoa1 = new Pessoa(nomePessoa, idadePessoa);

        // Exibindo os dados coletados
        Console.WriteLine("\nDados da Pessoa:");
        Console.WriteLine(pessoa1.ToString());
    }
}

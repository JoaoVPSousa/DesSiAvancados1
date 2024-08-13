using System;
using Models;

public class Program{
    public static void Main(){
        Console.WriteLine("Cadastro de Pessoa");
        Console.Write("Nome: ");
        string nomePessoa = Console.ReadLine();
        Console.Write("Idade: ");
        int idadePessoa = int.Parse(Console.ReadLine());
        Pessoa pessoaObj = new Pessoa(nomePessoa, idadePessoa);
        Console.WriteLine(pessoaObj);
    }
}

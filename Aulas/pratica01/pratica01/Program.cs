using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        // Criando clientes
        Cliente cliente1 = new Cliente("João", 25);
        Cliente cliente2 = new Cliente("Maria", 30);

        // Criando livros
        Livro livro1 = new Livro("C# Para Iniciantes", 45.00M);
        Livro livro2 = new Livro("Aprendendo Python", 60.00M);
        Livro livro3 = new Livro("Java: Como Programar", 120.00M);
        Livro livro4 = new Livro("Algoritmos Avançados", 90.00M);

        // Criando venda para o cliente 1
        Venda venda1 = new Venda(cliente1);
        venda1.AdicionarLivro(livro1);
        venda1.AdicionarLivro(livro2);
        venda1.AdicionarLivro(livro4);

        // Criando venda para o cliente 2
        Venda venda2 = new Venda(cliente2);
        venda2.AdicionarLivro(livro3);
        venda2.AdicionarLivro(livro4);

        // Exibindo as vendas
        Console.WriteLine(venda1);
        Console.WriteLine(venda2);

        // Listando livros mais caros que um valor específico
        Console.WriteLine("\nListando livros mais caros que R$50,00 na venda 1:");
        venda1.ListarLivrosMaisCaros(50.00M);
        
        // Ordenando a lista de livros da venda 1 por nome
        Console.WriteLine("\nLivros em ordem alfabética na venda 1:");
        venda1.ListarLivrosEmOrdemAlfabetica();
    }
}

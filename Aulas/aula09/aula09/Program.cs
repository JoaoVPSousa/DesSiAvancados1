using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Criando clientes
        Cliente cliente1 = new Cliente(1, "João");
        Cliente cliente2 = new Cliente(2, "Maria");

        // Criando produtos
        Produto produto1 = new Produto(1, "Notebook", 3500.00M);
        Produto produto2 = new Produto(2, "Smartphone", 1800.00M);
        Produto produto3 = new Produto(3, "Tablet", 1200.00M);
        Produto produto4 = new Produto(4, "Fone de Ouvido", 150.00M);

        // Criando compra para o cliente 1
        Compra compra1 = new Compra(cliente1);
        compra1.AdicionarProduto(produto1);
        compra1.AdicionarProduto(produto2);
        compra1.AdicionarProduto(produto4);

        // Criando compra para o cliente 2
        Compra compra2 = new Compra(cliente2);
        compra2.AdicionarProduto(produto3);
        compra2.AdicionarProduto(produto4);

        // Exibindo as compras
        Console.WriteLine(compra1);
        Console.WriteLine(compra2);

        // Listando produtos mais caros que um valor específico
        Console.WriteLine("\nListando produtos mais caros que R$2000,00 na compra 1:");
        compra1.ListarProdutosMaisCaros(2000.00M);
    }
}

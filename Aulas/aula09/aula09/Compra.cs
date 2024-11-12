using System;
using System.Collections.Generic;
using System.Linq;

public class Compra
{
    public Cliente Cliente { get; set; }
    public List<Produto> Produtos { get; set; }

    public Compra(Cliente cliente)
    {
        Cliente = cliente;
        Produtos = new List<Produto>();
    }

    public void AdicionarProduto(Produto produto)
    {
        Produtos.Add(produto);
    }

    public decimal CalcularTotal()
    {
        return Produtos.Sum(p => p.Preco);
    }

    public override string ToString()
    {
        string produtosStr = string.Join(", ", Produtos.Select(p => p.Nome));
        return $"Compra de {Cliente.Nome}, Produtos: [{produtosStr}], Total: {CalcularTotal():C}";
    }

    public void ListarProdutosMaisCaros(decimal precoMinimo)
    {
        var produtosCaros = Produtos.Where(p => p.Preco > precoMinimo)
                                    .OrderBy(p => p.Nome)
                                    .ToList();

        if (produtosCaros.Count > 0)
        {
            Console.WriteLine($"Produtos com preço maior que {precoMinimo:C}:");
            produtosCaros.ForEach(p => Console.WriteLine(p));
        }
        else
        {
            Console.WriteLine($"Nenhum produto com preço maior que {precoMinimo:C}.");
        }
    }
}

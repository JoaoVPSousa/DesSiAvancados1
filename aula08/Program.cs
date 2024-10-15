using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main()
    {
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Utilizando o método Where para filtrar os números pares
        List<int> numerosPares = numeros.Where(x => x % 2 == 0).ToList();

        Console.WriteLine("Números pares:");
        numerosPares.ForEach(x => Console.WriteLine(x));
        Console.WriteLine("Números: ");
        numeros.ForEach(y=> Console.WriteLine(y));

        List<string> frutas = new List<string> { "Maçã", "Banana", "Manga", "Abacaxi", "Melancia", "Morango" };
        List<string> frutasOrdenadas = frutas.OrderBy(x => x).ToList();

        List<string> frutasComM = frutasOrdenadas.Where(x => x.StartsWith("M")).ToList();

        frutasComM.ForEach(x => Console.WriteLine("Frutas que começam com a letra 'M': " + x));

        List<Pessoa> pessoas = new List<Pessoa>
        {
            new Pessoa("Henrique", 25),
            new Pessoa("Maria", 30),
            new Pessoa("João", 20),
            new Pessoa("Ana", 35),
            new Pessoa("José", 40)
        };

        List<Pessoa> pessoasFiltradas = pessoas.Where(x => x.Idade > 25).OrderBy(x => x.Idade).ToList();

        pessoasFiltradas.ForEach(x => Console.WriteLine("Mais que 25: "+x.ToString()));

        List<Pessoa> pessoasFiltradas2 = pessoas.Where(x => x.Nome.StartsWith("H")).OrderBy(x => x.Nome).ToList();

        pessoasFiltradas2.ForEach(x => Console.WriteLine("Começam com H: "+x.ToString()));

        List<Pessoa> pessoasFiltradas3 = pessoas.Where(x => x.Idade < 50).OrderBy(x => x.Idade).ToList();
        pessoasFiltradas3.ForEach(x => Console.WriteLine("Menos que 50: "+x.ToString()));
    }
}
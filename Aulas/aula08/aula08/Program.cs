using System;
using System.Collections.Generic;
using System.Linq;

/*
O método Where é um método de extensão da LINQ (Language Integrated Query)
em C# que permite filtrar elementos de uma coleção com base em uma condição
definida por uma expressão lambda. Ele retorna uma nova coleção contendo apenas
os elementos que atendem à condição especificada.
*/

public class Program
{
    public static void Main()
    {
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Usando uma expressão lambda para filtrar números pares
        List<int> numerosPares = numeros.Where(n => n % 2 == 0).ToList();

        Console.WriteLine("Números pares:");
        numerosPares.ForEach(n => Console.WriteLine(n));

        
        //Segunda prática
        
        //Where(p => p.Idade > 25): Filtra as pessoas com mais de 25 anos.
        //OrderBy(p => p.Nome): Ordena a lista de pessoas filtradas pelo nome.
        //ForEach(p => Console.WriteLine($"Nome: {p.Nome}, Idade: {p.Idade}")): 
        //Imprime os nomes e idades das pessoas filtradas.
        
        List<string> frutas = new List<string> { "Maçã", "Banana", "Manga", "Abacaxi", "Melancia", "Morango" };

        // Ordenando a lista de frutas por ordem alfabética
        List<string> frutasOrdenadas = frutas.OrderBy(f => f).ToList();

        // Filtrando as frutas que começam com a letra 'M'
        List<string> frutasComM = frutasOrdenadas.Where(f => f.StartsWith("M")).ToList();

        Console.WriteLine("Frutas ordenadas que começam com 'M':");
        frutasComM.ForEach(f => Console.WriteLine(f));
        
        
        //Terceira Prática
        List<Pessoa> pessoas = new List<Pessoa>
        {
            new Pessoa ("Cecília",1),
            new Pessoa ("Rafael",33),
            new Pessoa ("Maria", 22),
            new Pessoa ("Daniel", 55),
            new Pessoa ("Roberta", 28),
        };

        // Filtrando pessoas com idade maior que 25 e ordenando pelo nome
        List<Pessoa> pessoasFiltradas = pessoas
            .Where(p => p.Idade > 25)
            .OrderBy(p => p.Nome)
            .ToList();

        Console.WriteLine("Pessoas com idade maior que 25, ordenadas por nome:");
        pessoasFiltradas.ForEach(p => Console.WriteLine($"Nome: {p.Nome}, Idade: {p.Idade}"));

        
    }
}

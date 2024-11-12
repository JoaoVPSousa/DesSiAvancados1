using System;
using System.Linq;
using aula11_EF.Models; // Importando o namespace onde estão as classes

//dotnet new console -n aula11_EF

//dotnet add package Microsoft.EntityFrameworkCore
//dotnet add package Microsoft.EntityFrameworkCore.Design
//dotnet add package Microsoft.EntityFrameworkCore.Sqlite

//dotnet build
//dotnet run


public class Program
{
    public static void Main()
    {
        //Crianda uma instância do contexto do banco de dados, chamada db.
        //O bloco using garante que o contexto será corretamente liberado após o uso.
        using (var db = new AppDbContext())
        {
            //Esse método verifica se o banco de dados (arquivo SQLite vendas.db) já existe.
            //Se não existir, ele é criado.
            db.Database.EnsureCreated();

            // Criando clientes
            Cliente cliente1 = new Cliente("João", 25);
            Cliente cliente2 = new Cliente("Maria", 30);
            db.Clientes.Add(cliente1);
            db.Clientes.Add(cliente2);
            db.SaveChanges();

            // Criando livros
            Livro livro1 = new Livro("C# Para Iniciantes", 45.00M);
            Livro livro2 = new Livro("Aprendendo Python", 60.00M);
            Livro livro3 = new Livro("Java: Como Programar", 120.00M);
            Livro livro4 = new Livro("Algoritmos Avançados", 90.00M);
            db.Livros.AddRange(livro1, livro2, livro3, livro4);
            db.SaveChanges();

            // Criando venda para o cliente 1
            Venda venda1 = new Venda(cliente1);
            venda1.AdicionarLivro(livro1);
            venda1.AdicionarLivro(livro2);
            venda1.AdicionarLivro(livro4);
            db.Vendas.Add(venda1);
            db.SaveChanges();

            // Criando venda para o cliente 2
            Venda venda2 = new Venda(cliente2);
            venda2.AdicionarLivro(livro3);
            venda2.AdicionarLivro(livro4);
            db.Vendas.Add(venda2);
            db.SaveChanges();

            // Exibindo as vendas
            Console.WriteLine(venda1);
            Console.WriteLine(venda2);
        }
    }
}

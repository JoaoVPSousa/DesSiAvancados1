using Microsoft.EntityFrameworkCore;
using aula11_EF.Models; // Importando o namespace onde estão as classes

//Essa classe gerencia a conexão com o banco e o mapeamento de objetos para o banco de dados (ORM).
public class AppDbContext : DbContext{
    
    //Essa classe gerencia a conexão com o banco e o mapeamento de objetos para o banco de dados (ORM).
    //DbSet é a coleção de entidades mapeadas para uma tabela do banco de dados.
    //Por exemplo, Clientes mapeia para uma tabela de clientes.
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Livro> Livros { get; set; }
    public DbSet<Venda> Vendas { get; set; }

    //Configura o banco de dados.
    //Aqui, o código define que o SQLite será usado como banco de dados,
    //e o arquivo será chamado vendas.db.
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //Especifica o uso do SQLite e o nome do arquivo do banco de dados.
        optionsBuilder.UseSqlite("Data Source=vendas.db");
    }

    //Customiza a configuração do modelo.
    //Definido o relacionamento muitos para muitos entre Venda e Livro,
    //ou seja, uma venda pode ter muitos livros e um livro pode estar em várias vendas.
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Venda>()
            .HasMany(v => v.Livros)
            .WithMany()
            .UsingEntity(j => j.ToTable("VendaLivros"));//Cria uma tabela associativa chamada VendaLivros
                                                        //para armazenar o relacionamento entre vendas e livros.

        base.OnModelCreating(modelBuilder);
    }
}

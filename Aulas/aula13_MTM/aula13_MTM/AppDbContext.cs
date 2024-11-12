using Microsoft.EntityFrameworkCore;

namespace aula13_MTM
{
    public class AppDbContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; } = null!;
        public DbSet<Habilidade> Habilidades { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=relacionamento.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>()
                .HasMany(p => p.Habilidades)
                .WithMany(h => h.Pessoas)
                .UsingEntity(j => j.ToTable("PessoaHabilidades")); // Tabela de junção N:N
        }
    }
}

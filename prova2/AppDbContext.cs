using Microsoft.EntityFrameworkCore;

namespace prova2
{
    public class AppDbContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; } = null!;
        public DbSet<Disciplina> Disciplinas { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=relacionamento.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>()
                .HasMany(p => p.Disciplinas)
                .WithMany(h => h.Alunos)
                .UsingEntity(j => j.ToTable("AlunoDisciplinas"));
        }
    }
}

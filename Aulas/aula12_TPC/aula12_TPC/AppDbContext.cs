using Microsoft.EntityFrameworkCore;

namespace aula12_TPC{

    public class AppDbContext : DbContext{
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlite("Data Source=pessoas.db");
        }
        
        

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Aluno>().ToTable("AlunosTPC");
            modelBuilder.Entity<Professor>().ToTable("ProfessoresTPC");
        }
    }
}
using Microsoft.EntityFrameworkCore;

namespace aula08_Virtual{
    public class PessoaContext : DbContext{
        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlite("Data Source=pessoas.db");
        }
    }
}
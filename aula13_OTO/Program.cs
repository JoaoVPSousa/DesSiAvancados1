using Microsoft.EntityFrameworkCore;
namespace aula13_OTO{
    class Program{
        static void Main(string[] args){
            using (var context = new AppDbContext()){
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                var pessoa = new Pessoa { Nome = "João" };
                var endereco = new Endereco { Rua = "Rua A", Pessoa = pessoa };
                context.Pessoas.Add(pessoa);
                context.Enderecos.Add(endereco);
                context.SaveChanges();
                var pessoaComEndereco = context.Pessoas.Include(p => p.Endereco).FirstOrDefault();
                Console.WriteLine ($"Nome: {pessoaComEndereco.Nome}, Rua: {pessoaComEndereco.Endereco.Rua}");
            }
        }
    }
}
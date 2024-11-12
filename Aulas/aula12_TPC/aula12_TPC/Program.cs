using System.Linq;

namespace aula12_TPC{
    public class Program{
        public static void Main(string[] args){
            using(var context = new AppDbContext()){
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                // Adiciona dados de exmplo
                context.Alunos.Add(new Aluno {Nome = "João", Matricula = "A001"});
                context.Professores.Add(new Professor {Nome = "Maria", Disciplina = "IoT"});
                context.SaveChanges();

                // Consulta e exibe os dados do banco
                var alunos = context.Alunos.ToList();
                foreach(var aluno in alunos){
                    Console.WriteLine($"Id: {aluno.Id}, Nome: {aluno.Nome}");
                }

                // Consulta e exibe os dados do banco
                var professores = context.Professores.ToList();
                foreach(var professor in professores){
                    Console.WriteLine($"Id: {professor.Id}, Nome: {professor.Nome}");
                }
            }
        }
    }
}
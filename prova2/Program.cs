using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace prova2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                var objAluno1 = new Aluno();
                objAluno1.Nome = "Henrique Oliveira Melo";
                objAluno1.Matricula = "55279899";
                objAluno1.Idade = 30;

                var objAluno2 = new Aluno();
                objAluno2.Nome = "João Vitor Pereira Sousa";
                objAluno2.Matricula = "55279892";
                objAluno2.Idade = 25;

                var objDisciplina1 = new Disciplina();
                objDisciplina1.NomeDisciplina = "Desenvolvimento de Sistemas de Informação Avançados I";
                objDisciplina1.CodigoDisciplina = 1;

                var objDisciplina2 = new Disciplina();
                objDisciplina2.NomeDisciplina = "Projeto Integrador VI";
                objDisciplina2.CodigoDisciplina = 2;

                objAluno1.Disciplinas.Add(objDisciplina1);
                objAluno1.Disciplinas.Add(objDisciplina2);

                objAluno2.Disciplinas.Add(objDisciplina1);
                objAluno2.Disciplinas.Add(objDisciplina2);

                context.Alunos.AddRange(objAluno1, objAluno2);
                context.Disciplinas.AddRange(objDisciplina1, objDisciplina2);
                context.SaveChanges();

                var alunos = context.Alunos.Include(p => p.Disciplinas).ToList();
                foreach (var aluno in alunos)
                {
                    Console.WriteLine($"Nome: {aluno.Nome}, Matricula: {aluno.Matricula}, Idade: {aluno.Idade}");
                    foreach (var disciplina in aluno.Disciplinas)
                    {
                        Console.WriteLine($"Nome Disciplina: {disciplina.NomeDisciplina}, Codigo Disciplina: {disciplina.CodigoDisciplina}");
                    }
                }
            }
        }
    }
}

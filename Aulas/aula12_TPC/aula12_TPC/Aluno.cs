using Microsoft.EntityFrameworkCore;

namespace aula12_TPC{
    public class Aluno : Pessoa{
        public string Matricula { get; set; } = string.Empty;
    }
}
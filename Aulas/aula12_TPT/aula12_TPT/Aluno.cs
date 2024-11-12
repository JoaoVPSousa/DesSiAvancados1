using Microsoft.EntityFrameworkCore;

namespace aula12_TPT{
    public class Aluno : Pessoa{
        public string Matricula { get; set; } = string.Empty;
    }
}
using Microsoft.EntityFrameworkCore;

namespace aula12_TPH{
    public class Aluno : Pessoa{
        public string Matricula { get; set; } = string.Empty;
    }
}
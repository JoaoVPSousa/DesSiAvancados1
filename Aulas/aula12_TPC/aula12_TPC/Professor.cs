using Microsoft.EntityFrameworkCore;

namespace aula12_TPC{
    public class Professor : Pessoa{
        public string Disciplina { get; set; } = string.Empty;
    }
}
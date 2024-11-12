using Microsoft.EntityFrameworkCore;

namespace aula12_TPH{
    public class Professor : Pessoa{
        public string Disciplina { get; set; } = string.Empty;
    }
}
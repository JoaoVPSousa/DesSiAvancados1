using Microsoft.EntityFrameworkCore;

namespace aula12_TPT{
    public class Professor : Pessoa{
        public string Disciplina { get; set; } = string.Empty;
    }
}
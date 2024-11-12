// Aluno.cs
public class Aluno : Pessoa
{
    private string curso = string.Empty;

    public string Curso
    {
        get { return curso; }
        set { curso = value; }
    }

    public Aluno(string nome, int idade, string curso)
        : base(nome, idade)
    {
        Curso = curso;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Curso: {Curso}";
    }
}

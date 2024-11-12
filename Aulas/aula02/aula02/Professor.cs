// Professor.cs
public class Professor : Pessoa
{
    private string disciplina = string.Empty;

    public string Disciplina
    {
        get { return disciplina; }
        set { disciplina = value; }
    }

    public Professor(string nome, int idade, string disciplina)
        : base(nome, idade)
    {
        Disciplina = disciplina;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Disciplina: {Disciplina}";
    }
}
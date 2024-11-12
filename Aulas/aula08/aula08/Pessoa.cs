// Pessoa.cs
public class Pessoa
{
    private string nome = string.Empty;
    //private string nome = "";
    private int idade;

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public int Idade
    {
        get { return idade; }
        set { idade = value; }
    }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public override string ToString()
    {
        return $"Nome: {Nome}, Idade: {Idade}";
    }
}

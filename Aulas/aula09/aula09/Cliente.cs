// Pessoa.cs
public class Cliente
{
    private string nome = string.Empty;
    //private string nome = "";
    private int id;

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public Cliente(int id, string nome)
    {
        Id = id;
        Nome = nome;
    }

    public override string ToString()
    {
        return $"Id: {Id}, Nome: {Nome}";
    }
}

public class Pessoa
{
    private string nome = string.Empty;
    private decimal nota = 0;

    public Pessoa(string nome, decimal nota)
    {
        Nome = nome;
        Nota = nota;
    }
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }
    public decimal Nota
    {
        get { return nota; }
        set { nota = value; }
    }
}
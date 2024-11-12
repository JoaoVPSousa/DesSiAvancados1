
public class Livro
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }

    public Livro(string nome, decimal preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public override string ToString()
    {
        return $"Nome: {Nome}, Preço: {Preco:C}";
    }
}

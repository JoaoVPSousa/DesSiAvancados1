// Classe genérica Caixa
public class Caixa<T>
{
    private T conteudo;

    public Caixa(T conteudoInicial)
    {
        conteudo = conteudoInicial;
    }

    public T Conteudo
    {
        get { return conteudo; }
        set { conteudo = value; }
    }

    public void MostrarConteudo()
    {
        Console.WriteLine($"Conteúdo: {conteudo}");
    }
}

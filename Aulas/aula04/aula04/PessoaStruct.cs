public struct PessoaStruct
{
    private string nome = string.Empty;
    //private string nome = "";
    
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public PessoaStruct(string nome)
    {
        Nome = nome;
    }

    public override string ToString()
    {
        return $"Nome: {Nome}";
    }
}

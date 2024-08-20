class Program
{
    public static void Main(string[] args)
    {
        Pessoa objPessoa = new Pessoa("Henrique");
        Console.WriteLine("Antes do método (Classe): " + objPessoa.ToString());
        AlteraNomeClasse(objPessoa);
        Console.WriteLine("Depois do método (Classe): " + objPessoa.ToString());

        PessoaStruct objPessoaStruct = new PessoaStruct("HenriqueStruct");
        Console.WriteLine("Antes do método (Struct): " + objPessoaStruct.ToString());
        AlteraNomeStruct(objPessoaStruct);
        Console.WriteLine("Depois do método (Struct): " + objPessoaStruct.ToString());
    }
    public static void AlteraNomeClasse(Pessoa objAux)
    {

        objAux.Nome = "Henrique Dois";
    }
    public static void AlteraNomeStruct(PessoaStruct objAux)
    {
        objAux.NomeStruct = "Henrique Dois";
    }
}
class Program
{
    static void Main()
    {
        Pessoa pessoa = new Pessoa { Nome = "João" };
        Console.WriteLine("Antes do método (Classe): " + pessoa.Nome);

        AlterarNomeClasse(pessoa);

        Console.WriteLine("Depois do método (Classe): " + pessoa.Nome);

        
        PessoaStruct pessoaStruct = new PessoaStruct { Nome = "João" };
        Console.WriteLine("Antes do método (Struct): " + pessoaStruct.Nome);

        AlterarNomeStruct(pessoaStruct);

        Console.WriteLine("Depois do método (Struct): " + pessoaStruct.Nome);
        
    }

    static void AlterarNomeClasse(Pessoa p)
    {
        p.Nome = "Maria"; // A alteração reflete no objeto original
    }   

    static void AlterarNomeStruct(PessoaStruct p)
    {
        p.Nome = "Maria"; // A alteração não afeta o objeto original
    }
}
public class Program
{
    public delegate void VerificarAprovação(decimal nota);

    public static void Main()
    {
        var VerificarAprovação = delegate (decimal nota)
          {
              switch (nota)
              {
                  case >= 60:
                      Console.WriteLine("Aprovado");
                      break;
                  case < 60:
                      Console.WriteLine("Reprovado");
                      break;
              }
          };
        List<Pessoa> pessoas = new List<Pessoa>();
        pessoas.Add(new Pessoa("João", 70));
        pessoas.Add(new Pessoa("Maria", 50));
        foreach (var pessoa in pessoas)
        {
            Console.WriteLine(pessoa.Nome);
            VerificarAprovação(pessoa.Nota);
        }
    }
}
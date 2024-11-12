using aula08_Virtual;

class Program{
    public static void Main(string[] args){

        using(var context = new PessoaContext()){

            //Criar o banco de dados se ele não existir
            context.Database.EnsureCreated();

            var pessoa = new Pessoa{
                Nome = "Rafael",
                Idade = 33
            };

            context.Pessoas.Add(pessoa);
            context.SaveChanges();

            var listaPessoas = context.Pessoas.ToList();
            foreach(var p in listaPessoas){
                Console.WriteLine(p.ToString());
            }
        }
    }
}
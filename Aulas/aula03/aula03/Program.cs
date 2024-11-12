// Program.cs
class Program
{
    static void Main(string[] args)
    {
        Caixa<int> caixaInt = new Caixa<int>(10);
        caixaInt.MostrarConteudo(); // Saída: Conteúdo: 10

        // Criando uma instância de Caixa para armazenar uma string
        Caixa<string> caixaString = new Caixa<string>("Olá, Mundo!");
        caixaString.MostrarConteudo(); // Saída: Conteúdo: Olá, Mundo!
        
        Pessoa pessoa1 = new Pessoa("Rafael Marinho", 33);

        // Criando uma instância de Caixa para armazenar um objeto do tipo Pessoa
        Caixa<Pessoa> caixaPessoa = new Caixa<Pessoa>(pessoa1);
        caixaPessoa.MostrarConteudo();
    }
}

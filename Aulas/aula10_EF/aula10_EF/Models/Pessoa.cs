namespace aula08_Virtual{
    public class Pessoa{

        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(){
            Nome = "";
            Idade = 0;
        }
        
        public Pessoa(string nome, int idade){
            Nome = nome;
            Idade = idade;
        }

        public override string ToString(){
            return $"Id: {Id}, Nome: {Nome}, Idade {Idade}.";
        }
    }
}
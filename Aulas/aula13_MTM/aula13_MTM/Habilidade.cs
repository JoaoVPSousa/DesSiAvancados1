namespace aula13_MTM
{
    public class Habilidade
    {
        public int HabilidadeId { get; set; }
        public string Nome { get; set; } = string.Empty;

        public List<Pessoa> Pessoas { get; set; } = new List<Pessoa>(); // Relacionamento N:N
    }
}

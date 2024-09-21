namespace Atividade_de_Reposição.Models
{
    public class Jogo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Genero { get; set; }
        public int DesenvolvedorId { get; set; }
        public Desenvolvedor Desenvolvedor { get; set; }
    }


}

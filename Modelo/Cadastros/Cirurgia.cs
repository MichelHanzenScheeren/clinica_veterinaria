
namespace Modelo.Cadastros
{
    public class Cirurgia
    {
        public long CirurgiaID { get; set; }
        public string Nome { get; set; }
        public string Classificacao { get; set; } //emergência, preventiva, castração...
        public double Preco { get; set; }

        public Cirurgia()
        {

        }

        public Cirurgia(string nome, string classificacao, double preco)
        {
            Nome = nome;
            Classificacao = classificacao;
            Preco = preco;
        }

        public override string ToString()
        {
            return CirurgiaID + " - " + Nome + ". " + Classificacao + " .  R$ " + Preco;
        }
    }
}

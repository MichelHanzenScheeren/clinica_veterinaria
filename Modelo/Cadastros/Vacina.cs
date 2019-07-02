
namespace Modelo.Cadastros
{
    public class Vacina
    {
        public long VacinaID { get; set; }
        public string Nome { get; set; }
        public string Informacoes { get; set; }
        public double Preco { get; set; }

        public Vacina()
        {

        }

        public Vacina(string nome, string informacoes, double preco)
        {
            Nome = nome;
            Informacoes = informacoes;
            Preco = preco;
        }

        public override string ToString()
        {
            return VacinaID + " - " + Nome + ". " + Informacoes + ".  R$ " + Preco;
        }
    }
}

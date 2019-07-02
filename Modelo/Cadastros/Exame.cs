
namespace Modelo.Cadastros
{
    public class Exame
    {
        public long ExameID { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public double Preco { get; set; }

        public Exame()
        {

        }
        public Exame(string nome, string tipo, double preco)
        {
            Nome = nome;
            Tipo = tipo;
            Preco = preco;
        }

        public override string ToString()
        {
            return ExameID + " - " + Nome + ", " + Tipo + ".  R$ " + Preco;
        }
    }
}

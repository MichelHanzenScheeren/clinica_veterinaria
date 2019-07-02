
namespace Modelo.Cadastros
{
    public class Medicamento
    {
        public long MedicamentoID { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; } // Comprimido, Liquido, aerosol...
        public string Classificacao { get; set; } //antibiotico, higiene, vitaminico, anti Inflamatório, 

        public Medicamento()
        {

        }

        public Medicamento(string nome, string tipo, string classificacao)
        {
            Nome = nome;
            Tipo = tipo;
            Classificacao = classificacao;
        }

        public override string ToString()
        {
            return MedicamentoID + " - " + Nome + ", " + Tipo + ", " + Classificacao;
        }
    }
}

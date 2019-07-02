
namespace Modelo
{
    public class Endereco
    {
        public long EnderecoID { get; set; }
        public string Cep { get; set; }
        public string Rua { get; set; }
        public string NumeroCasa { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public Endereco(string cep, string rua, string numeroCasa, string bairro, string cidade, string estado)
        {
            Cep = cep;
            Rua = rua;
            NumeroCasa = numeroCasa;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }
    }
}

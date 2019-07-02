using System;

namespace Modelo.Servicos
{
    public class Internamento
    {
        public long InternamentoID { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime? DataSaida { get; set; }
        public string Resumo { get; set; }
        public string Conclusoes { get; set; }

        public int NumeroQuarto { get; set; }

        public long AnimalID { get; set; }
        public virtual Animal Animal { get; set; }
        public long? ContaID { get; set; }
        public virtual Conta Conta { get; set; }

        public Internamento()  {  }

        public Internamento(DateTime dataEntrada, string resumo, int numeroQuarto, long animalID)
        {
            DataEntrada = dataEntrada;
            Resumo = resumo;
            NumeroQuarto = numeroQuarto;
            AnimalID = animalID;
        }
    }
}

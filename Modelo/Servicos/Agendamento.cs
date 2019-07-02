using System;

namespace Modelo.Servicos
{
    public class Agendamento
    {
        public long AgendamentoID { get; set; }
        public DateTime DataAtendimento { get; set; }
        public DateTime DataAgendamento { get; set; }
        public string Tipo { get; set; }
        public string Status { get; set; }
        public string Resumo { get; set; }

        public long AnimalID { get; set; }
        public virtual Animal Animal { get; set; }

        public Agendamento(){}

        public Agendamento(DateTime data, string tipo, string status, string resumo, long animalID)
        {
            DataAtendimento = data;
            Tipo = tipo;
            Status = status;
            AnimalID = animalID;
            Resumo = resumo;
            DataAgendamento = DateTime.Now;
        }
    }
}

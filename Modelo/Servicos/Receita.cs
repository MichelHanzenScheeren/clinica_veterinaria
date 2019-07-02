using Modelo.Cadastros;
using System;

namespace Modelo.Servicos
{
    public class Receita
    {
        public long ReceitaID { get; set; }
        public string Dose { get; set; }
        public int IntervaloDose { get; set; }
        public int TempoTratamento { get; set; }
        public DateTime Data { get; set; }

        public long MedicamentoID { get; set; }
        public virtual Medicamento Medicamento { get; set; }

        public long AnimalID { get; set; }
        public virtual Animal Animal { get; set; }

        public long VeterinarioID { get; set; }
        public virtual Veterinario Veterinario { get; set; }

        public Receita()
        {

        }

        public Receita(string dose, int intervaloDose, int tempoTratamento, long medicamentoID, long animalID, long veterinarioID)
        {
            Dose = dose;
            IntervaloDose = intervaloDose;
            TempoTratamento = tempoTratamento;
            MedicamentoID = medicamentoID;
            AnimalID = animalID;
            VeterinarioID = veterinarioID;

            Data = DateTime.Now;
        }
    }
}

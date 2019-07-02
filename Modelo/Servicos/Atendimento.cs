using Modelo.Cadastros;
using Modelo.Servicos;
using System;

namespace Modelo
{
    public class Atendimento
    {
        public long AtendimentoID { get; set; }
        public DateTime Data { get; set; }
        public string Tipo { get; set; }
        public string Resumo { get; set; }
        public string ClassificacaoAtendimento { get; set; }
        public string Conclusoes { get; set; }

        public long VeterinarioID { get; set; }
        public virtual Veterinario Veterinario { get; set; }

        public long AnimalID { get; set; }
        public virtual Animal Animal { get; set; }

        public long ContaID { get; set; }
        public virtual Conta Conta { get; set; }

        public Atendimento()
        {

        }

        public Atendimento(DateTime data, string tipo, string resumo, string classificacaoAtendimento, string conclusoes, long veterinarioID, long animalID, long contaID)
        {
            Data = data;
            Tipo = tipo;
            Resumo = resumo;
            ClassificacaoAtendimento = classificacaoAtendimento;
            Conclusoes = conclusoes;
            VeterinarioID = veterinarioID;
            AnimalID = animalID;
            ContaID = contaID;
        }
    }
}

using System;
using System.Collections.Generic;

namespace Modelo.Servicos
{
    public class Conta // Entrada ou saída de dinheiro para a clínica. É gerada em atendimentos ou internamentos, ou manualmente na aba "Finanças"
    {
        public long ContaID { get; set; }
        public string Tipo { get; set; }
        public string Categoria { get; set; }
        public DateTime Data_Inicio { get; set; }
        public DateTime Data_Vencimento { get; set; }
        public double Total { get; set; }
        public double ValorPago { get; set; }
        public int Parcelas { get; set; }
        public string MetodoPagamento { get; set; }

        public long CadastroID { get; set; }
        public virtual Cadastro Cadastro { get; set; }

        public virtual List<Caixa> Caixas { get; set; }

        public Conta() {  }

        public Conta(string tipo, string categoria, DateTime data_Vencimento, double total, string metodoPagamento,int parcelas, long cadastroID)
        {
            Tipo = tipo;
            Categoria = categoria;
            Data_Vencimento = data_Vencimento;
            Total = total;
            MetodoPagamento = metodoPagamento;
            CadastroID = cadastroID;
            Parcelas = parcelas;
            Data_Inicio = DateTime.Now;
        }

        public override string ToString()
        {
            return ContaID + " - " + Tipo+ ", " + Categoria + ". Total: R$ " + Total + ". Pago: R$ " + ValorPago;
        }
    }
}

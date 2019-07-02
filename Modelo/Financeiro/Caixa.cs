using System;

namespace Modelo.Servicos
{
    public class Caixa
    {
        public long CaixaID { get; set; }
        public DateTime Data { get; set; }
        public string Tipo { get; set; }
        public string Categoria { get; set; }
        public double Valor { get; set; }
        public double Saldo { get; set; }

        public long ContaID { get; set; }
        public virtual Conta Conta { get; set; }

        public Caixa()
        {

        }

        public Caixa(string tipo, string categoria, double valor, double saldo, long contaID)
        {
            Tipo = tipo;
            Categoria = categoria;
            Valor = valor;
            Saldo = saldo;
            ContaID = contaID;
            Data = DateTime.Now;
        }
    }
}

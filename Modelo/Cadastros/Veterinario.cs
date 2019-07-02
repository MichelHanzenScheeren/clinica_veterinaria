using Modelo.Servicos;
using System;
using System.Collections.Generic;

namespace Modelo.Cadastros
{
    public class Veterinario : Cadastro
    {
        public string Crmv { get; set; }
        public string EstadoCrmv { get; set; }
        public string AreaAtuacao { get; set; }
        public string Especializacao { get; set; }
        public string Graduacao { get; set; }
        public string Faculdade { get; set; }
        public string Mestrado { get; set; }
        public string Doutorado { get; set; }

        public virtual List<Atendimento> Atendimentos { get; set; }
        public virtual List<Receita> Receitas { get; set; }


        public Veterinario(string nome, string sexo, string cpf, string email, string telefone, DateTime dataNascimento, long enderecoID) 
          : base(nome, sexo, cpf, email, telefone, dataNascimento, enderecoID)
        {
        }
    }
}

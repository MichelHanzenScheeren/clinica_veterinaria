using Modelo.Servicos;
using System;
using System.Collections.Generic;

namespace Modelo
{
    public abstract class Cadastro
    {
        public long ID { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string Discriminator { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataCadastro { get; set; }

        public long EnderecoID { get; set; }
        public virtual Endereco Endereco { get; set; }
        public virtual List<Animal> Animais { get; set; }
        public virtual List<Conta> Contas { get; set; }

        protected Cadastro(string nome, string sexo, string cpf, string email, string telefone, 
        DateTime dataNascimento, long enderecoID)
        {
            Nome = nome;
            Sexo = sexo;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
            DataNascimento = dataNascimento;
            EnderecoID = enderecoID;

            DataCadastro = DateTime.Now;
        }

        public override string ToString()
        {
            return ID + " - " + Nome + ". CPF: " + Cpf;
        }
    }
}

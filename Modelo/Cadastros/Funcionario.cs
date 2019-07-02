using System;

namespace Modelo.Cadastros
{
    public class Funcionario : Cadastro
    {
        public string Cargo { get; set; }
        public int JornadaDeTrabalho { get; set; }
        public double Salario { get; set; }
        public Funcionario(string nome, string sexo, string cpf, string email, string telefone, DateTime dataNascimento, long enderecoID) : base(nome, sexo, cpf, email, telefone, dataNascimento, enderecoID)
        {
        }
    }
}

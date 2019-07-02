using System;

namespace Modelo
{
    public class Cliente : Cadastro
    {
        public Cliente(string nome, string sexo, string cpf, string email, string telefone, DateTime dataNascimento, long enderecoID) 
            : base(nome, sexo, cpf, email, telefone, dataNascimento, enderecoID)
        {   }
    }
}

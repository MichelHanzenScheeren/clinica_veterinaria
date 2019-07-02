using System;
using System.Collections.Generic;

namespace Modelo
{
    public class Animal
    {
        public long AnimalID { get; set; }
        public string Nome { get; set; }
        public string Especie { get; set; }
        public string Raca { get; set; }
        public string Sexo { get; set; }
        public double Peso { get; set; }
        public double Tamanho { get; set; }
        public string Cor { get; set; }
        public string Esterilizacao { get; set; }
        public string Pedigree { get; set; }

        public DateTime DataNascimento { get; set; }
        public DateTime DataCadastro { get; set; }

        public long CadastroID { get; set; }
        public virtual Cadastro Cadastro { get; set; }

        public virtual List<Atendimento> Atendimentos { get; set; }

        public Animal() {   }

        public Animal(string nome, string especie, string raca, string sexo, double peso, double tamanho, string cor, 
            string esterilizacao, string pedigree, DateTime dataNascimento, long iDCadastro)
        {
            Nome = nome;
            Especie = especie;
            Raca = raca;
            Sexo = sexo;
            Peso = peso;
            Tamanho = tamanho;
            Cor = cor;
            Esterilizacao = esterilizacao;
            Pedigree = pedigree;
            DataNascimento = dataNascimento;
            CadastroID = iDCadastro;

            DataCadastro = DateTime.Now;
        }

        public override string ToString()
        {
            return AnimalID + " - " + Nome + ". " + Raca + ", " + Especie;
        }
    }
}

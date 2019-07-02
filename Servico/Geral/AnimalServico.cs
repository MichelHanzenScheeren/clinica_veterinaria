using Modelo;
using Persistencia.Controle;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Servico.Geral
{
    public class AnimalServico
    {
        private Repositorio<Animal> _repositorio;
        public AnimalServico()
        {
            _repositorio = new Repositorio<Animal>();
        }

        public void Salvar(Animal animal)
        {
            if (animal.AnimalID == 0)
                _repositorio.Gravar(animal);
        }

        public void Editar(Animal animal)
        {
            _repositorio.Editar(animal);
        }

        public void Excluir(Animal animal)
        {
            _repositorio.Excluir(animal);
        }

        public List<Animal> ObterTodos()
        {
            return _repositorio.ObterTodos("Cadastro");
        }

        public List<Animal> Buscar(Expression<Func<Animal, bool>> predicado)
        {
            return _repositorio.Buscar(predicado);
        }

        public List<Animal> Buscar(Expression<Func<Animal, bool>> predicado, string tabela)
        {
                return _repositorio.Buscar(predicado, tabela);
        }

        public int Contagem(Expression<Func<Animal, bool>> predicado)
        {
            return _repositorio.Contagem(predicado);
        }

        public int Contagem()
        {
            return _repositorio.Contagem();
        }

    }
}

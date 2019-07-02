using Modelo.Servicos;
using Persistencia.Controle;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Servico.Geral
{
    public class InternamentoServico
    {
        private Repositorio<Internamento> _repositorio;
        public InternamentoServico()
        {
            _repositorio = new Repositorio<Internamento>();
        }

        public void Salvar(Internamento internamento)
        {
            _repositorio.Gravar(internamento);
        }

        public void Editar(Internamento internamento)
        {
            _repositorio.Editar(internamento);
        }

        public void Excluir(Internamento internamento)
        {
            _repositorio.Excluir(internamento);
        }

        public List<Internamento> Buscar(Expression<Func<Internamento, bool>> predicado)
        {
            return _repositorio.Buscar(predicado, "Animal");
        }

        public List<Internamento> ObterTodos()
        {
            return _repositorio.ObterTodos("Animal");
        }

        public int Contagem(Expression<Func<Internamento, bool>> predicado)
        {
            return _repositorio.Contagem(predicado);
        }

        public int Contagem()
        {
            return _repositorio.Contagem();
        }
    }
}

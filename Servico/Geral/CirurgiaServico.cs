using Modelo.Cadastros;
using Persistencia.Controle;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Servico.Geral
{
    public class CirurgiaServico
    {
        private Repositorio<Cirurgia> _repositorio;
        public CirurgiaServico()
        {
            _repositorio = new Repositorio<Cirurgia>();
        }

        public void Salvar(Cirurgia cirurgia)
        {
            _repositorio.Gravar(cirurgia);
        }

        public void Editar(Cirurgia cirurgia)
        {
            _repositorio.Editar(cirurgia);
        }

        public void Excluir(Cirurgia cirurgia)
        {
            _repositorio.Excluir(cirurgia);
        }

        public List<Cirurgia> ObterTodos()
        {
            return _repositorio.ObterTodos();
        }
        public List<Cirurgia> Buscar(Expression<Func<Cirurgia, bool>> cirurgia)
        {
            return _repositorio.Buscar(cirurgia);
        }
    }
}

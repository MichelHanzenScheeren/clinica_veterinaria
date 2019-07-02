using Modelo.Cadastros;
using Persistencia.Controle;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Servico.Geral
{
    public class ExameServico
    {
        private Repositorio<Exame> _repositorio;
        public ExameServico()
        {
            _repositorio = new Repositorio<Exame>();
        }

        public void Salvar(Exame exame)
        {
            _repositorio.Gravar(exame);
        }

        public void Editar(Exame exame)
        {
            _repositorio.Editar(exame);
        }

        public void Excluir(Exame exame)
        {
            _repositorio.Excluir(exame);
        }

        public List<Exame> ObterTodos()
        {
            return _repositorio.ObterTodos();
        }
        public List<Exame> Buscar(Expression<Func<Exame, bool>> exame)
        {
            return _repositorio.Buscar(exame);
        }
    }
}

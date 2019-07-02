using Modelo.Cadastros;
using Persistencia.Controle;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Servico.Geral
{
    public class VacinaServico
    {
        private Repositorio<Vacina> _repositorio;
        public VacinaServico()
        {
            _repositorio = new Repositorio<Vacina>();
        }

        public void Salvar(Vacina vacina)
        {
            _repositorio.Gravar(vacina);
        }

        public void Editar(Vacina vacina)
        {
            _repositorio.Editar(vacina);
        }

        public void Excluir(Vacina vacina)
        {
            _repositorio.Excluir(vacina);
        }

        public List<Vacina> ObterTodos()
        {
            return _repositorio.ObterTodos();
        }
        public List<Vacina> Buscar(Expression<Func<Vacina, bool>> vacina)
        {
            return _repositorio.Buscar(vacina);
        }
    }
}

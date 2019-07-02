using Modelo.Cadastros;
using Persistencia.Controle;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Servico.Geral
{
    public class MedicamentoServico
    {
        private Repositorio<Medicamento> _repositorio;
        public MedicamentoServico()
        {
            _repositorio = new Repositorio<Medicamento>();
        }

        public void Salvar(Medicamento medicamento)
        {
            _repositorio.Gravar(medicamento);
        }

        public void Editar(Medicamento medicamento)
        {
            _repositorio.Editar(medicamento);
        }

        public void Excluir(Medicamento medicamento)
        {
            _repositorio.Excluir(medicamento);
        }

        public List<Medicamento> ObterTodos()
        {
            return _repositorio.ObterTodos();
        }
        public List<Medicamento> Buscar(Expression<Func<Medicamento, bool>> predicado)
        {
            return _repositorio.Buscar(predicado);
        }
    }
}

using Modelo.Servicos;
using Persistencia.Controle;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Servico.Geral
{
    public class AgendamentoServico
    {
        private Repositorio<Agendamento> _repositorio;
        public AgendamentoServico()
        {
            _repositorio = new Repositorio<Agendamento>();
        }

        public void Salvar(Agendamento agendamento)
        {
             _repositorio.Gravar(agendamento);
        }

        public void Editar(Agendamento agendamento)
        {
            _repositorio.Editar(agendamento);
        }

        public void Excluir(Agendamento agendamento)
        {
            _repositorio.Excluir(agendamento);
        }

        public List<Agendamento> ObterTodos()
        {
            return _repositorio.ObterTodos("Animal", "Animal.Cadastro");
        }

        public List<Agendamento> Buscar(Expression<Func<Agendamento, bool>> predicado)
        {
            return _repositorio.Buscar(predicado, "Animal", "Animal.Cadastro");
        }

        public int Contagem(Expression<Func<Agendamento, bool>> predicado)
        {
            return _repositorio.Contagem(predicado);
        }
    }
}

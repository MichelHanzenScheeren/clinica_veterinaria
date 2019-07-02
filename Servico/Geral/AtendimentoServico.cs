using Modelo;
using Persistencia.Controle;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Servico.Geral
{
    public class AtendimentoServico
    {
        private Repositorio<Atendimento> _repositorio;
        public AtendimentoServico()
        {
            _repositorio = new Repositorio<Atendimento>();
        }

        public void Salvar(Atendimento atendimento)
        {
            if (atendimento.AtendimentoID == 0)
                _repositorio.Gravar(atendimento);
        }

        public void Editar(Atendimento atendimento)
        {
            _repositorio.Editar(atendimento);
        }

        public List<Atendimento> Buscar(Expression<Func<Atendimento, bool>> predicado)
        {
            return _repositorio.Buscar(predicado, "Animal", "Veterinario");
        }

        public void Excluir(Atendimento atendimento)
        {
            _repositorio.Excluir(atendimento);
        }

        public int Contagem(Expression<Func<Atendimento, bool>> predicado)
        {
            return _repositorio.Contagem(predicado);
        }
    }
}

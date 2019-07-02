using Modelo.Servicos;
using Persistencia.Controle;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Servico.Geral
{
    public class ContaServico
    {
        private Repositorio<Conta> _repositorio;

        public ContaServico()
        {
            _repositorio = new Repositorio<Conta>();
        }

        public void Salvar(Conta conta)
        {
            _repositorio.Gravar(conta);
        }

        public void Editar(Conta conta)
        {
            _repositorio.Editar(conta);
        }

        public long Ultimo()
        {
            Conta conta = _repositorio.Ultimo();
            return conta.ContaID;
        }

        public void Excluir(Conta conta)
        {
            _repositorio.Excluir(conta);
        }

        public List<Conta> Buscar(Expression<Func<Conta, bool>> predicado)
        {
            return _repositorio.Buscar(predicado, "Cadastro");
        }

        public List<Conta> ObterTodos()
        {
            return _repositorio.ObterTodos("Cadastro");
        }
    }
}

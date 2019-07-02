using Modelo.Servicos;
using Persistencia.Controle;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Servico.Geral
{
    public class CaixaServico
    {
        private Repositorio<Caixa> _repositorio;

        public CaixaServico()
        {
            _repositorio = new Repositorio<Caixa>();
        }

        public void Salvar(Caixa caixa)
        {
            _repositorio.Gravar(caixa);
        }

        public void Editar(Caixa caixa)
        {
            _repositorio.Editar(caixa);
        }

        public void Excluir(Caixa caixa)
        {
            _repositorio.Excluir(caixa);
        }

        public Double Ultimo()
        {
            Caixa caixa = _repositorio.Ultimo();
            if (caixa != null)
                return caixa.Saldo;
            else
                return 0;
        }

        public List<Caixa> Buscar(Expression<Func<Caixa, bool>> predicado)
        {
            return _repositorio.Buscar(predicado, "Conta","Conta.Cadastro");
        }

        public List<Caixa> ObterTodos()
        {
            return _repositorio.ObterTodos("Conta", "Conta.Cadastro");
        }
    }
}

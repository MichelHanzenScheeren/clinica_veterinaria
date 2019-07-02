using Modelo;
using Persistencia.Controle;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Servico.Geral
{
    public class CadastroServico
    {
        private Repositorio<Cadastro> _repositorio;

        public CadastroServico()
        {
            _repositorio = new Repositorio<Cadastro>();
        }

        public void Salvar(Cadastro cadastro)
        {
            _repositorio.Gravar(cadastro);
        }

        public void Editar(Cadastro cadastro)
        {
            _repositorio.Editar(cadastro);
        }

        public void Excluir(Cadastro cadastro)
        {
             _repositorio.Excluir(cadastro);
        }

        public List<Cadastro> Buscar(Expression<Func<Cadastro, bool>> predicado, string tabela)
        {
            return _repositorio.Buscar(predicado, tabela);
        }

        public int Contagem(Expression<Func<Cadastro, bool>> predicado)
        {
            return _repositorio.Contagem(predicado);
        }
    }
}

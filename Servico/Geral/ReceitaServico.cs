using Modelo.Servicos;
using Persistencia.Controle;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Servico.Geral
{
    public class ReceitaServico
    {
        private Repositorio<Receita> _repositorio;
        public ReceitaServico()
        {
            _repositorio = new Repositorio<Receita>();
        }

        public void Salvar(Receita receita)
        {
            _repositorio.Gravar(receita);
        }

        public void Editar(Receita receita)
        {
            _repositorio.Editar(receita);
        }

        public void Excluir(Receita receita)
        {
            _repositorio.Excluir(receita);
        }

        public List<Receita> ObterTodos()
        {
            return _repositorio.ObterTodos("Veterinario", "Animal", "Medicamento");
        }

        public List<Receita> Buscar(Expression<Func<Receita, bool>> receita)
        {
            return _repositorio.Buscar(receita, "Veterinario", "Animal", "Medicamento");
        }

        public int Contagem(Expression<Func<Receita, bool>> predicado)
        {
            return _repositorio.Contagem(predicado);
        }

        public int Contagem()
        {
            return _repositorio.Contagem();
        }
    }
}

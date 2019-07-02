using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Persistencia.Controle
{
    public interface IRepositorio<T> where T : class
    {
        void Gravar(T entidade);

        void Editar(T entidade);

        void Excluir(T entidade);

        T Ultimo();

        List<T> ObterTodos();

        List<T> ObterTodos(string tabela);

        List<T> ObterTodos(string tabela, string tabela2);

        List<T> ObterTodos(string tabela, string tabela2, string tabela3);

        List<T> Buscar(Expression<Func<T, bool>> predicado);

        List<T> Buscar(Expression<Func<T, bool>> predicado, string tabela);

        List<T> Buscar(Expression<Func<T, bool>> predicado, string tabela, string tabela2);

        List<T> Buscar(Expression<Func<T, bool>> predicado, string tabela, string tabela2, string tabela3);

        int Contagem(Expression<Func<T, bool>> predicado);

        int Contagem();

    }
}

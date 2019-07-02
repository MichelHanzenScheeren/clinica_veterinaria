using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Persistencia.Controle
{
    public class Repositorio<T> : IRepositorio<T> where T : class
    {
        public void Gravar(T entidade)
        {
            using (var context = new EFContext())
            {
                context.Set<T>().Add(entidade);
                context.SaveChanges();
            }
        }

        public void Editar(T entidade)
        {
            using (var context = new EFContext())
            {
                context.Entry(entidade).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Excluir(T entidade)
        {
            using (var context = new EFContext())
            {
                context.Set<T>().Remove(entidade);
                context.SaveChanges();
            }
        }

        public T Ultimo()
        {
            using (var context = new EFContext())
            {
                return context.Set<T>().LastOrDefault();
            }
        }

        public List<T> ObterTodos()
        {
            using (var context = new EFContext())
            {
                return context.Set<T>().ToList();
            }
        }

        public List<T> ObterTodos(string tabela)
        {
            using (var context = new EFContext())
            {
                return context.Set<T>().Include(tabela).ToList();
            }
        }
        public List<T> ObterTodos(string tabela, string tabela2)
        {
            using (var context = new EFContext())
            {
                return context.Set<T>().Include(tabela).Include(tabela2).ToList();
            }
        }

        public List<T> ObterTodos(string tabela, string tabela2, string tabela3)
        {
            using (var context = new EFContext())
            {
                return context.Set<T>().Include(tabela).Include(tabela2).Include(tabela3).ToList();
            }
        }

        public List<T> Buscar(Expression<Func<T, bool>> predicado)
        {
            using (var context = new EFContext())
            {
                return context.Set<T>().Where(predicado).ToList();
            }
        }

        public List<T> Buscar(Expression<Func<T, bool>> predicado, string tabela)
        {
            using (var context = new EFContext())
            {
                return context.Set<T>().Include(tabela).Where(predicado).ToList();
            }
        }

        public List<T> Buscar(Expression<Func<T, bool>> predicado, string tabela, string tabela2)
        {
            using (var context = new EFContext())
            {
                return context.Set<T>().Include(tabela).Include(tabela2).Where(predicado).ToList();
            }
        }

        public List<T> Buscar(Expression<Func<T, bool>> predicado, string tabela, string tabela2, string tabela3)
        {
            using (var context = new EFContext())
            {
                return context.Set<T>().Include(tabela).Include(tabela2).Include(tabela3).Where(predicado).ToList();
            }
        }

        public int Contagem(Expression<Func<T, bool>> predicado)
        {
            using (var context = new EFContext())
            {
                return context.Set<T>().Where(predicado).Count();
            }
        }

        public int Contagem()
        {
            using (var context = new EFContext())
            {
                return context.Set<T>().Count();
            }
        }
    }
}

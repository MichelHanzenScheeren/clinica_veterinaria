using Modelo;
using Persistencia.Controle;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Servico.Geral
{
    public class EnderecoServico
    {
        private Repositorio<Endereco> _repositorio;

        public EnderecoServico()
        {
            _repositorio = new Repositorio<Endereco>();
        }

        public void Salvar(Endereco endereco)
        {
            _repositorio.Gravar(endereco);
        }

        public void Editar(Endereco endereco)
        {
            _repositorio.Editar(endereco);
        }

        public long Ultimo()
        {
            Endereco endereco = _repositorio.Ultimo();
            return endereco.EnderecoID;
        }

        public List<Endereco> Buscar(Expression<Func<Endereco, bool>> predicado)
        {
            return _repositorio.Buscar(predicado);
        }
    }
}

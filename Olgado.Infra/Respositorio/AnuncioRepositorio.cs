using Olgado.Domain.Entidades;
using Olgado.Domain.Repositorio;
using Olgado.Infra.Contexto;
using System;
using System.Collections.Generic;

namespace Olgado.Infra.Respositorio
{
    class AnuncioRepositorio : IAnuncioRepositorio
    {
        private readonly IDb _Db;

        public Anuncio BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Editar(Anuncio anuncio)
        {
            throw new NotImplementedException();
        }

        public bool Excluir(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Anuncio> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public void Salvar(Anuncio anuncio)
        {
            throw new NotImplementedException();
        }
    }
}

using Olgado.Domain.Entidades;
using System;
using System.Collections.Generic;

namespace Olgado.Domain.Repositorio
{
    public interface IAnuncioRepositorio
    {
        void Salvar(Anuncio anuncio);
        IEnumerable<Anuncio> ListarTodos();
        Anuncio BuscarPorId(Guid id);
        bool Excluir(Guid id);
        void Editar(Anuncio anuncio);

    }
}

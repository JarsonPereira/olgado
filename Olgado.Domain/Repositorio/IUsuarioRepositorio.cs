using Olgado.Domain.Entidades;
using System;
using System.Collections.Generic;

namespace Olgado.Domain.Repositorio
{
   public interface IUsuarioRepositorio
    {
        void Salvar(Usuario usuario);
        IEnumerable<Usuario> ListarTodos();
        Usuario BuscarPorId(Guid id);
        void Editar(Usuario usuario);
        bool Excluir(Guid id);

    }
}

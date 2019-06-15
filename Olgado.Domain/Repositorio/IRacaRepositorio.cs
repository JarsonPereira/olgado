using Olgado.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Olgado.Domain.Repositorio
{
    public interface IRacaRepositorio
    {
        IEnumerable<Raca> ObterTodos();
    }
}

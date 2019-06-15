using Olgado.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Olgado.Domain.Repositorio
{
    public interface IClassificacaoRepositorio
    {
        IEnumerable<Classificacao> ObterTodos();
    }
}

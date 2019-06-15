using System;
using System.Collections.Generic;
using System.Linq;
using Olgado.Domain.Entidades;
using Olgado.Domain.Repositorio;
using Olgado.Shared.Command;

namespace Olgado.Domain.Commands.RacaContext
{
    public class RacaCommand
    {
        public IRacaRepositorio RacaRepositorio;

        public RacaCommand(IRacaRepositorio racaRepositorio)
        {
            RacaRepositorio = racaRepositorio;
        }

        public IEnumerable<Raca> Query()
        {
            return RacaRepositorio.ObterTodos();
        }
    }
}
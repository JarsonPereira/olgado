using Olgado.Domain.Entidades;
using Olgado.Shared.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace Olgado.Domain.Commands.RacaContext
{
    public class RacaFiltroRequest:IRequest
    {
        public Func<Raca,bool> FiltroRaca { get; set; }
    }
}

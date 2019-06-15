using Olgado.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Olgado.Domain.Entidades
{
    public class Raca:Entidade
    {
        public Raca(string descricao)
        {
            Descricao = descricao;
        }

        public string Descricao { get; private set; }
    }
}

using Olgado.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Olgado.Domain.Entidades
{
    public class Classificacao:Entidade
    {
        public Classificacao(string descricao)
        {
            Descricao = descricao;
        }

        public string Descricao { get; private set; }
    }
}

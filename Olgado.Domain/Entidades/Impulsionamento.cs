using Olgado.Shared.Entidades;
using System;

namespace Olgado.Domain.Entidades
{
    public class Impulsionamento:Entidade
    {
        public Impulsionamento(string iDAnuncio, decimal valor, DateTime tempoVisibilidade, decimal raioKM)
        {
            IDAnuncio = iDAnuncio;
            Valor = valor;
            TempoVisibilidade = tempoVisibilidade;
            RaioKM = raioKM;
        }

        public string IDAnuncio { get; private set; }
        public decimal Valor { get; private set; }
        public DateTime TempoVisibilidade { get; private set; }
        public decimal RaioKM { get; private set; }

    }
}

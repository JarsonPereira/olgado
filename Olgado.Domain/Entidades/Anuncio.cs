using Olgado.Domain.Enum;
using Olgado.Domain.ValueObjects;
using Olgado.Shared.Entidades;
using System;
using System.Collections.Generic;


namespace Olgado.Domain.Entidades
{
    public class Anuncio:Entidade
    {
        public Guid IDUsuario { get; private set; }
        public string Descricao { get; private set; }
        public List<string> ImagensUrl { get; private set; }
        public Localizacao Localizacao  { get; private set; }
        public Animal Animal { get; private set; }
        public decimal Valor { get; private set; }
        public TipoAnuncio Tipo { get; private set; }
    }
}

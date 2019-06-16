using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OlgadoUI.Models
{
    public class Anuncio
    {
        public Guid IDUsuario { get;  set; }
        public string Descricao { get;  set; }
        public HttpPostedFileBase ImagemUrl { get;  set; }
        public string Estado { get;  set; }
        public string Cep { get; private set; }
        public int QuantidadeAnimal { get; set; }
        public int TipoAnuncio { get;  set; }
        public bool Impulsionar { get;  set; }
        public decimal  ValorTotal { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }

    }
}
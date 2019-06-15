using System;
using System.Collections.Generic;
using System.Text;

namespace Olgado.Domain.ValueObjects
{
    public class Localizacao
    {
        public string Municipio { get;  set; }
        public string UF { get;  set; }
        public string CEP { get;  set; }

    }
}

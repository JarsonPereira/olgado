using System;
using System.Collections.Generic;
using System.Text;

namespace Olgado.Domain.ValueObjects
{
    public class Localizacao
    {
        public string Municipio { get; private set; }
        public string UF { get; private set; }
        public string CEP { get; private set; }

    }
}

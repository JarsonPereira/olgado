using System;
using System.Collections.Generic;
using System.Text;

namespace Olgado.Domain.ValueObjects
{
    public class Filiacao
    {
        public string DescricaoPai { get; private set; }
        public string DescricaoMae { get; private set; }
    }
}

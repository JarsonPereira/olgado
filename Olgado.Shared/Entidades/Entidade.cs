using System;
using System.Collections.Generic;
using System.Text;

namespace Olgado.Shared.Entidades
{
    public class Entidade
    {
        public Entidade()
        {
            ID = Guid.NewGuid();
        }

        public Guid ID { get; private set; }
    }
}

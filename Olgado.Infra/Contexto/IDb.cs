using System;
using System.Data;

namespace Olgado.Infra.Contexto
{
    public interface IDb:IDisposable
    {
        IDbConnection GetCon();
    }
}

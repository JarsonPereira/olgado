using System;
using System.Collections.Generic;
using System.Text;

namespace Olgado.Shared.Command
{
    public interface ICommand<T> where T : IRequest
    {
        IResponse Handler(T input);
    }
}

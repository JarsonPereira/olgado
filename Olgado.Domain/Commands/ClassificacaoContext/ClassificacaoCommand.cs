using System;
using System.Collections.Generic;
using System.Linq;
using Olgado.Domain.Entidades;
using Olgado.Domain.Repositorio;
using Olgado.Shared.Command;

namespace Olgado.Domain.Commands.ClassificacaoContext
{
    public class ClassificacaoCommand
    {
        public IClassificacaoRepositorio ClassificacaoRepositorio;

        public ClassificacaoCommand(IClassificacaoRepositorio _ClassificacaoRepositorio)
        {
            ClassificacaoRepositorio = _ClassificacaoRepositorio;
        }

        public IEnumerable<Classificacao> Query()
        {
            return ClassificacaoRepositorio.ObterTodos();
        }
    }
}
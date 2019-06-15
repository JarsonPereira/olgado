using System;
using System.Collections.Generic;
using System.Linq;
using Olgado.Domain.Entidades;
using Olgado.Domain.Repositorio;
using Olgado.Shared.Command;

namespace Olgado.Domain.Commands.AnuncioContext
{
    public class AnuncioCommand
    {
        public IAnuncioRepositorio AnuncioRepositorio;

        public AnuncioCommand(IAnuncioRepositorio _AnuncioRepositorio)
        {
            AnuncioRepositorio = _AnuncioRepositorio;
        }

        public IEnumerable<Anuncio> Query()
        {
            return AnuncioRepositorio.ListarTodos();
        }
    }
}
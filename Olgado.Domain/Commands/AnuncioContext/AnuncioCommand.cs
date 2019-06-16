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

        public IEnumerable<AnuncioResponse> Query()
        {
            List<AnuncioResponse> anuncios = new List<AnuncioResponse>();
            foreach (var item in AnuncioRepositorio.ListarTodos())
            {
                anuncios.Add(new AnuncioResponse
                {
                    Cidade = item.Localizacao.Municipio,
                    UF = item.Localizacao.UF,
                    Descricao = item.Descricao,
                    Imagem = item.ImagensUrl.FirstOrDefault(),
                    Preco = item.Valor.ToString("F2")
                });
            }
            return anuncios;
        }
    }

    public class AnuncioResponse
    {
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Preco { get;  set; }
    }
}
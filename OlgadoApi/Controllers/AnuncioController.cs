using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Olgado.Domain.Commands.AnuncioContext;
using Olgado.Domain.Commands.ClassificacaoContext;
using Olgado.Domain.Entidades;
using Olgado.Domain.Repositorio;

namespace OlgadoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnuncioController : ControllerBase
    {
        public AnuncioCommand AnuncioServico { get; private set; }
        public AnuncioController(IAnuncioRepositorio _AnuncioRepositorio)
        {
            AnuncioServico = new AnuncioCommand(_AnuncioRepositorio);
        }


        // GET api/Anuncio
        [HttpGet]
        public IActionResult Get()
        {
            var lista = AnuncioServico.Query();
            FiltroAnuncio(Request.Query,ref lista);

            return Ok(lista);
        }



        private void FiltroAnuncio(IQueryCollection query, ref IEnumerable<AnuncioResponse> anuncio)
        {
            if (query.TryGetValue("Descricao", out StringValues descricaoFiltro))
            {
                var descricao = descricaoFiltro[0];
                anuncio = anuncio.Where(x => x.Descricao.Contains(descricao));
            }
            //if (query.TryGetValue("Valor", out StringValues valorFilro))
            //{
            //    string[] range = valorFilro[0].Split('-');
            //    var valor1 = decimal.Parse(range[0]);
            //    var valor2 = decimal.Parse(range[1]);
            //    anuncio = anuncio.Where(x => x.Preco>= valor1 && x.Valor<=valor2);
            //}
        }

       
    }
  
}

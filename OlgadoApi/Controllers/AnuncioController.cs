using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Olgado.Domain.Commands.AnuncioContext;
using Olgado.Domain.Commands.ClassificacaoContext;
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
        public IActionResult Get(string nome = null)
        {
        
            var lista = AnuncioServico.Query();
            if (!string.IsNullOrEmpty(nome))
                lista = lista.Where(x => x.Descricao.ToLower().Contains(nome.ToLower()));
            return Ok(lista);
        }
    }
}

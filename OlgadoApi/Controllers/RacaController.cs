using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Olgado.Domain.Commands.RacaContext;
using Olgado.Domain.Repositorio;

namespace OlgadoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RacaController : ControllerBase
    {
        public Olgado.Domain.Commands.RacaContext.RacaCommand RacaServico { get; private set; }
        public RacaController(IRacaRepositorio _RacaRepositorio)
        {
            RacaServico = new RacaCommand(_RacaRepositorio);
        }


        // GET api/Raca
        [HttpGet]
        public IActionResult Get(string nome = null)
        {
        
            var lista = RacaServico.Query();
            if (!string.IsNullOrEmpty(nome))
                lista = lista.Where(x => x.Descricao.ToLower().Contains(nome.ToLower()));
            return Ok(lista);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Olgado.Domain.Commands;
using Olgado.Domain.Commands.ClassificacaoContext;
using Olgado.Domain.Repositorio;

namespace OlgadoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassificacaoController : ControllerBase
    {
        public ClassificacaoCommand ClassificacaoServico { get; private set; }
        public ClassificacaoController(IClassificacaoRepositorio _ClassificacaoRepositorio)
        {
            ClassificacaoServico = new ClassificacaoCommand(_ClassificacaoRepositorio);
        }

      
        // GET api/Classificacao
        [HttpGet]
        public IActionResult Get(string nome =null)
        {
            var lista = ClassificacaoServico.Query();
            if (!string.IsNullOrEmpty(nome))
                lista = lista.Where(x => x.Descricao.ToLower().Contains(nome.ToLower()));
            return Ok(lista);
        }
    }
}

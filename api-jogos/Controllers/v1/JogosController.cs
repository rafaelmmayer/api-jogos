using api_jogos.Models;
using api_jogos.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_jogos.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class JogosController : ControllerBase
    {

        private readonly IJogoService _jogoService;

        public JogosController(IJogoService jogoService)
        {
            _jogoService = jogoService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Jogo>>> Obter()
        {
            var result = await _jogoService.ObterJogos();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Jogo>> ObterById([FromRoute] int id)
        {
            var result = await _jogoService.ObterJogo(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<Jogo>> InserirJogo([FromBody] Jogo jogo)
        {
            var result = await _jogoService.InserirJogo(jogo);
            return Ok(result);
        }

        [HttpPut("{id}")]        
        public async Task<ActionResult> AtualizarJogo([FromRoute] int id, [FromBody] Jogo jogo)
        {
            await _jogoService.AtualizarJogo(id, jogo);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> DeleteJogo([FromRoute] int id)
        {
            await _jogoService.DeletarJogo(id);
            return Ok();
        }

    }
}

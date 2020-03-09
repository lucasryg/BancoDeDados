using Microsoft.AspNetCore.Mvc;
using Senai.InLock.WebApi.CodeFirst.Domains;
using Senai.InLock.WebApi.CodeFirst.Interfaces;
using Senai.InLock.WebApi.CodeFirst.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.CodeFirst.Controller
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]

    public class JogoController : ControllerBase
    {
        private IJogoRepository _jogoRepository;

        public JogoController()
        {
            _jogoRepository = new JogoRepository();
        }

        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            Jogo jogoBuscado = _jogoRepository.BuscarPorId(id);

            if (jogoBuscado == null)
            {
                return BadRequest("Jogo não encontrado");
            }
            else
            {
                return Created("http://localhost:5000/api/Jogo", jogoBuscado);
            }
        }

        [HttpGet]
        public  IActionResult Get()
        {
            return Ok(_jogoRepository.Listar());
        }

        [HttpPost]
        public IActionResult Post(Jogo novoJogo)
        { 
            
            if(novoJogo == null)
            {
                return BadRequest("Você precisa inserir um jogo");
            }

            return Created("http://localhost:5000/api/Jogo", novoJogo);
        }

        [HttpPut]
        public IActionResult Put(Jogo novoJogo)
        { 
             _jogoRepository.Atualizar(novoJogo);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Jogo jogoBuscado = _jogoRepository.BuscarPorId(id);

            if(jogoBuscado != null)
            {
                _jogoRepository.Deletar(id);

                return Ok("jogo deletado");
            }

            return null;

        }

        [HttpGet]
        public IActionResult GetJogoEstudio()
        {
            return Ok(_jogoRepository.ListarComEstudios());   
        }

       

    }
}

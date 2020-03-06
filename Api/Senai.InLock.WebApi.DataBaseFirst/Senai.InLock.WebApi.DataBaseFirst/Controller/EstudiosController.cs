using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Senai.InLock.WebApi.DataBaseFirst.Domains;
using Senai.InLock.WebApi.DataBaseFirst.Interfaces;
using Senai.InLock.WebApi.DataBaseFirst.Repository;

namespace Senai.InLock.WebApi.DataBaseFirst.Controller
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]

    public class EstudiosController : ControllerBase
    {
        private IEstudiosRepository _estudiosRepository;

        public EstudiosController()
        {
            _estudiosRepository = new EstudiosRepository();
        }

        [HttpGet]
        public IActionResult  Get()
        {
            return Ok(_estudiosRepository.Listar());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_estudiosRepository.BuscarPorId(id));
        }

        [HttpPost]
        public IActionResult Post(Estudio novoEstudio)
        {
            if(novoEstudio == null)
            {
                return BadRequest("Novo estudio está nulo");
            }
            _estudiosRepository.Cadastrar(novoEstudio);

            return Created("http://localhost:5000/api/Jogo", novoEstudio);
        }
       
    }
}
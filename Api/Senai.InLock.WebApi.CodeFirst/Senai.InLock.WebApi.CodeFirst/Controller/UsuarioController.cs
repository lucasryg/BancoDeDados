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



    // Usuario POST esta dando erro 
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository;

        public UsuarioController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            Usuarios usuarioBuscado = _usuarioRepository.BuscarPorId(id);

            if (usuarioBuscado == null)
            {
                return BadRequest("Usuario não foi encontrado");
            }
            else
            {
                return Created("http://localhost:5000/api/Usuario", usuarioBuscado);
            }
        }

 
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_usuarioRepository.Listar());
        }

        [HttpPost]
        public IActionResult Post(Usuarios novoUsuario)
        {

            if (novoUsuario == null)
            {
                return BadRequest("Você precisa inserir um usuario");
            }

            return Created("http://localhost:5000/api/Usuario", novoUsuario);
        }

        [HttpPut]
        public IActionResult Put(Usuarios usuarioAtualizado)
        {
           _usuarioRepository.Atualizar(usuarioAtualizado);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Usuarios usuarioDeletado = _usuarioRepository.BuscarPorId(id);

            if (usuarioDeletado != null)
            {
                _usuarioRepository.Deletar(id);

                return Ok("Usuario deletado");
            }

            return null;

        }
    }
}

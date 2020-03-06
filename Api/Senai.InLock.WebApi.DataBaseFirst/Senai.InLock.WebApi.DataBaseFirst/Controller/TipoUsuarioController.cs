using Microsoft.AspNetCore.Mvc;
using Senai.InLock.WebApi.DataBaseFirst.Domains;
using Senai.InLock.WebApi.DataBaseFirst.Interfaces;
using Senai.InLock.WebApi.DataBaseFirst.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.DataBaseFirst.Controller
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]

    public class TipoUsuarioController : ControllerBase
    {
        private ITipoUsuarioRepository _tur;

        public TipoUsuarioController()
        {
            _tur = new TipoUsuarioRepository();
        }

        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            TipoUsuario TUPbuscado = _tur.BuscarPorId(id);

            if (TUPbuscado== null)
            {
                return BadRequest("Tipo Usuario não encontrado");
            }
            else
            {
                return Created("http://localhost:5000/api/TipoUsuario", TUPbuscado);
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_tur.Listar());
        }

        [HttpPost]
        public IActionResult Post(TipoUsuario tu)
        {

            if (tu == null)
            {
                return BadRequest("Você precisa inserir um Tipo de Usuario");
            }

            return Created("http://localhost:5000/api/TipoUsuario", tu);
        }

        [HttpPut]
        public IActionResult Put(TipoUsuario tu)
        {
            _tur.Atualizar(tu);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            TipoUsuario tuBuscado = _tur.BuscarPorId(id);

            if (tuBuscado != null)
            {
                _tur.Deletar(id);

                return Ok("Tipo Usuario deletado");
            }

            return null;

        }
    }
}

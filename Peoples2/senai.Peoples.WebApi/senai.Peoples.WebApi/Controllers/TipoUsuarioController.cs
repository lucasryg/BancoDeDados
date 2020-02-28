using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.Peoples.WebApi.Domains;
using senai.Peoples.WebApi.Interfaces;

namespace senai.Peoples.WebApi.Controllers
{
    [Route("api/[controller]")]

    // Define que o tipo de resposta da API será no formato JSON
    [Produces("application/json")]

    [ApiController]
    public class TipoUsuarioController : ControllerBase
    {
        private ITipoUsuarioRepository _tipoUsuarioRepository { get; set; }


        public IActionResult Post(TipoUsuarioDomain NovoTUsuario)
        {
            _tipoUsuarioRepository.Cadastrar(NovoTUsuario);

            return Created("http://localhost:5000/api/Filmes", NovoTUsuario);
        }

        public IActionResult Get()
        {
            return Ok(_tipoUsuarioRepository.Listar());
        }
    }
}
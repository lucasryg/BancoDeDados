using Microsoft.AspNetCore.Mvc;
using Senai.Peoples.WebApi.Domain;
using Senai.Peoples.WebApi.Interfaces;
using Senai.Peoples.WebApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.Controller
{
    [Produces("application/json")]

    [Route("api/[controller]")]

    public class FuncionariosController : ControllerBase
    {
        private IFuncionariosRepository _funcionariosRepositoy { get; set;  }

        public FuncionariosController()
        {
            _funcionariosRepositoy = new FuncionariosRepository();
        }
       
        [HttpGet]
        public IEnumerable<FuncionariosDomain> Get()
        {
            return _funcionariosRepositoy.Listar();
        }
    }
}

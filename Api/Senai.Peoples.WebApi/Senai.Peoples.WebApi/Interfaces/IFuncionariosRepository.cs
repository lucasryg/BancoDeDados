using Senai.Peoples.WebApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.Interfaces
{
    interface IFuncionariosRepository
    {
        /// <summary>
        /// Vai listar todos os dados da tabela
        /// </summary>
        /// <returns>O nome E sobrenome de cada funcionario</returns>
        List<FuncionariosDomain> Listar();
    }
}

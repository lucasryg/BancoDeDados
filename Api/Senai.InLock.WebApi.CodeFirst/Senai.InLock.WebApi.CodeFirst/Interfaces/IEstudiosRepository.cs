using Senai.InLock.WebApi.CodeFirst.Domains;using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.CodeFirst.Interfaces
{
    interface IEstudiosRepository
    {
        List<Estudio> Listar();

        Estudio BuscarPorId(int id);

        void Cadastrar(Estudio novoEstudio);
    }
}

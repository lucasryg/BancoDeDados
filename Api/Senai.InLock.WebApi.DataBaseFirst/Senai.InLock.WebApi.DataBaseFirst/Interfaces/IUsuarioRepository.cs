using Senai.InLock.WebApi.DataBaseFirst.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.DataBaseFirst.Interfaces
{
    interface IUsuarioRepository
    {
        List<Usuarios> Listar();

        void Cadastrar(Usuarios usuarios);

        Usuarios BuscarPorId(int id);

        void Deletar(int id);

        void Atualizar(Usuarios usuarios);
    }
}

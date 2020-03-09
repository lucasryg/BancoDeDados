using Senai.InLock.WebApi.CodeFirst.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.CodeFirst.Interfaces
{
    interface ITipoUsuarioRepository
    {
        List<TipoUsuario> Listar();

        void Cadastrar(TipoUsuario tipoUsuario);

        TipoUsuario BuscarPorId(int id);

        void Deletar(int id);

        void Atualizar(TipoUsuario tipoUsuario);
    }
}

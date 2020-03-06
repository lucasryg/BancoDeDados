using Senai.InLock.WebApi.DataBaseFirst.Domains;
using Senai.InLock.WebApi.DataBaseFirst.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.DataBaseFirst.Repository
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        InLockContext ctx = new InLockContext();


        public void Atualizar(TipoUsuario TipoUsuario)
        {

            ctx.TipoUsuario.Update(TipoUsuario);

            ctx.SaveChanges();
        }

        public TipoUsuario BuscarPorId(int id)
        {
            return ctx.TipoUsuario.FirstOrDefault(U => U.IdTipoUsuario == id);

        }

        public void Cadastrar(TipoUsuario TipoUsuario)
        {
            ctx.TipoUsuario.Add(TipoUsuario);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            TipoUsuario deletar = new TipoUsuario();

            deletar = BuscarPorId(id);

            ctx.TipoUsuario.Remove(deletar);

            ctx.SaveChanges();

        }

        public List<TipoUsuario> Listar()
        {
            return ctx.TipoUsuario.ToList();
        }
    }
}

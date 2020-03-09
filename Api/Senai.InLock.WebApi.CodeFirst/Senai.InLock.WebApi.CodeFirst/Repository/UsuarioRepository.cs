using Senai.InLock.WebApi.CodeFirst.Contexts;
using Senai.InLock.WebApi.CodeFirst.Domains;
using Senai.InLock.WebApi.CodeFirst.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.CodeFirst.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        InLockContext ctx = new InLockContext();


        public void Atualizar(Usuarios usuario)
        {

            ctx.Usuarios.Update(usuario);

            ctx.SaveChanges();
        }

        public Usuarios BuscarPorId(int id)
        {
            return ctx.Usuarios.FirstOrDefault(U => U.IdUsuario == id);

        }

        public void Cadastrar(Usuarios usuario)
        {
            ctx.Usuarios.Add(usuario);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Usuarios deletar = new Usuarios();

            deletar = BuscarPorId(id);

            ctx.Usuarios.Remove(deletar);

            ctx.SaveChanges();

        }

        public List<Usuarios> Listar()
        {
            return ctx.Usuarios.ToList();
        }
    }
}

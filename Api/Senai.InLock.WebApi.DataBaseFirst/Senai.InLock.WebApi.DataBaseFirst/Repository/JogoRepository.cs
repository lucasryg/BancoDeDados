using Senai.InLock.WebApi.DataBaseFirst.Domains;
using Senai.InLock.WebApi.DataBaseFirst.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.DataBaseFirst.Repository
{
    public class JogoRepository : IJogoRepository
    {
        InLockContext ctx = new InLockContext();


        public void Atualizar(Jogo jogoDomain)
        {

            ctx.Jogo.Update(jogoDomain);

            ctx.SaveChanges();
        }

        public Jogo BuscarPorId(int id)
        {
            return ctx.Jogo.FirstOrDefault(j => j.IdJogo == id);

        }

        public void Cadastrar(Jogo jogoDomain)
        {
            ctx.Jogo.Add(jogoDomain);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Jogo deletar = new Jogo();

            deletar = BuscarPorId(id);

            ctx.Jogo.Remove(deletar);

            ctx.SaveChanges();

        }

        public List<Jogo> Listar()
        {
            return ctx.Jogo.ToList();
        }
    }
}

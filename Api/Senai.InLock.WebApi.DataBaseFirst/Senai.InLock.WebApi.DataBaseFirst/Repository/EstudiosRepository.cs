﻿using Senai.InLock.WebApi.DataBaseFirst.Domains;
using Senai.InLock.WebApi.DataBaseFirst.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.DataBaseFirst.Repository
{
    public class EstudiosRepository : IEstudiosRepository
    {
        InLockContext ctx = new InLockContext();

        public Estudio BuscarPorId(int id)
        {
            return ctx.Estudio.FirstOrDefault(e => e.IdEstudio == id);
        }

        public void Cadastrar(Estudio novoEstudio)
        {
            ctx.Estudio.Add(novoEstudio);
            ctx.SaveChanges();
        }

        public List<Estudio> Listar()
        {
            return ctx.Estudio.ToList();
        }
    }
}

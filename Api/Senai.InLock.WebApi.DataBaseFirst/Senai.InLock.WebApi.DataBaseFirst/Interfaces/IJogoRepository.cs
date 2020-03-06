using Senai.InLock.WebApi.DataBaseFirst.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.DataBaseFirst.Interfaces
{
    interface IJogoRepository
    {
        List<Jogo> Listar();

        void Cadastrar(Jogo jogoDomain);

        Jogo BuscarPorId(int id);

        void Deletar(int id);

        void Atualizar(Jogo jogoDomain);



    }
}

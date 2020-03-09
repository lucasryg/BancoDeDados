using Senai.InLock.WebApi.CodeFirst.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.CodeFirst.Interfaces
{
    interface IJogoRepository
    {/// <summary>
    /// Lista com todos os jogos
    /// </summary>
    /// <returns>Uma lista dos jogos</returns>
        List<Jogo> Listar();


        /// <summary>
        /// Cadastra um novo jogo 
        /// </summary>
        /// <param name="jogoDomain"></param>
        void Cadastrar(Jogo jogoDomain);


        /// <summary>
        /// Buscar um jogo por id 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>O jogo buscado pelo id</returns>
        Jogo BuscarPorId(int id);

        /// <summary>
        /// Deleta um jogo pelo id
        /// </summary>
        /// <param name="id"></param>
        void Deletar(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="jogoDomain"></param>
        void Atualizar(Jogo jogoDomain);


        List<Jogo> ListarComEstudios(); 





    }
}

using Microsoft.AspNetCore.Mvc;
using senai.Filmes.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.Filmes.WebApi.Interfaces
{
    interface IFilmeRepository
    {
        /// <summary>
        /// Lista todos os dados que estão dentro do banco de dados
        /// </summary>
        /// <returns>Uma lista com todos os dados</returns>
        List<FilmeDomain> Listar();

        /// <summary>
        /// Cadastra um novo filme
        /// </summary>
        /// <param tabela="filmeDomain"></param>
        void Cadastrar(FilmeDomain filmeDomain);

    }
}

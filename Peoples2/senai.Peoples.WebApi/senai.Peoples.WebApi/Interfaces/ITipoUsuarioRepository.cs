using senai.Peoples.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.Peoples.WebApi.Interfaces
{
    interface ITipoUsuarioRepository
    {
        /// <summary>
        /// Lista os tipo de usuario
        /// </summary>
        /// <returns> lista tipo usuarios </returns>
        List<TipoUsuarioDomain> Listar();

        /// <summary>
        /// Deleta um tipo de usuario pelo Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Um tipo de usuario a menos na sua tabela</returns>
        void Deletar(int id);

        /// <summary>
        /// Cadastra um tipo de usuario novo
        /// </summary>
        /// <returns>Um novo tipo de usuario</returns>
        void Cadastrar(TipoUsuarioDomain tipoUsuarioDomain);

        /// <summary>
        /// Atuliza os tipos de usuario
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tipoUsuarioDomain"></param>
        void Atualizar(int id, TipoUsuarioDomain tipoUsuarioDomain);





    }
}

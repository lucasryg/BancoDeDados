using Microsoft.AspNetCore.Mvc;
using senai.Filmes.WebApi.Domains;
using senai.Filmes.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace senai.Filmes.WebApi.Repositories
{
    public class FilmesRepository : IFilmeRepository
    {

        private string stringConexao = "Data Source=DEV801\\SQLEXPRESS; initial catalog=Filmes_tarde; user Id=sa; pwd=sa@132";


        public List<FilmeDomain> Listar()
        {
            List<FilmeDomain> filmeDomains = new List<FilmeDomain>();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryListar = "select IdFilme, Titulo, IdGenero from Filmes";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(queryListar, con))
                {
                    rdr = cmd.ExecuteReader();

                    while(rdr.Read())
                    {
                        FilmeDomain filme = new FilmeDomain()
                        {

                            IdFilme = Convert.ToInt32(rdr[0]),

                            Titulo = rdr["Titulo"].ToString(),
                            /// O erro está aqui, passar o valor do idGenero, e nao 0s
                            IdGenero = Convert.ToInt32(rdr[filme.IdGenero])
                        };

                        filmeDomains.Add(filme);
                    }
                }
                return filmeDomains;

            }
        }


        public void Cadastrar(FilmeDomain filmeDomain)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {

                string queryCadastrar = "INSERT INTO Filmes(Titulo,IdGenero) VALUES (@Titulo,@IdGenero)";

                using (SqlCommand cmd = new SqlCommand(queryCadastrar, con))
                {
                    con.Open();

                    cmd.Parameters.AddWithValue("@Titulo", filmeDomain.Titulo);

                    cmd.Parameters.AddWithValue("@IdGenero", filmeDomain.IdGenero);

                    cmd.ExecuteNonQuery();

   
                }



            }
          
        }
    }
}

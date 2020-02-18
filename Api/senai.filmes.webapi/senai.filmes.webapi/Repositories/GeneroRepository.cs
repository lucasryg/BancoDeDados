﻿using senai.Filmes.WebApi.Domains;
using senai.Filmes.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace senai.Filmes.WebApi.Repositories
{
    /// <summary>
    /// Repositório dos gêneros
    /// </summary>
    public class GeneroRepository : IGeneroRepository
    {
        /// <summary>
        /// String de conexão com o banco de dados que recebe os parâmetros
        /// Data Source - Nome do Servidor
        /// initial catalog - Nome do Banco de Dados
        /// integrated security=true - Faz a autenticação com o usuário do sistema
        /// user Id=sa; pwd=sa@132 - Faz a autenticação com um usuário específico, passando o logon e a senha
        /// </summary>
        private string StringConexao = "Data Source=DEV801\\SQLEXPRESS; initial catalog=Filmes_tarde; user Id=sa; pwd=sa@132;";

        /// <summary>
        /// Lista todos os gêneros
        /// </summary>
        /// <returns>Retorna uma lista de gêneros</returns>
        public List<GeneroDomain> Listar()
        {
            // Cria uma lista generos onde serão armazenados os dados
            List<GeneroDomain> generos = new List<GeneroDomain>();

            // Declara a SqlConnection passando a string de conexão
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                // Declara a instrução a ser executada
                string query = "SELECT IdGenero, Nome from Generos";

                // Abre a conexão com o banco de dados
                con.Open();

                // Declara o SqlDataReader para percorrer a tabela do banco
                SqlDataReader rdr;

                // Declara o SqlCommand passando o comando a ser executado e a conexão
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Executa a query
                    rdr = cmd.ExecuteReader();

                    // Enquanto houver registros para ler, o laço se repete
                    while (rdr.Read())
                    {
                        // Cria um objeto genero do tipo GeneroDomain
                        GeneroDomain genero = new GeneroDomain
                        {
                            // Atribui à propriedade IdGenero o valor da primeira coluna da tabela do banco
                            IdGenero = Convert.ToInt32(rdr[0]),

                            // Atribui à propriedade Nome o valor da coluna "Nome" da tabela do banco
                            Nome = rdr["Nome"].ToString()
                        };

                        // Adiciona o genero criado à lisa generos
                        generos.Add(genero);
                    }
                }
            }

            // Retorna a lista de generos
            return generos;
        }


        public void Cadastro(GeneroDomain tabelaGeneros)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                //SQL INJECTION
                //string queryInsert = "insert into Generos(Nome) values('" + tabelaGeneros.Nome + "')";
                string queryInsert = "insert into Generos(Nome) values(@Nome)";


                using (SqlCommand cmd = new SqlCommand(queryInsert, con))
                {
                    cmd.Parameters.AddWithValue("@Nome", tabelaGeneros.Nome);
                    con.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public GeneroDomain BuscarPorId(int Id)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string queryBuscarPorId = "select IdGenero from Generos where IdGenero = @ID";

                using (SqlCommand cmd = new SqlCommand(queryBuscarPorId, con))
                {
                    cmd.Parameters.AddWithValue("@ID", Id);

                    con.Open();

                    cmd.ExecuteNonQuery();
                }
                


                if(Id == null)
                {
                   
                }

            }
        }
    }
}
using senai.Peoples.WebApi.Domains;
using senai.Peoples.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace senai.Peoples.WebApi.Repositories
{
    public class TipoUsuariosRepository : ITipoUsuarioRepository
    {

        private string stringConexao = "Data Source=DEV801\\SQLEXPRESS; initial catalog=T_Peoples; user Id=sa; pwd=sa@132"; 


        public void Atualizar(int id, TipoUsuarioDomain tipoUsuarioDomain)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {

                string queryUpdate = "update TipoUsuario set Titulo = @Titulo where IdTipoUsuario = @ID";

                using (SqlCommand cmd = new SqlCommand(queryUpdate, con))
                {
                    cmd.Parameters.AddWithValue("@Titulo", tipoUsuarioDomain.Titulo);

                    cmd.Parameters.AddWithValue("@ID", id);

                    con.Open();

                    cmd.ExecuteNonQuery(); 
                }
            }
        }

        public void Cadastrar(TipoUsuarioDomain tipoUsuarioDomain)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<TipoUsuarioDomain> Listar()
        {
            List<TipoUsuarioDomain> tipoUsuarios = new List<TipoUsuarioDomain>();
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryListar = "select IdTipoUsuario, Titulo from TipoUsuario";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(queryListar, con))
                {
                    rdr = cmd.ExecuteReader();
                    
                    while(rdr.Read())
                    {
                        TipoUsuarioDomain tipoUsuario = new TipoUsuarioDomain
                        {
                            IdTipoUsuario = Convert.ToInt32(rdr["IdTipoUsuario"]),

                            Titulo = rdr["Titulo"].ToString()

                        };
                        tipoUsuarios.Add(tipoUsuario);
                    }
                }
            }
            return tipoUsuarios;
        }
    }
}

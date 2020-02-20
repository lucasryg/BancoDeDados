using Senai.Peoples.WebApi.Domain;
using Senai.Peoples.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.Repository
{
    public class FuncionariosRepository : IFuncionariosRepository
    {
        private string stringConexao = "Data Source=DEV801\\SQLEXPRESS; initial catalog=T_Peoples; user Id=sa; pwd=sa@132";

        public List<FuncionariosDomain> Listar()
        {
            List<FuncionariosDomain> funcionariosDomain = new List<FuncionariosDomain>();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryListar = "select IdFuncionarios, Nome, Sobrenome from Funcionarios";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(queryListar, con))
                {
                    rdr = cmd.ExecuteReader();

                    while(rdr.Read())
                    {
                        FuncionariosDomain funcionarios = new FuncionariosDomain()
                        {

                            IdFuncionarios = Convert.ToInt32(rdr[0]),
                            Nome = rdr["Nome"].ToString(),
                            Sobrenome = rdr["Sobrenome"].ToString()

                        };
                        funcionariosDomain.Add(funcionarios);
                    }
                }
                    return funcionariosDomain;
            }
        }
    }
}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Associados
{
    public class MyDatabase
    {
        public DataTable ObterDados(string ssql)
        {
            using (SqlConnection C = new SqlConnection(Config.SC))
            {
                SqlCommand command = C.CreateCommand();
                command.CommandText = ssql;
                SqlDataAdapter da = new SqlDataAdapter(command);
                var dt = new DataTable();
                da.Fill(dt);
                C.Close();
                return dt;
            }
        }

        public int InserirAssociado(string nome, int ano_nasc, string sexo, bool quota, int atividade_cod)
        {
            using (SqlConnection c = new SqlConnection(Config.SC))
            {
                c.Open();
                string ssql;
                ssql = "INSERT INTO associado " +
                        "(nome, ano_nasc, sexo, quota, atividade_cod) " +
                        "VALUES (@nome, @ano_nasc, @sexo, @quota, @atividade_cod);";

                SqlCommand comando = new SqlCommand(ssql, c);

                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@ano_nasc", ano_nasc);
                comando.Parameters.AddWithValue("@sexo", sexo);
                comando.Parameters.AddWithValue("@quota", quota);
                comando.Parameters.AddWithValue("@atividade_cod", atividade_cod);

                try
                {
                    comando.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    return 1;
                }
                return 0;

            }

            
        }


    }
}

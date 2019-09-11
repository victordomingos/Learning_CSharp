using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OsMeusQueridosPostais
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

        public int InserirRegistoViagem(int veiculo_id, int condutor_id, double distancia, string data_hora)
        {
            using (SqlConnection c = new SqlConnection(Config.SC))
            {
                c.Open();
                string ssql;
                ssql = "INSERT INTO viagem " +
                       "(veiculo_id, condutor_id, distancia, data) " +
                       "VALUES (@veiculo_id, @condutor_id, @distancia, @data_hora);";

                SqlCommand comando = new SqlCommand(ssql, c);

                comando.Parameters.AddWithValue("@veiculo_id", veiculo_id);
                comando.Parameters.AddWithValue("@condutor_id", condutor_id);
                comando.Parameters.AddWithValue("@distancia", distancia);
                comando.Parameters.AddWithValue("@data_hora", data_hora);


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

        public int EliminarRegistoViagem(int id)
        {
            using (SqlConnection c = new SqlConnection(Config.SC))
            {
                c.Open();
                
                string ssql = "DELETE FROM viagem WHERE id = @id";
                SqlCommand comando = new SqlCommand(ssql, c);

                comando.Parameters.AddWithValue("@id", id);
                
                try
                {
                    int result = comando.ExecuteNonQuery();
                    MessageBox.Show(result.ToString());
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

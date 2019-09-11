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

        public DataTable InserirRegistoOferta(int codigo, string data_hora, int oferecedor, int recetor, int postal)
        {
            string ssql = "UPDATE oferta " +
                          $"    SET data_hora='{data_hora}', oferecedor={oferecedor}, recetor={recetor}, postal={postal} " +
                          $"    WHERE codigo={codigo} " +
                          "IF @@ROWCOUNT=0 " +
                          "     INSERT INTO oferta(data_hora, oferecedor, recetor, postal) " +
                          $"    VALUES ('{data_hora}', {oferecedor}, {recetor}, {postal});";
            return ObterDados(ssql);
        }

        public int EliminarRegistoOferta(int codigo)
        {
            using (SqlConnection c = new SqlConnection(Config.SC))
            {
                c.Open();
                
                string ssql = "DELETE FROM oferta WHERE codigo = @codigo";
                SqlCommand comando = new SqlCommand(ssql, c);

                comando.Parameters.AddWithValue("@codigo", codigo);
                
                try
                {
                    int result = comando.ExecuteNonQuery();
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

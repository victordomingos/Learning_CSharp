using System;
using System.Data;
using System.Data.SqlClient;


namespace Frota
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
                var dt = new System.Data.DataTable();
                da.Fill(dt);
                C.Close();
                return dt;
            }
        }

        public int InserirRegistoViagem(int veiculo_id, int condutor_id, float distancia, DateTime data)
        {
            using (SqlConnection c = new SqlConnection(Config.SC))
            {

                //C.Open();
                //string ssql;
                //ssql = "INSERT INTO T_registo_de_tempos " +
                //       "(cod_cliente, cod_funcionario, data, tempo, descritivo, categoria) " +
                //       "VALUES (@cod_cliente, @cod_funcionario, @data, @tempo, @descritivo, @categoria);";

                //SqlCommand comando = new SqlCommand(ssql, C);

                //comando.Parameters.AddWithValue("@cod_cliente", cod_cliente);
                //comando.Parameters.AddWithValue("@cod_funcionario", cod_funcionario);
                //comando.Parameters.AddWithValue("@data", data);
                //comando.Parameters.AddWithValue("@tempo", minutos);
                //comando.Parameters.AddWithValue("@descritivo", descritivo);
                //comando.Parameters.AddWithValue("@categoria", categoria);
                //try
                //{
                //    comando.ExecuteNonQuery();
                //}
                //catch (Exception)
                //{
                //    return 1;
                //}
                //return 0;





                //          INSERT INTO[dbo].[viagem]
                //  ([veiculo_id]
                //      ,[condutor_id]
                //      ,[distancia]
                //      ,[data])
                //VALUES
                //      (<veiculo_id, int,>
                //     ,<condutor_id, int,>
                //     ,<distancia, numeric(9,1),>
                //     ,<data, datetime,>)

            }

            return 0;
        }
}
}

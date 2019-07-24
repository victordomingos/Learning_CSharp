using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace appRT
{
    public class MyGetData
    {
        // Permite obter dados da base de dados, passando como argumentos
        // a connection string e uma string com o comand sql a executar.
        public DataTable BuscaDados(string SC, string ssql)
        {
            // Criar ligação à base de dados:
            using (SqlConnection C = new SqlConnection(SC))
            {
                // Criar comando SQL para extração de dados:
                SqlCommand command = C.CreateCommand();
                command.CommandText = ssql;

                // trazer os dados para uma tabela em memória:
                SqlDataAdapter da = new SqlDataAdapter(command);
                var dt = new DataTable();
                da.Fill(dt);

                C.Close();
                return dt;
            }
        }

        public int ContarTotalRegistos()
        {
            DataTable dt = BuscaDados(SConnection.SC, "SELECT COUNT(Id) from T_registo_de_tempos;");
            return Convert.ToInt32(dt.Rows[0][0]);
        }

        public int ContarRegistosEsteAno()
        {
            DataTable dt = BuscaDados(SConnection.SC, 
                "SELECT COUNT(Id) from T_registo_de_tempos " +
                "WHERE YEAR(data) = YEAR(GETDATE());");

            return Convert.ToInt32(dt.Rows[0][0]);
        }

        public int ContarRegistosEsteMes()
        {
            DataTable dt = BuscaDados(SConnection.SC,
                "SELECT COUNT(Id) from T_registo_de_tempos " +
                "WHERE YEAR(data) = YEAR(GETDATE())" +
                "AND MONTH(data) = MONTH(GETDATE());");

            return Convert.ToInt32(dt.Rows[0][0]);
        }


        public int ContarRegistosClienteEsteMes(int cod_cliente)
        {
            DataTable dt = BuscaDados(SConnection.SC,
               "SELECT COUNT(Id) from T_registo_de_tempos " +
               $"WHERE cod_cliente = '{cod_cliente}'" +
               "AND YEAR(data) = YEAR(GETDATE())" +
               "AND MONTH(data) = MONTH(GETDATE());");

            return Convert.ToInt32(dt.Rows[0][0]);
        }


        public int ContarRegistosFuncEsteMes(int cod_funcionario)
        {
            DataTable dt = BuscaDados(SConnection.SC,
               "SELECT COUNT(Id) from T_registo_de_tempos " +
               $"WHERE cod_funcionario = '{cod_funcionario}'" +
               "AND YEAR(data) = YEAR(GETDATE())" +
               "AND MONTH(data) = MONTH(GETDATE());");

            return Convert.ToInt32(dt.Rows[0][0]);
        }


        // contar minutos todos do cliente, apenas do mês atual
        public int ContarMinutosClienteEsteMes(int cod_cliente)
        {
            int minutos;

            DataTable dt = BuscaDados(SConnection.SC,
                "SELECT SUM(tempo) FROM T_registo_de_tempos " +
                "WHERE YEAR(data)=YEAR(CURRENT_TIMESTAMP) " +
                "AND MONTH(data)=MONTH(CURRENT_TIMESTAMP) " +
                $"AND cod_cliente='{cod_cliente}';");

            try
                { minutos = Convert.ToInt32(dt.Rows[0][0]); }
            catch (Exception)
                { minutos = 0; }

            return minutos;
        }

        // contar minutos todos do funcionario, apenas do mês atual
        public int ContarMinutosFuncEsteMes(int cod_funcionario)
        {
            int minutos_func_mes;

            DataTable dt = BuscaDados(SConnection.SC, 
                "SELECT SUM(tempo) FROM T_registo_de_tempos " +
                "WHERE YEAR(data)=YEAR(CURRENT_TIMESTAMP) " +
                "AND MONTH(data)=MONTH(CURRENT_TIMESTAMP) " +
                $"AND cod_funcionario='{cod_funcionario}';");

            try
                { minutos_func_mes = Convert.ToInt32(dt.Rows[0][0]); }
            catch (Exception)
                { minutos_func_mes = 0; }

            return minutos_func_mes;
        }

        public int InserirRegistoTempo(string cod_cliente, string cod_funcionario, string data, int minutos, string descritivo, string categoria)
        {
            using (SqlConnection C = new SqlConnection(SConnection.SC))
            {
                C.Open();
                string ssql;
                ssql = "INSERT INTO T_registo_de_tempos " +
                       "(cod_cliente, cod_funcionario, data, tempo, descritivo, categoria) " +
                       "VALUES (@cod_cliente, @cod_funcionario, @data, @tempo, @descritivo, @categoria);";

                SqlCommand comando = new SqlCommand(ssql, C);

                MessageBox.Show(data);
                comando.Parameters.AddWithValue("@cod_cliente", cod_cliente);
                comando.Parameters.AddWithValue("@cod_funcionario", cod_funcionario);
                comando.Parameters.AddWithValue("@data", data);
                comando.Parameters.AddWithValue("@tempo", minutos);
                comando.Parameters.AddWithValue("@descritivo", descritivo);
                comando.Parameters.AddWithValue("@categoria", categoria);
                try
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show(comando.CommandText, "SQL Query B:");
                }
                catch (Exception)
                {

                    throw;
                }
                return 0;
            }
        }
    }
}

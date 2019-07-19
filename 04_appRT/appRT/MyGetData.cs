using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace appRT
{
    public class MyGetData
    {
        // Permite obter dados da base de dados, passando como argumentos
        // a string connection e uma string com o comand sql a executar.
        public DataTable BuscaDados(string SC, string ssql)
        {
            // Criar ligação à base de dados:
            SqlConnection C = new SqlConnection(SC);
            C.Open();

            // Criar comando SQL para extração de dados:
            SqlCommand command = C.CreateCommand();
            // command.CommandText = "SELECT nome_cliente from T_clientes";
            command.CommandText = ssql;

            // trazer os dados para uma tabela em memória:
            SqlDataAdapter da = new SqlDataAdapter(command);
            var dt = new DataTable();
            da.Fill(dt);

            // Fechar a ligação:
            C.Close();
            return dt;
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

        public int InserirRegistoTempo(string cod_cliente, string cod_funcionario, string data, int minutos, string descritivo, string categoria)
        {
            string ssql;
            /* //Exemplo:
             string query = "INSERT INTO ArticlesTBL (ArticleTitle, ArticleContent, ArticleType, ArticleImg, ArticleBrief,  
                ArticleDateTime, ArticleAuthor, ArticlePublished, ArticleHomeDisplay, ArticleViews)";

            query += " VALUES (@ArticleTitle, @ArticleContent, @ArticleType, @ArticleImg, @ArticleBrief, 
                                @ArticleDateTime, @ArticleAuthor, @ArticlePublished, @ArticleHomeDisplay, @ArticleViews)";

            SqlCommand myCommand = new SqlCommand(query, myConnection);
            myCommand.Parameters.AddWithValue("@ArticleTitle", ArticleTitleTextBox.Text);
            myCommand.Parameters.AddWithValue("@ArticleContent", ArticleContentTextBox.Text);
            // ... other parameters
            myCommand.ExecuteNonQuery();
            */


            ssql = "INSERT INTO T_registo_de_tempos (cod_cliente, cod_funcionario, data, minutos, descritivo, categoria) ";

            ssql += "VALUES (@cod_cliente, @cod_funcionario, @data, @minutos, @descritivo, @categoria";

            SqlConnection C = new SqlConnection(SC);
            C.Open();
            SqlCommand comando = new SqlCommand(ssql, C);

            comando.Parameters.AddWithValue("@cod_cliente", cod_cliente);

            $"'{cod_cliente}','{cod_funcionario}','{data}', {minutos}, " +
                   $"'{descritivo}', '{categoria}')";

            MessageBox.Show(ssql, "SQL Query:");
            return 0;
        }
    }
}

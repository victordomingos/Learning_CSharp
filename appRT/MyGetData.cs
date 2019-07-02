using System.Data;
using System.Data.SqlClient;

namespace appRT
{
    class MyGetData
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
    }
}

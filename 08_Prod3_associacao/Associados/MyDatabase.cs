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




    }
}

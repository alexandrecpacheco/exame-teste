using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace MovimentosManuais.DAL
{
    public class MovimentosManuaisHelper
    {
        DataTable dt;
        SqlDataAdapter ad;

        private static string _conexao
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            }
        }

        public static SqlConnection GetConnection()
        {
            var connection = new SqlConnection(_conexao);

            if (connection.State == ConnectionState.Open)
                connection.Close();
            else
                connection.Open();

            return connection;
        }

        
        public DataTable getData(string str)
        {
            ad = new SqlDataAdapter(str, MovimentosManuaisHelper.GetConnection());
            dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }

        public static bool DML(SqlCommand cmd)
        {
            int result = 0;
            using (GetConnection())
            {

                using (cmd)
                {
                    cmd.Connection = GetConnection();
                    result = cmd.ExecuteNonQuery();
                }
            }

            if (result > 0)
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        public DataTable GetAll(SqlCommand cmd)
        {
            ad = new SqlDataAdapter();
            DataTable dt = new DataTable();

            using (GetConnection())
            {

                using (cmd)
                {
                    cmd.Connection = GetConnection();
                    ad.SelectCommand = cmd;

                    ad.Fill(dt);
                }
            }

            return dt;
        }

    }
}

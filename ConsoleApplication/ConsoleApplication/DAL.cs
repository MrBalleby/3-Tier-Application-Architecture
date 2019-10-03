using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_Layer
{
    public class Dal
    {
        private string conn = ConfigurationManager.ConnectionStrings["CON"].ToString();

        public void InsertUpdateDeleteSQLString(string sqlstring)
        {
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlstring, con);
            cmd.ExecuteNonQuery();

        }

        public object ExecuteSqlString(string sqlstring)
        {
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand(sqlstring, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
        }


    }
}

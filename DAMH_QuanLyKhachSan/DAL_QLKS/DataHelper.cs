using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAMH_QuanLyKhachSan.DAL_QLKS
{
    class DataHelper
    {
        SqlConnection con = null;
        public DataHelper()
        {
            con = new SqlConnection("Data Source=DELL\\SQLEXPRESS;Initial Catalog=QLKHACHSAN;Integrated Security=True");
        }

        public DataTable execeuteQuery(string query)
        {
            DataTable table = new DataTable();
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(table);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
            return table;
        }

        public void executeNonQuery(string query)
        {
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con != null)
                    con.Close();
                if (cmd != null)
                    cmd.Dispose();
            }
        }
    }
}

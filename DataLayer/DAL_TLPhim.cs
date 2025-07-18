using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DAL_TLPhim : DataProvider
    {
        public DataTable GetAllTLPhim()
        {
            Connect();
            SqlDataAdapter da = new SqlDataAdapter("SELECT id_the_loai, ten FROM THELOAIPHIM", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Disconnect();
            return dt;
        }

    }
}

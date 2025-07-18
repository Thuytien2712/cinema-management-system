using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DAL_DDPhim : DataProvider
    {
        public DataTable GetAllDDPhim()
        {
            Connect();
            SqlDataAdapter da = new SqlDataAdapter("SELECT id_dinh_dang, ten FROM DINHDANGPHIM", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Disconnect();
            return dt;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class LoaiDoAnDL : DataProvider
    {
        public string GetIdLoaiByTen(string ten)
        {
            string sql = "sp_GetIdLoaiByTen";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                 new SqlParameter("@ten", ten)
            };

            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(parameters.ToArray());

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return reader["id_loai"].ToString();
                }
                return null;
            }
            finally
            {
                Disconnect();
            }
        }
    }
}

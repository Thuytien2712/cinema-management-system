using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DataProvider
    {
        protected SqlConnection cn;
        public DataProvider()
        {
            string cnStr = "Data Source=THUYTIEN;Initial Catalog=QLYRAPCHIEUPHIM_3;Integrated Security=True;TrustServerCertificate=True";
            cn = new SqlConnection(cnStr);

        }
        public void Connect()
        {
            try
            {
                if (cn != null && cn.State == System.Data.ConnectionState.Closed)
                {
                    cn.Open();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void Disconnect()
        {
            try
            {
                if (cn != null && cn.State == System.Data.ConnectionState.Open)
                {
                    cn.Close();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public object MyExcuteScaler(string sql, CommandType type)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = type;

                return (cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Disconnect();
            }

        }

        public SqlDataReader MyExcuteReader(string sql, CommandType type)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = type;
                return cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}

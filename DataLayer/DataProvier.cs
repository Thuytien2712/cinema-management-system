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
            //string cnStr = "Data Source=DESKTOP-9VDD5KO\\OMIYO;Initial Catalog=RAPCHIEUPHIM;Integrated Security=True;Encrypt=False";
            string cnStr = "Data Source=.;Initial Catalog=RAPCHIEUPHIM;Integrated Security=True;Encrypt=False";
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
        //public object MyExcuteScalar(string sql, CommandType type)
        //{
        //    try
        //    {
        //        Connect();
        //        SqlCommand cmd = new SqlCommand(sql, cn);
        //        cmd.CommandType = type;

        //        return (cmd.ExecuteScalar());
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        Disconnect();
        //    }
        //}

        public object MyExecuteScalar_1(string sql, CommandType type, List<SqlParameter> parameters = null)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = type;
                if (parameters != null)
                {
                    foreach (var p in parameters)
                    {
                        cmd.Parameters.Add(p);
                    }
                }

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

        public SqlDataReader MyExecuteReader(string sql, CommandType type)
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

        public int MyExecuteNonQuery(string sql, CommandType type, List<SqlParameter> parameters)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = type;

                foreach (SqlParameter parameter in parameters)
                {
                    cmd.Parameters.Add(parameter);
                }

                return cmd.ExecuteNonQuery();

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
    }
}

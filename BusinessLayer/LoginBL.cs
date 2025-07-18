using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using TransferObject;

namespace BusinessLayer
{
    public class LoginBL
    {
        private LoginDL loginDL;

        public LoginBL()
        {
            loginDL = new LoginDL();
        }

        public Account LoginWithRole(Account account)
        {
            try
            {
                return loginDL.Login(account);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        
    }
}

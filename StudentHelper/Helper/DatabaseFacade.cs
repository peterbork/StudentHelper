using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StudentHelper.Helper
{
    static class DatabaseFacade
    {
        private static string _connect = "Server=ealdb1.eal.local;" + "Database=EJL100_DB;" + "User Id=ejl100_usr;" + "Password=Baz1nga100";

        public static void CreateHomeWork(int UserID, DateTime Date, string Description, string Class)
        {
            SqlConnection connect = new SqlConnection(_connect);
            try
            {
                connect.Open();

                SqlCommand sqlCmd = new SqlCommand("SH_CreateHomework", connect);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Add(new SqlParameter("@UserId", UserID));
                sqlCmd.Parameters.Add(new SqlParameter("@Date", Date));
                sqlCmd.Parameters.Add(new SqlParameter("@Description", Description));
                sqlCmd.Parameters.Add(new SqlParameter("@Class", Class));
                sqlCmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                connect.Close();
                connect.Dispose();
            }
        }

    }
}

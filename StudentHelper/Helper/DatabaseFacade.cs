using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using StudentHelper.Model;

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

        public static void CreateEvent(int UserID, DateTime Date, string Description, string Type, string Location, DateTime StartDate)
        {
            SqlConnection connect = new SqlConnection(_connect);
            try
            {
                connect.Open();

                SqlCommand sqlCmd = new SqlCommand("SH_CreateEvent", connect);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Add(new SqlParameter("@UserId", UserID));
                sqlCmd.Parameters.Add(new SqlParameter("@Date", Date));
                sqlCmd.Parameters.Add(new SqlParameter("@Description", Description));
                sqlCmd.Parameters.Add(new SqlParameter("@Type", Type));
                sqlCmd.Parameters.Add(new SqlParameter("@Location", Location));
                sqlCmd.Parameters.Add(new SqlParameter("@StartDate", StartDate));
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

        public static List<User> GetUsers()
        {
            SqlConnection connect = new SqlConnection(_connect);
            List<User> Users = new List<User>();

            try
            {
                connect.Open();
                SqlCommand sqlCmd = new SqlCommand("SH_GetUser", connect);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    Users.Add(new User(Convert.ToString(reader["ID"]), Convert.ToString(reader["Name"])));
                }
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
            return Users;
        }

        public static Dictionary<Event, Homework> GetWeeklySchedule(string userId, DateTime StartDate, DateTime EndDate) {
            Dictionary<Event, Homework> tempEHDictionary = new Dictionary<Event, Homework>();
            
            SqlConnection connect = new SqlConnection(_connect);

            try {
                connect.Open();

                SqlCommand sqlCmd = new SqlCommand("phil2452_SP_GetMalt", connect);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                sqlCmd.Parameters.Add("@UserId", userId);
                sqlCmd.Parameters.Add("@StartDate", StartDate);
                sqlCmd.Parameters.Add("@EndDate", EndDate);

                SqlDataReader reader = sqlCmd.ExecuteReader();

                if (reader.HasRows) {
                    while (reader.Read()) {
                        Event EVENT = new Event(""+reader["Type"], ""+reader["Location"], DateTime.Parse(""+reader["StartDate"]), ""+reader["ID"], ""+reader["Description"], userId, DateTime.Parse(""+reader["Date"]);
                        Homework homework = new Homework(""+reader["Class"], ""+reader["ID"], ""+reader["Description"], userId, DateTime.Parse(""+reader["Date"]));
                        
                        tempEHDictionary.Add(EVENT, homework);
                    }
                }

            } catch (Exception e) {
                throw e;
            } finally {
                connect.Close();
                connect.Dispose();
            }
            return Users;
        }

    }
}

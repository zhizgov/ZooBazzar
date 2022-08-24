using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using MySql.Data.MySqlClient;


namespace DataAccessLayer
{
    public class VacationsDB : IVacations
    {
        private MySqlConnection conn;

        public VacationsDB()
        {
            conn = ConnectionDB.GetConnection();
        }
        public void AcceptVacation(Vacation vacation)
        {
            try
            {
                string sql = "UPDATE vacations SET Status=@Status WHERE RequestID=@ID";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@ID", vacation.ID);
                cmd.Parameters.AddWithValue("@Status", "Accepted");

                if (cmd.ExecuteNonQuery()!=1)
                {
                    throw new Exception("Vacation was not accepted");
                }
            }
            catch (MySqlException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public void DenyVacation(Vacation vacation)
        {
            try
            {
                string sql = "UPDATE vacations SET Status=@Status WHERE RequestID=@ID";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@ID", vacation.ID);
                cmd.Parameters.AddWithValue("@Status", "Denied");

                if (cmd.ExecuteNonQuery()!=1)
                {
                    throw new Exception("Vacation was not denied");
                }
            }
            catch (MySqlException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }



        public List<Vacation> ReadCurrentVacations()
        {
            List<Vacation> vacations = new List<Vacation>();
            try
            {
                string sql = "Select RequestID, EmployeeID, StartDate, EndDate, Status FROM vacations WHERE Status=@Status AND CURRENT_DATE() BETWEEN StartDate AND EndDate";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Status", "Accepted");
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();




                while (dr.Read())
                {
                    vacations.Add(new Vacation(Convert.ToInt32(dr["RequestID"]), Convert.ToInt32(dr["EmployeeID"]), dr["Username"].ToString(), Convert.ToDateTime(dr["StartDate"]), Convert.ToDateTime(dr["EndDate"])));
                }
            }
            catch (MySqlException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }

            return vacations;
        }

        public List<Vacation> ReadRequests()
        {
            List<Vacation> vacations = new List<Vacation>();
            try
            {
                string sql = "Select RequestID, Username, EmployeeID, StartDate, EndDate, Status FROM vacations WHERE Status=@Status AND CURRENT_DATE() <= StartDate";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Status", "Awaiting");
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    vacations.Add(new Vacation(Convert.ToInt32(dr["RequestID"]), Convert.ToInt32(dr["EmployeeID"]), dr["Username"].ToString(), Convert.ToDateTime(dr["StartDate"]), Convert.ToDateTime(dr["EndDate"])));
                }
            }
            catch (MySqlException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }

            return vacations;
        }

        public void RequestVacation(Vacation vacation)
        {
            try
            {
                string sql = "INSERT INTO vacations (EmployeeID, Username, StartDate, EndDate, Status) VALUES (@EmployeeID, @Username, @StartDate, @EndDate, @Status)";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@EmployeeID", vacation.EmployeeID);
                cmd.Parameters.AddWithValue("@Username", vacation.Username);
                cmd.Parameters.AddWithValue("@StartDate", vacation.StartDate);
                cmd.Parameters.AddWithValue("@EndDate", vacation.EndDate);
                cmd.Parameters.AddWithValue("@Status", "Awaiting");


                if (cmd.ExecuteNonQuery()!=1)
                {
                    throw new Exception("Vacation request not sent successfully");
                }
            }
            catch (MySqlException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}

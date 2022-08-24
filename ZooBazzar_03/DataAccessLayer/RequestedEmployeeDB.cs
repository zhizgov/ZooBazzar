using Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class RequestedEmployeeDB : IRequestDB<RequestedEmployee>
    {
        private MySqlConnection conn;

        public RequestedEmployeeDB()
        {
            conn = ConnectionDB.GetConnection();
        }
        public void Add(RequestedEmployee obj)
        {
            string sql = "INSERT INTO requested_employee (ID,FirstName,LastName,Adress,Birthdate,Phone,Email,EmergencyContact,BSN) VALUES (@ID,@FirstName,@LastName,@Adress,@Birthdate,@Phone,@Email,@EmergencyContact,@BSN)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = obj.Id;
            cmd.Parameters.Add("@FirstName", MySqlDbType.VarChar).Value = obj.Name;
            cmd.Parameters.Add("@LastName", MySqlDbType.VarChar).Value = obj.Lastname;
            cmd.Parameters.Add("@Adress", MySqlDbType.VarChar).Value = obj.Address;
            cmd.Parameters.Add("@BirthDate", MySqlDbType.DateTime).Value = obj.Birthdate;
            cmd.Parameters.Add("@Phone", MySqlDbType.VarChar).Value = obj.Phone;
            cmd.Parameters.Add("@EmergencyContact", MySqlDbType.VarChar).Value = obj.EmargencyContact;
            cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = obj.Email;
            cmd.Parameters.Add("@BSN", MySqlDbType.VarChar).Value = obj.Bsn;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }



        public void Delete(int id)
        {
            string sql = "DELETE FROM requested_employee WHERE ID = @ID";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally { conn.Close(); }
        }


        public List<RequestedEmployee> Read()
        {
            string sql = "SELECT * FROM requested_employee";
            List<RequestedEmployee> employees = new List<RequestedEmployee>();
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                RequestedEmployee re;

                while (reader.Read())
                {

                    re = new RequestedEmployee(reader.GetInt32("id"),
                         reader.GetString("FirstName"),
                         reader.GetString("LastName"),
                         reader.GetString("Adress"),
                         reader.GetDateTime("BirthDate"),
                         reader.GetString("Email"),
                         reader.GetString("Phone"),
                         reader.GetString("EmergencyContact"),
                         reader.GetString("BSN"));
                    employees.Add(re);
                }
                return employees;
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Error during reading the data in accounts! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return employees;
        }

        public void ChangeCredentials(RequestedEmployee obj)
        {
            string sql = "UPDATE employee SET FirstName = @FirstName,LastName = @Lastname,Address = @Address,Birthdate = @Birthdate,Phone = @Phone,EmergencyContact = @EmergencyContact WHERE ID = @ID ";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@FirstName", MySqlDbType.VarChar).Value = obj.Name;
                cmd.Parameters.Add("@LastName", MySqlDbType.VarChar).Value = obj.Lastname;
                cmd.Parameters.Add("@Address", MySqlDbType.VarChar).Value = obj.Address;
                cmd.Parameters.Add("@BirthDate", MySqlDbType.DateTime).Value = obj.Birthdate;
                cmd.Parameters.Add("@Phone", MySqlDbType.VarChar).Value = obj.Phone;
                cmd.Parameters.Add("@EmergencyContact", MySqlDbType.VarChar).Value = obj.EmargencyContact;
                cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = obj.Email;
                cmd.Parameters.Add("@BSN", MySqlDbType.VarChar).Value = obj.Bsn;
                cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = obj.Id;
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {

                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }



    }
}

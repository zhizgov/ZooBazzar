using Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CustomerDB: ICustomerDB
    {
        private MySqlConnection conn;

        public CustomerDB()
        {
            conn = ConnectionDB.GetConnection();
        }

        public Customer GetCustomer(int id)
        {
            try
            {
                string sql = "SELECT * FROM customer where id=@id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = cmd.ExecuteReader();

                Customer customer;
                while (reader.Read())
                {
                    customer = new Customer(Convert.ToInt32(reader["id"]), reader["email"].ToString(), reader["firstname"].ToString(), reader["lastname"].ToString());
                    return customer;
                }
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally
            {

                conn.Close();
            }
            return null;
        }

        public List<Customer> GetCustomers()
        {
            string sql = "SELECT * from customer";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                List<Customer> customers = new List<Customer>();


                while (reader.Read())
                {
                    customers.Add(new Customer(Convert.ToInt32(reader["id"]), reader["email"].ToString(), reader["firstname"].ToString(), reader["lastname"].ToString()));

                }
                return customers;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {

                conn.Close();
            }
            return null;
        }
    }
}

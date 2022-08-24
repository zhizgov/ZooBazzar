using Entities;
using MySql.Data.MySqlClient;
using System.Data;


namespace DataAccessLayer
{
    public class SubscriptionDB : ISubscription
    {
        private string sql;
        MySqlConnection conn;

        public SubscriptionDB()
        {
            conn = ConnectionDB.GetConnection();
        }

        public void Add(Subscription obj)
        {
            sql = "INSERT INTO subscription (cust_id,type,startDate,endDate) VALUES (@Cust_id,@Type,@StartDate,@EndDate)";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@Cust_id", MySqlDbType.Int32).Value = obj.CustomerId;
            cmd.Parameters.Add("@Type", MySqlDbType.VarChar).Value = obj.SubscriptionType.ToString();
            cmd.Parameters.Add("@StartDate", MySqlDbType.DateTime).Value = obj.StartDate;
            cmd.Parameters.Add("@EndDate", MySqlDbType.DateTime).Value = obj.EndDate;

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

        public List<Subscription> GetSubscriptions(int customerId)
        {
            string sql = "SELECT * FROM subscription WHERE CURRENT_Date < endDate AND cust_id = @Cust_id ";
            List<Subscription> subscriptions = new List<Subscription>();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@Cust_id", MySqlDbType.Int32).Value = customerId;

            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Subscription temp = new Subscription(Convert.ToInt32(reader[0]), Convert.ToInt32(reader[1]), Convert.ToDateTime(reader[3]), Convert.ToDateTime(reader[4]), TypeSubscription.GetTypesSubscription.Find(s => s.ToString() == reader[2].ToString()));
                    subscriptions.Add(temp);
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

            return subscriptions;
        }


    }
}

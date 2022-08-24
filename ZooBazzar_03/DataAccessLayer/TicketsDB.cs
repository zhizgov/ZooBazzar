using Entities;
using MySql.Data.MySqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class TicketsDB : ICRU<Ticket>, IAutoIncrementable
    {
        //Fields
        private string sql;
        private MySqlConnection conn;

        //Constructor
        public TicketsDB()
        {
            conn = ConnectionDB.GetConnection();
        }

        //Methods
        public void Add(Ticket obj)
        {
            string sql = "INSERT INTO ticket (id,cust_id,typeTicket,date,dateOfPerchese,isUsed,placeOfPurchase,price,dateOfUse) VALUES (@ID,@Cust_ID,@TypeTicket,@Date,@DateOfPerchase,@IsUsed,@PlaceOfPerchase,@Price,@DateOfUse)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = obj.Id;
            
            if(obj.Customer == null)
            {
              cmd.Parameters.Add("@Cust_ID", MySqlDbType.Int32).Value = null;

            }
            else
            {
                cmd.Parameters.Add("@Cust_ID", MySqlDbType.Int32).Value = obj.Customer.Id;
            }
            cmd.Parameters.Add("@TypeTicket", MySqlDbType.VarChar).Value = obj.TypeOfTicket;
            cmd.Parameters.Add("@Date", MySqlDbType.DateTime).Value = obj.Date;
            cmd.Parameters.Add("@DateOfPerchase", MySqlDbType.DateTime).Value = obj.DateOfPurchase;
            cmd.Parameters.Add("@isUsed", MySqlDbType.Int16).Value = obj.IsUsed;
            cmd.Parameters.Add("@PlaceOfPerchase", MySqlDbType.VarChar).Value = obj.PlaceOfPerchase;
            cmd.Parameters.Add("@Price", MySqlDbType.Decimal).Value = obj.Price;
            cmd.Parameters.Add("@DateOfUse", MySqlDbType.DateTime).Value = obj.DateOfUse;

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

        public int GetNexID()
        {
            try
            {
                string sql = "SELECT AUTO_INCREMENT FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbi481796' AND TABLE_NAME = 'ticket';";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                int result = Convert.ToInt32(cmd.ExecuteScalar());

                return result;
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

        public List<Ticket> Read()
        {
            string sql = "SELECT t.id,typeTicket,date,dateOfPerchese,placeOfPurchase,price,isUsed,dateOfUse,c.id,email,firstname,lastname FROM `ticket` as t LEFT JOIN customer as c on t.cust_id = c.id";
            List<Ticket> tickets = new List<Ticket>();
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Customer? customer;
                    DateTime? date;
                    DateTime? dateOfUse;
                    if (reader[2] == DBNull.Value)
                    {
                        date = null;
                    }
                    else
                    {
                        date = Convert.ToDateTime(reader[2]);
                    }

                    if (reader[8] == DBNull.Value)
                    {
                        customer = null;
                    }
                    else
                    {
                        customer = new Customer(Convert.ToInt32(reader[8]), reader[9].ToString(), reader[10].ToString(), reader[11].ToString());
                    }


                    if (reader[7] == DBNull.Value)
                    {
                        dateOfUse = null;
                    }
                    else
                    {
                        dateOfUse = Convert.ToDateTime(reader[7]);
                    }
                    TypeOfTicket typeOfTicket = (TypeOfTicket)Enum.Parse(typeof(TypeOfTicket), reader[1].ToString(), true);
                    PlaceOfPerchase placeOfPerchase = (PlaceOfPerchase)Enum.Parse(typeof(PlaceOfPerchase), reader[4].ToString(), true);
                    Ticket ticket = new Ticket(Convert.ToInt32(reader[0]), customer, typeOfTicket, date, Convert.ToDateTime(reader[3]), placeOfPerchase, Convert.ToDecimal(reader[5]), Convert.ToBoolean(reader[6]), dateOfUse);
                    tickets.Add(ticket);
                }
                return tickets;
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

        public void Update(Ticket obj)
        {
            string sql = "UPDATE ticket SET isUsed = @isUsed, DateOfUse = CURRENT_TIMESTAMP WHERE id = @id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("id", obj.Id);
            cmd.Parameters.AddWithValue("isUsed", true);


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
    }
}

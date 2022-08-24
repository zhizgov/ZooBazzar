using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using MySql.Data.MySqlClient;
using MySql.Data;
namespace DataAccessLayer
{
    public class ComplaintsDB : IComplaints<Complaint>
    {

        private MySqlConnection conn;

        public ComplaintsDB()
        {
            conn = ConnectionDB.GetConnection();
        }


        public void AddComplaint(Complaint complaint)
        {
            try
            {
                string sql = "INSERT INTO compaints(Title, Description, Time, AuthorID) VALUES (@Title, @Description, @Time, @AuthorID)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@Title", complaint.Title);
                cmd.Parameters.AddWithValue("@Description", complaint.Description);
                cmd.Parameters.Add("@Time", MySqlDbType.Datetime).Value = complaint.Time;
                cmd.Parameters.AddWithValue("@AuthorID", complaint.Author.Id);

                if (cmd.ExecuteNonQuery()!=1)
                {
                    throw new Exception("Complaint was not added");
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Complaint> ReadComplaints()
        {
            List<Complaint> complaints = new List<Complaint>();

            try
            {
                string sql = "SELECT AccountID, Username, ComplaintID, Title, Description, Time, AuthorID FROM account a INNER JOIN compaints c ON a.AccountID=c.AuthorID;";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    complaints.Add(new Complaint(Convert.ToInt32(dr["AuthorID"]), new Account(Convert.ToInt32(dr["AccountID"]), dr["Username"].ToString()), dr["Title"].ToString(), dr["Description"].ToString(), dr.GetDateTime("Time")));
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            

            return complaints;
        }
    }
}

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
    public class ZooDescriptionDB : IZooDescription<ZooDescription>, IAutoIncrementable
    {
        private MySqlConnection conn;
        public ZooDescriptionDB()
        {
            conn = ConnectionDB.GetConnection();
        }
        public void AddDescription(ZooDescription zd)
        {
            string sql = "INSERT INTO description (description, isActive, dateOfCreation) VALUES(@description, @isActive, @dateOfCreation);";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@description", zd.Description);
            cmd.Parameters.AddWithValue("@isActive", zd.IsActive);
            cmd.Parameters.AddWithValue("@dateOfCreation", zd.DateOfCreation);
            try
            {

                conn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

                conn.Close();
            }
        }

        public void DisablePreviousDescription(ZooDescription zd)
        {
            string sql = "UPDATE description SET isActive = @isActive WHERE id = @id";
            MySqlCommand command = new MySqlCommand(sql, conn);

            command.Parameters.AddWithValue("@id", zd.Id);
            command.Parameters.AddWithValue("@isActive", false);
            try
            {

                conn.Open();

                command.ExecuteNonQuery();


            }
            catch (MySqlException ex)
            {
                throw ex;
            }

            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public int GetNexID()
        {
            string sql = "SELECT AUTO_INCREMENT FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbi481796' AND TABLE_NAME = 'description';";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());

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

        public void GetDescriptions(List<ZooDescription> descriptions)
        {
            string sqlStatement = "SELECT * FROM description";
            MySqlCommand command = new MySqlCommand(sqlStatement, conn);




            try
            {
                MySqlDataReader databaseReader;

                conn.Open();
                databaseReader = command.ExecuteReader();
                ZooDescription description;


                while (databaseReader.Read())
                {
                    description = new ZooDescription(databaseReader.GetInt32("id"), databaseReader.GetString("description"), databaseReader.GetBoolean("isActive"), databaseReader.GetDateTime("dateOfCreation"));
                    descriptions.Add(description);
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
        }

        public void DeleteDescriptions(List<ZooDescription> descriptions)
        {
            string sqlStatement = "";
            for (int i = 0; i < descriptions.Count; i++)
            {
                sqlStatement += $"DELETE FROM description WHERE id=@id{i};";

            }
            MySqlCommand command = new MySqlCommand(sqlStatement, conn);

            for (int i = 0; i < descriptions.Count; i++)
            {
                command.Parameters.AddWithValue($"@id{i}", descriptions[i].Id);

            }
            try
            {
                int n;

                conn.Open();

                n = command.ExecuteNonQuery();

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

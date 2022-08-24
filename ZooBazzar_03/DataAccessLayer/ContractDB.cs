using MySql.Data.MySqlClient;
using Entities;
using System.Data;

namespace DataAccessLayer
{
    public class ContractDB : IContractDataManagement<EmployeeContract>
    {
        private MySqlConnection conn;

        public ContractDB()
        {
            conn = ConnectionDB.GetConnection();
        }

        public void AddContract(EmployeeContract ec, Employee e)
        {
            try
            {
                string sql = "INSERT INTO contract (employee_id, start_date, end_date, fte, reason, is_valid) VALUES(@employee_id, @start_date, @end_date, @fte, @reason, @is_valid);";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@employee_id", e.Id);
                cmd.Parameters.AddWithValue("@start_date", ec.StartDate);
                cmd.Parameters.AddWithValue("@end_date", ec.EndDate);
                cmd.Parameters.AddWithValue("@fte", ec.Fte);
                cmd.Parameters.AddWithValue("@reason", ec.Reason);
                cmd.Parameters.AddWithValue("@is_valid", ec.IsValid);
                conn.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("New contract has been added");
                }
                else
                {
                    MessageBox.Show("Failed to add a new contract");
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
        }

        public void DisableContract(EmployeeContract ec)
        {
            string sql = "UPDATE contract SET is_valid = @is_valid WHERE id = @id";
            MySqlCommand command = new MySqlCommand(sql, conn);

            command.Parameters.AddWithValue("@id", ec.Id);
            command.Parameters.AddWithValue("@is_valid", false);
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

        public List<EmployeeContract> GetContracts()
        {
            string sqlStatement = "SELECT * FROM contract ";
            MySqlCommand command = new MySqlCommand(sqlStatement, conn);
            List<EmployeeContract> contracts = new List<EmployeeContract>();
            EmployeeDB ed = new EmployeeDB();
            try
            {
                MySqlDataReader databaseReader;

                conn.Open();
                databaseReader = command.ExecuteReader();

                EmployeeContract ec;


                while (databaseReader.Read())
                {


                    ec = new EmployeeContract(databaseReader.GetInt32("id"),
                        databaseReader.GetInt32("employee_id"),
                        databaseReader.GetDateTime("start_date"),
                        databaseReader.GetDateTime("end_date"),
                        databaseReader.GetDouble("fte"),
                        databaseReader.GetString("reason"),
                        databaseReader.GetInt32("vacationDaysLeft"),
                        databaseReader.GetBoolean("is_valid"));
                    contracts.Add(ec);
                }
                return contracts;
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

        public List<EmployeeContract> GetContracts(Employee e)
        {
            string sqlStatement = "SELECT * FROM contract where employee_id=@employee_id ";
            MySqlCommand command = new MySqlCommand(sqlStatement, conn);
            List<EmployeeContract> contracts = new List<EmployeeContract>();
            EmployeeDB ed = new EmployeeDB();
            try
            {

                command.Parameters.AddWithValue("@employee_id", e.Id);
                MySqlDataReader databaseReader;

                conn.Open();
                databaseReader = command.ExecuteReader();

                EmployeeContract ec;


                while (databaseReader.Read())
                {


                    ec = new EmployeeContract(databaseReader.GetInt32("id"), databaseReader.GetInt32("employee_id"), databaseReader.GetDateTime("start_date"), databaseReader.GetDateTime("end_date"), databaseReader.GetDouble("fte"), databaseReader.GetString("reason"), databaseReader.GetInt32("vacationDaysLeft"), databaseReader.GetBoolean("is_valid"));
                    contracts.Add(ec);
                }
                return contracts;
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

        public void UpdateVacationDays(EmployeeContract contract)
        {
            try
            {
                string sql = "UPDATE contract SET vacationDaysLeft=@Days WHERE id = @ID";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@ID", contract.Id);
                cmd.Parameters.AddWithValue("@Days", contract.VacationDaysLeft);
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

using Entities;
using MySql.Data.MySqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class EmployeeDB : ICRU<Employee>
    {
        private MySqlConnection conn;
        private Employee employee;
        public EmployeeDB()
        {
            conn = ConnectionDB.GetConnection();
        }
        public void Add(Employee obj)
        {
            string sql2 = " ";
            MySqlCommand cmd2 = null;

            if(obj.WorkingPosition == "Caretaker")
            {
                sql2 = "INSERT INTO caretaker (employee_id,specialization) VALUES (@Employee_ID,@Specialization)";
                cmd2 = new MySqlCommand(sql2, conn);
                    
                cmd2.CommandType = CommandType.Text;
                cmd2.Parameters.Add("@ID", MySqlDbType.Int32).Value = obj.Id;
                cmd2.Parameters.Add("@Specialization",MySqlDbType.VarChar).Value = ((Caretaker)obj).GetSpecialization();
            }

            string sql = "INSERT INTO employee (ID,FirstName,LastName,Address,Birthdate,Phone,Email,EmergencyContact,BSN,WorkPosition) VALUES (@ID,@FirstName,@LastName,@Address,@Birthdate,@Phone,@Email,@EmergencyContact,@BSN,@WorkPosition)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = obj.Id;
            cmd.Parameters.Add("@FirstName", MySqlDbType.VarChar).Value = obj.Name;
            cmd.Parameters.Add("@LastName", MySqlDbType.VarChar).Value = obj.Lastname;
            cmd.Parameters.Add("@Address", MySqlDbType.VarChar).Value = obj.Address;
            cmd.Parameters.Add("@BirthDate", MySqlDbType.DateTime).Value = obj.Birthdate;
            cmd.Parameters.Add("@Phone", MySqlDbType.VarChar).Value = obj.Phone;
            cmd.Parameters.Add("@EmergencyContact", MySqlDbType.VarChar).Value = obj.EmargencyContact;
            cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = obj.Email;
            cmd.Parameters.Add("@BSN", MySqlDbType.VarChar).Value = obj.Bsn;
            cmd.Parameters.Add("@WorkPosition", MySqlDbType.VarChar).Value = obj.WorkingPosition;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                if(cmd2 != null)
                    cmd2.ExecuteNonQuery();

                MessageBox.Show("Employee added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Employee is not inserted! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Employee> Read()
        {
            string sql = "SELECT username,password,firstname,lastname,address,birthdate,email,phone,emergencycontact,bsn,workposition,id,specialization FROM employee INNER JOIN account ON employee.ID = account.AccountID Left JOIN caretaker On employee.ID = caretaker.employee_id";
            List<Employee> employees = new List<Employee>();
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    
                    if (reader[10].ToString() == "Caretaker")
                    {
                        Specialization specialization = (Specialization)Enum.Parse(typeof(Specialization), reader[12].ToString());
                        employee = new Caretaker(new Account(reader[0].ToString(), reader[1].ToString()), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), Convert.ToDateTime(reader[5]), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(),Convert.ToInt32(reader[11]), specialization);
                    }
                    else
                    {
                        employee = new Employee(new Account(reader[0].ToString(), reader[1].ToString()), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), Convert.ToDateTime(reader[5]), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), Convert.ToInt32(reader[11]));
                    }

                    employees.Add(employee);
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Error during reading the data in employees! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return employees;
        }

        public void Update(Employee obj)
        {
            string sql = "UPDATE employee SET FirstName = @FirstName,LastName = @Lastname,Address = @Address,Birthdate = @Birthdate,Phone = @Phone,Email = @Email,EmergencyContact = @EmergencyContact,BSN = @BSN,WorkPosition = @WorkingPosition WHERE ID = @ID ";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@FirstName", MySqlDbType.VarChar).Value = obj.Name;
            cmd.Parameters.Add("@LastName", MySqlDbType.VarChar).Value = obj.Lastname;
            cmd.Parameters.Add("@Address", MySqlDbType.VarChar).Value = obj.Address;
            cmd.Parameters.Add("@BirthDate", MySqlDbType.DateTime).Value = obj.Birthdate;
            cmd.Parameters.Add("@Phone", MySqlDbType.VarChar).Value = obj.Phone;
            cmd.Parameters.Add("@EmergencyContact", MySqlDbType.VarChar).Value = obj.EmargencyContact;
            cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = obj.Email;
            cmd.Parameters.Add("@BSN", MySqlDbType.VarChar).Value = obj.Bsn;
            cmd.Parameters.Add("@WorkingPosition", MySqlDbType.VarChar).Value = obj.WorkingPosition;
            cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = obj.Id;

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
    }
}

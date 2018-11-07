using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Data
using System.Data;
using System.Data.SqlClient;
// MessageBox
using System.Windows.Forms;

namespace _1.Model
{
    public class clsDataSource
    {
        // 1. Obj clsConnection
        private clsConnection Connection = new clsConnection();
        // 2. Execute SQl
        SqlCommand Command = new SqlCommand();
        // 3 . Read Rows
        SqlDataReader Read;
        
        // 4. fnc.Load employee in the combo box employee
        public DataTable EmployeeList()
        {
            try
            {
                // 1. Store query rows
                DataTable Table = new DataTable();
                // 2. Execute open connection
                Command.Connection = Connection.OpenConnection();
                // 3. Execute stored procedure
                Command.CommandText = "selectEmployee";
                // 4. Execute specify teh command type
                Command.CommandType = CommandType.StoredProcedure;
                // 5. Excute read the rows from stored procedure
                Read = Command.ExecuteReader(); // to read rows - return rows
                // 6. Load the table
                Table.Load(Read);
                // 7. Close connection
                Connection.CloseConnection();
                // 8. Make return
                return Table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in the Model loading selectEmployee from the data base : " + " " + ex.Message);
                return null;
            }
        }

        // 5.fnc.Load agencies in the combo box agencies
        public DataTable AgenciesList()
        {
            try
            {
                // 1. Store query rows
                DataTable Table = new DataTable();
                // 2. Execute open connection
                Command.Connection = Connection.OpenConnection();
                // 3. Execute stored procedure
                Command.CommandText = "selectAgencies";
                // 4. Execute specify teh command type
                Command.CommandType = CommandType.StoredProcedure;
                // 5. Excute read the rows from stored procedure
                Read = Command.ExecuteReader(); // to read rows - return rows
                // 6. Load the table
                Table.Load(Read);
                // 7. Close connection
                Connection.CloseConnection();
                // 8. Make return
                return Table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in the Model loading selectAgencies from the data base : " + " " + ex.Message);
                return null;
            }
        }

        // 6. fnc.Load client in the dataGridView
        public DataTable DisplayClients()
        {
            try
            {
                // 1. Store query rows
                DataTable Table = new DataTable();
                // 2. Execute open connection
                Command.Connection = Connection.OpenConnection();
                // 3. Execute stored procedure
                Command.CommandText = "selectqclient";
                // 4. Execute specify teh command type
                Command.CommandType = CommandType.StoredProcedure;
                // 5. Excute read the rows from stored procedure
                Read = Command.ExecuteReader(); // to read rows - return rows
                // 6. Load the table
                Table.Load(Read);
                // 7. Close connection
                Connection.CloseConnection();
                // 8. Make return
                return Table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in the Model loading selectqclient from the data base : " + " " + ex.Message);
                return null;
            }
        }

        // 7. fnc.save client in the data base
        public void Save(int idclient, string clientNumber, string name, string lastName, string email, string img, string address, string cardNumber, string nip, int idagencies, int idemployee, string sexe)
        {
            try
            {
                // 1. Execute open connection
                Command.Connection = Connection.OpenConnection();
                // 2. Execute stored procedure
                Command.CommandText = "spserver_save_client";
                // 3. Execute Specify the command type
                Command.CommandType = CommandType.StoredProcedure;
                // 4. Execute parameters
                Command.Parameters.AddWithValue("@aidclient", idclient);
                Command.Parameters.AddWithValue("@aclientNumber", clientNumber);
                Command.Parameters.AddWithValue("@aname", name);
                Command.Parameters.AddWithValue("@alastName", lastName);
                Command.Parameters.AddWithValue("@aemail", email);
                Command.Parameters.AddWithValue("@aimg", img);
                Command.Parameters.AddWithValue("@aaddress", address);
                Command.Parameters.AddWithValue("@acardNumber", cardNumber);
                Command.Parameters.AddWithValue("@anip", nip);
                Command.Parameters.AddWithValue("@aidagencies", idagencies);
                Command.Parameters.AddWithValue("@aidemployee", idemployee);
                Command.Parameters.AddWithValue("@asexe", sexe);
                // 5. Execute instructions SQL
                Command.ExecuteNonQuery();
                // 6. Execute reuse the object SqlCommand Command
                Command.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in the Model executing the function Save : " + " " + ex.Message);
            }
        }
        
        // 8. fnc.delete client from the data base
        public void Delete(int idclient)
        {
            try
            {
                // 1. Execute open connection
                Command.Connection = Connection.OpenConnection();
                // 2. Execute stored procedure
                Command.CommandText = "deleteTclientByid";
                // 3. Execute the command type
                Command.CommandType = CommandType.StoredProcedure;
                // 4. Execute parameter
                Command.Parameters.AddWithValue("@aidclient", idclient);
                // 5. Execute instruction SQL
                Command.ExecuteNonQuery();
                // 6. Execute reuse the object SqlCommand Comman
                Command.Parameters.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error in the Model executing the function Delete : " + " " + ex.Message);
            }
        }

        // 9. fnc.select client by Agency from the data base
        public string ReaderAgency(string agencyName)
        {
            try
            {
                // 1. Execute open connection
                Command.Connection = Connection.OpenConnection();
                // 2. Execute Stored procedure
                Command.CommandText = "selectqclientByAgency";
                // 3. Execute command type
                Command.CommandType = CommandType.StoredProcedure;
                // 4. Execute parameter
                Command.Parameters.AddWithValue("@aAgency", agencyName);
                // 5 . Read Rows
                SqlDataReader Read;
                // 6. Excute read the rows from stored procedure
                Read = Command.ExecuteReader(); // to read rows - return rows
                // 7. Execute Load reader
                string reader;
                if (Read.Read()==true)
                {
                    reader= Read.GetString(Read.GetOrdinal("Agency"));
                }
                else
                {
                    reader = "";
                }
                // 8. Execute reuse the object AqlCommand Command
                Command.Parameters.Clear();
                // 9. Close connection
                Connection.CloseConnection();
                // 10. Make return
                return reader;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error in the Model executing the function ReaderAgency : " + " " + ex.Message);
                return null;
            }
        }

        // 10. fnc.Load employee in the combo box employee
        public DataTable selectqclientByAgency(string agencyName)
        {
            try
            {
                // 1. Store query rows
                DataTable Table = new DataTable();
                // 2. Execute open connection
                Command.Connection = Connection.OpenConnection();
                // 3. Execute stored procedure
                Command.CommandText = "selectqclientByAgency";
                // 4. Execute specify teh command type
                Command.CommandType = CommandType.StoredProcedure;
                // 4. Execute parameter
                Command.Parameters.AddWithValue("@aAgency", agencyName);
                // 5. Excute read the rows from stored procedure
                Read = Command.ExecuteReader(); // to read rows - return rows
                // 6. Load the table
                Table.Load(Read);
                // 7. Close connection
                Connection.CloseConnection();
                // 8. Make return
                return Table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in the Model loading selectqclientByAgency the data base : " + " " + ex.Message);
                return null;
            }
        }

        //11. fnc.select client by Employee from the data base
        public string ReaderEmployee(string employeeNummber)
        {
            try
            {
                // 1. Execute open connection
                Command.Connection = Connection.OpenConnection();
                // 2. Execute Stored procedure
                Command.CommandText = "selectqclientByemployeeNumber";
                // 3. Execute command type
                Command.CommandType = CommandType.StoredProcedure;
                // 4. Execute parameter
                Command.Parameters.AddWithValue("@aemployeeNummber", employeeNummber);
                // 5 . Read Rows
                SqlDataReader Read;
                // 6. Excute read the rows from stored procedure
                Read = Command.ExecuteReader(); // to read rows - return rows
                // 7. Execute Load reader
                string reader;
                if (Read.Read() == true)
                {
                    reader = Read.GetString(Read.GetOrdinal("Employee"));
                }
                else
                {
                    reader = "";
                }
                // 8. Execute reuse the object AqlCommand Command
                Command.Parameters.Clear();
                // 9. Close connection
                Connection.CloseConnection();
                // 10. Make return
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in the Model executing the function ReaderEmployee : " + " " + ex.Message);
                return null;
            }
        }

        // 12. fnc.Load employee in the combo box employee
        public DataTable selectqclientByemployeeNumber(string employeeNummber)
        {
            try
            {
                // 1. Store query rows
                DataTable Table = new DataTable();
                // 2. Execute open connection
                Command.Connection = Connection.OpenConnection();
                // 3. Execute stored procedure
                Command.CommandText = "selectqclientByemployeeNumber";
                // 4. Execute specify teh command type
                Command.CommandType = CommandType.StoredProcedure;
                // 4. Execute parameter
                Command.Parameters.AddWithValue("@aemployeeNummber", employeeNummber);
                // 5. Excute read the rows from stored procedure
                Read = Command.ExecuteReader(); // to read rows - return rows
                // 6. Load the table
                Table.Load(Read);
                // 7. Close connection
                Connection.CloseConnection();
                // 8. Make return
                return Table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in the Model loading selectqclientByemployeeNumber the data base : " + " " + ex.Message);
                return null;
            }
        }
    }
}

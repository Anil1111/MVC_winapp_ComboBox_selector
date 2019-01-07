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
    /*
     * This project uses the following licenses:
     *  MIT License
     *  Copyright (c) 2018 Ricardo Mendoza 
     *  Montréal Québec Canada
    */
    public class clsDataSource
    {
        /// <summary>
        /// 1. Obj clsConnection -> object connection with the data base
        /// </summary>
        private clsConnection Connection = new clsConnection();
        // 2. Execute SQl
        private SqlCommand Command = new SqlCommand();
        // 3 . Read Rows
        private SqlDataReader Read;

        /// <summary>
        /// ATTRIBUTES
        /// </summary>
        private int idclient;
        private string clientNumber;
        private string name;
        private string lastName;
        private string email;
        private string img;
        private string address;
        private string cardNumber;
        private string nip;
        private int idagencies;
        private int idemployee;
        private string sexe;

        private string agencyName;
        private string employeeNummber;

        /// <summary>
        /// CONSTRUCTOR EMPTY.
        /// </summary>
        public clsDataSource()
        { }
        /// <summary>
        /// CONTRUCTOR 12 ARGUMENTS.
        /// </summary>
        public clsDataSource(string vagencyName, string vemployeeNummber, int vidclient, string vclientNumber, string vname, string vlastName, string vemail, string vimg, string vaddress, string vcardNumber, string vnip, int vidagencies, int videmployee, string vsexe)
        {
            idclient = vidclient;
            clientNumber = vclientNumber;
            name =vname;
            lastName=vlastName;
            email=vemail;
            img=vimg;
            address=vaddress;
            cardNumber=vcardNumber;
            nip=vnip;
            idagencies=vidagencies;
            idemployee=videmployee;
            sexe=vsexe;
        }

        /// <summary>
        /// PROPERTIES.
        /// </summary>
        public int vdclient
        {
            get
            { return idclient; }

            set
            { idclient = value; }
        }

        public string vclientNumber
        {
            get
            { return clientNumber; }

            set
            { clientNumber = value; }
        }

        public string vname
        {
            get
            {return name;}

            set
            { name = value;}
        }

        public string vlastName
        {
            get
            {return lastName;}

            set
            { lastName = value; }
        }

        public string vemail
        {
            get
            { return email; }

            set
            { email = value; }
        }

        public string vimg
        {
            get
            { return img; }

            set
            { img = value; }
        }

        public string vaddress
        {
            get
            { return address; }

            set
            { address = value; }
        }

        public string vcardNumber
        {
            get
            { return cardNumber; }

            set
            {cardNumber = value; }
        }

        public string vnip
        {
            get
            { return nip;}

            set
            { nip = value; }
        }

        public int vidagencies
        {
            get
            {return idagencies; }

            set
            { idagencies = value;}
        }

        public int videmployee
        {
            get
            {return idemployee; }

            set
            { idemployee = value; }
        }

        public string vsexe
        {
            get
            { return sexe;}

            set
            {sexe = value;}
        }

        public string vagencyName
        {
            get
            { return agencyName; }

            set
            { agencyName = value; }
        }

        public string vemployeeNummber
        {
            get
            {return employeeNummber; }

            set
            { employeeNummber = value;}
        }


        /// <summary>
        /// 4. fnc.Load employee in the combo box employee
        /// </summary>
        /// <returns>DataTable Table</returns>
        public DataTable EmployeeList()
        {
            try
            {
                // 1. Object DataTable
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

        /// <summary>
        /// 5.fnc.Load agencies in the combo box agencies
        /// </summary>
        /// <returns> DataTable Table</returns>
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

        /// <summary>
        /// 6. fnc.Load client in the dataGridView
        /// </summary>
        /// <returns> DataTable Table</returns>
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

        /// <summary>
        /// 7. fnc.save client in the data base with POO
        /// </summary>
        public void Save()
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

        /// <summary>
        /// 8. fnc.delete client from the data base with POO
        /// </summary>
        public void Delete()
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

        /// <summary>
        /// 9. fnc.select a string from tclient by Agency in the data base
        /// </summary>
        /// <returns>string reader</returns>
        public string ReaderAgency()
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

        /// <summary>
        /// 10. fnc.select client from tclient by Agency in the data base
        /// </summary>
        /// <returns> DataTable Table</returns>
        public DataTable selectqclientByAgency()
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
                // 5. Execute parameter
                Command.Parameters.AddWithValue("@aAgency", agencyName);
                // 6. Excute read the rows from stored procedure
                Read = Command.ExecuteReader(); // to read rows - return rows
                // 7. Load the table
                Table.Load(Read);
                // 8. Close connection
                Connection.CloseConnection();
                // 9. Make return
                return Table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in the Model loading selectqclientByAgency the data base : " + " " + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// 11. fnc.select a string from tclient by Employee Number in the data base
        /// </summary>
        /// <returns>string reader</returns>
        public string ReaderEmployee()
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

        /// <summary>
        /// 12. fnc.select client from tclient by Employee Number in the data base
        /// </summary>
        /// <returns> DataTable Table</returns>
        public DataTable selectqclientByemployeeNumber()
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
    } // end class
}

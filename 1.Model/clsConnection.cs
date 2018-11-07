using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Data
using System.Data;
using System.Data.SqlClient;
// Message Box
using System.Windows.Forms;

namespace _1.Model
{
    public class clsConnection
    {
        // Error 40: Could not open a connection to SQL Server fixed with  http://msdn.microsoft.com/en-us/library/ms174212.aspx
        // in My computer : C:\Windows\SysWOW64\SQLServerManager14.msc
        static private string stringConnection = "Data Source = .; DataBase = bd_aspcrud_examen; Integrated Security = true";
        private SqlConnection MyConnection = new SqlConnection(stringConnection);

        // OPEN CONNECTION
        public SqlConnection OpenConnection()
        {
            try
            {
                if (MyConnection.State == ConnectionState.Closed)
                {
                    MyConnection.Open();
                }
                return MyConnection;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Open Connection : " + " " + ex.Message);
                return null;
            }
        }

        // CLOSED CONNECTION
        public SqlConnection CloseConnection()
        {
            try
            {
                if (MyConnection.State == ConnectionState.Open)
                {
                    MyConnection.Close();
                }
                return MyConnection;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Open Connection : " + " " + ex.Message);
                return null;
            }
        }
    }
}

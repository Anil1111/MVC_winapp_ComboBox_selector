using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;// Message Box
// Data
using System.Data;
using System.Data.SqlClient;

namespace _1.Model
{
    /*
    * This project uses the following licenses:
    *  MIT License
    *  Copyright (c) 2018 Ricardo Mendoza 
    *  Montréal Québec Canada
   */
    public class clsConnection
    {
        // Error 40: Could not open a connection to SQL Server fixed with  http://msdn.microsoft.com/en-us/library/ms174212.aspx
        // in My computer : C:\Windows\SysWOW64\SQLServerManager14.msc
        static private string stringConnection = "Data Source = .; DataBase = bd_combobox_crud; Integrated Security = true";
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

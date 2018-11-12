using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Data
using System.Data;
using _1.Model; // Handles data

// MessageBox
using System.Windows.Forms;

namespace _3.Controller
{
    /*
     * This project uses the following licenses:
     *  MIT License
     *  Copyright (c) 2018 Ricardo Mendoza 
     *  Montréal Québec Canada
    */
    public class clsInfo
    {
        /// <summary>
        /// 1. Obj Model -> object with the interactions with the data base
        /// </summary>
        private clsDataSource Model = new clsDataSource();

        /// <summary>
        /// 2. Load employee name in the combo box employee -> call the info employee from data base and returns the info in a table
        /// </summary>
        /// <returns>an employee info table</returns>
        public DataTable EmployeeList()
        {
            // 1. Obj DataTable
            DataTable Table = new DataTable();
            // 2. Info Employee in Table Object
            Table = Model.EmployeeList();
            // 3. Make return
            return Table;
        }

        /// <summary>
        /// 3. Load agencies name in the combo box agencies -> call the info agencies from data base and returns the info in a table
        /// </summary>
        /// <returns>an employee info table</returns>
        public DataTable AgenciesList()
        {
            // 1. Obj DataTable
            DataTable Table = new DataTable();
            // 2. Info Agencies in Table Object
            Table = Model.AgenciesList();
            // 3. Make return
            return Table;
        }

        /// <summary>
        /// 4. Load clients in the data grid view -> call the info clients from data base and returns the info in a table
        /// </summary>
        /// <returns>a clients info table</returns>
        public DataTable LoadClients()
        {
            // 1. Obj DataTable
            DataTable Table = new DataTable();
            // 2. Info Agencies in Table Object
            Table = Model.DisplayClients();
            // 3. Make return
            return Table;
        }

        /// <summary>
        /// 5. Save or Update clients in the data base
        /// </summary>
        public void SaveClient(string idclient, string clientNumber, string name, string lastName, string email, string img, string address, string cardNumber, string nip, string idagencies, string idemployee, string sexe)
        {
            // we validate and convert data in the the Controller layer
            // we do not validate and convert data in the View layer 
            // with idclient we update one row in the table

            // 1. Convert data
            int IDclient = Convert.ToInt32(idclient);
            int IDagencies = Convert.ToInt32(idagencies);
            int IDemployee = Convert.ToInt32(idemployee);
            // 2. Save or update in the Model layer
            Model.Save(IDclient, clientNumber, name, lastName, email, img, address, cardNumber, nip, IDagencies, IDemployee,sexe);
        }

        /// <summary>
        /// 6. Delete clients in the data base
        /// </summary>
        public void DeleteClient(string idclient)
        {
            try
            {
                // we validate and convert data in the the Controller layer
                // we do not validate and convert data in the View layer 
                // with idclient we update one row in the table 

                // 1. Convert data
                int IDclient = Convert.ToInt32(idclient);
                // 2. Delete in the model layer
                Model.Delete(IDclient);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in the delete: " + " " + ex.Message);
            }
        }
        /// <summary>
        /// 7. fnc.select a string from tclient by Agency in the data base
        /// </summary>
        /// <param name="agencyName">string agencyName</param>
        /// <returns>string reader </returns>
        public string ReaderAgency(string agencyName)
        {
            try
            {
                // 1. The reader
                string reader = Model.ReaderAgency(agencyName);
                // 2. Make return
                return reader;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error in the Controller select select a string from tclient by Agency : " + " " + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// 8. fnc.select client from tclient by Agency in the data base
        /// </summary>
        /// <returns>a client info table</returns>
        public DataTable selectqclientByAgency(string agencyName)
        {
            // 1. Obj DataTable
            DataTable Table = new DataTable();
            // 2. Info client by Agency in Table Object
            Table = Model.selectqclientByAgency(agencyName);
            // 3. Make return
            return Table;
        }

        /// <summary>
        /// 9. fnc.select a string from tclient by Employee Number in the data base
        /// </summary>
        /// <param name="employeeNummber">string employeeNummber</param>
        /// <returns>string reader</returns>
        public string ReaderEmployee(string employeeNummber)
        {
            try
            {
                // 1. The reader
                string reader = Model.ReaderEmployee(employeeNummber);
                // 2. Make return
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in the Controller select client by employeeNummber : " + " " + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// 10. fnc.select client from tclient by Employee Number in the data base
        /// </summary>
        /// <returns>a client info table</returns>
        public DataTable selectqclientByemployeeNumber(string employeeNummber)
        {
            // 1. Obj DataTable
            DataTable Table = new DataTable();
            // 2. Info client by Agency in Table Object
            Table = Model.selectqclientByemployeeNumber(employeeNummber);
            // 3. Make return
            return Table;
        }
    } // end class
}

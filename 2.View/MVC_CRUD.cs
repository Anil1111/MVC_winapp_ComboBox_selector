using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3.Controller;  // Handles decisions

namespace _2.View
{
    public partial class MVC_CRUD : Form
    {
        // static variables agency
        static string stringdbaseagency;
        static string stringcmboxagency;
        // static variables employee
        static string stringdbaseemployee;
        static string stringcmboxemployee;

        public MVC_CRUD()
        {
            InitializeComponent();
        }

        private void MVC_ComboBoxSelector_Load(object sender, EventArgs e)
        {
            // Load combo employees
            ListEmployees();
            // Load combo agencies
            ListAgencies();
            // Load data grid view
            DisplayClients();
            // init
            btnDelete.Enabled = false;
            txtidclient.Text = "0";
            txtidclient.Visible = false;
            lblidclient.Visible = false;
            // Init static variables
            stringdbaseagency = null;
            stringcmboxagency = null;

            stringdbaseemployee = null;
            stringcmboxemployee = null;

        }

        private void ListEmployees()
        {
            // new Controller cleans the object everytime it is called
            // new Controllercleans the view with every click
            clsInfo Controller = new clsInfo();
            cmbEmployees.DataSource = Controller.EmployeeList();
            cmbEmployees.DisplayMember = "Employee";
            cmbEmployees.ValueMember = "idEmployee";
        }

        private void ListAgencies()
        {
            // new Controller cleans the object everytime it is called
            // new Controllercleans the view with every click
            clsInfo Controller = new clsInfo();
            cmbAgencies.DataSource = Controller.AgenciesList();
            cmbAgencies.DisplayMember = "Agency";
            cmbAgencies.ValueMember = "idagencies";
            
        }

        /// <summary>
        /// 1. Loads the info client in to the dataGridView
        /// </summary>
        private void DisplayClients()
        {
            // new Controller cleans the object everytime it is called
            // new Controllercleans the view with every click
            clsInfo Controller = new clsInfo();
            gvClient.DataSource = Controller.LoadClients();
        }

        /// <summary>
        /// 2. Select the info client from each row in the dataGridView
        /// </summary>
        private void gvClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gvClient.SelectedRows.Count > 0)
                {
                    // select client by row
                    txtidclient.Text = gvClient.SelectedRows[0].Cells["idclient"].Value.ToString();
                    txtclientNumber.Text = gvClient.SelectedRows[0].Cells["clientNumber"].Value.ToString();
                    txtname.Text = gvClient.SelectedRows[0].Cells["name"].Value.ToString();
                    txtlastName.Text = gvClient.SelectedRows[0].Cells["lastName"].Value.ToString();
                    txtemail.Text = gvClient.SelectedRows[0].Cells["email"].Value.ToString();
                    txtimg.Text = gvClient.SelectedRows[0].Cells["img"].Value.ToString();
                    txtaddress.Text = gvClient.SelectedRows[0].Cells["address"].Value.ToString();
                    txtcardNumber.Text = gvClient.SelectedRows[0].Cells["cardNumber"].Value.ToString();
                    txtnip.Text = gvClient.SelectedRows[0].Cells["nip"].Value.ToString();
                    txtagencies.Text = gvClient.SelectedRows[0].Cells["idagencies"].Value.ToString();
                    txtemployees.Text = gvClient.SelectedRows[0].Cells["idemployee"].Value.ToString();
                    txtsexe.Text = gvClient.SelectedRows[0].Cells["sexe"].Value.ToString();
                    // btnSave to btnUpdate
                    btnSave.Text = "Update >>>";
                    btnDelete.Enabled = true;
                    btnRefresh.Text = "Clear >>>";
                }
                else
                {
                    MessageBox.Show("select a row please");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + " " + ex.Message);
            }
        }

        /// <summary>
        /// 3. Save or update the info client in to the data base
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Get client info from text boxes
                string idclient = txtidclient.Text.Trim();
                string clientNumber = txtclientNumber.Text.Trim();
                string name = txtname.Text.Trim();
                string lastName = txtlastName.Text.Trim();
                string email = txtemail.Text.Trim();
                string img = txtimg.Text.Trim();
                string address = txtaddress.Text.Trim();
                string cardNumber = txtcardNumber.Text.Trim();
                string nip = txtnip.Text.Trim();
                string idagencies = cmbAgencies.SelectedValue.ToString();
                string idemployee = cmbEmployees.SelectedValue.ToString();
                string sexe = txtsexe.Text.Trim();

    
                clsInfo Controller = new clsInfo();
                // 2. Save or update client info
                Controller.SaveClient(idclient, clientNumber, name, lastName, email, img, address, cardNumber, nip, idagencies, idemployee, sexe);
                if (idclient != "0")
                {
                    MessageBox.Show("Msg : " + " " + " client has been updated");
                }
                else
                {
                    MessageBox.Show("Msg : " + " " + " client has been saved");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error  : " + " " + ex.Message);
            }
            // Refresh the dataGridView
            DisplayClients();
            // Cleans the text boxws in the form
            CleanTextboxes();
        }

        /// <summary>
        /// 4. Delete the info client in to the data base
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 1. Get client info from text boxes
            string idclient = txtidclient.Text.Trim();
            
            try
            {
                clsInfo Controller = new clsInfo();
                // 2. Deleteclient info
                Controller.DeleteClient(idclient);
                // 3. Loads the info client in to the dataGridView
                DisplayClients();
                // 4. cleaan the text boxes 
                CleanTextboxes();
                // 5. Message
                MessageBox.Show("Msg : " + " " + " client has been deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  : " + " " + ex.Message);
            }
        }
     
        private void cmbAgencies_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                clsInfo Controller = new clsInfo();
                // static variables agency
                stringcmboxagency = cmbAgencies.Text;
                stringdbaseagency = Controller.ReaderAgency(stringcmboxagency);
                gvClient.DataSource = Controller.selectqclientByAgency(stringdbaseagency);
                CleanTextboxes();
                btnRefresh.Text = "Refresh >>>";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  : " + " " + ex.Message);
            }
        }

        private void cmbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                clsInfo Controller = new clsInfo();
                stringcmboxemployee = cmbEmployees.Text;
                stringdbaseemployee = Controller.ReaderEmployee(stringcmboxemployee);
                gvClient.DataSource = Controller.selectqclientByemployeeNumber(stringdbaseemployee);
                CleanTextboxes();
                btnRefresh.Text = "Refresh >>>";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  : " + " " + ex.Message);
            }
        }

        /// <summary>
        /// 5. cleaan the text boxes 
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            CleanTextboxes();
            // Load data grid view
            DisplayClients();
            btnRefresh.Text = "Refresh >>>";
        }

        /// <summary>
        /// 6. cleaan the text boxes 
        /// </summary>
        public void CleanTextboxes()
        {
            txtidclient.Text = "0";
            txtclientNumber.Clear();
            txtname.Clear();
            txtlastName.Clear();
            txtemail.Clear();
            txtimg.Clear();
            txtaddress.Clear();
            txtcardNumber.Clear();
            txtnip.Clear();
            txtsexe.Clear();
            txtagencies.Clear();
            txtemployees.Clear();
            // btnSave to btnSave
            btnSave.Text = "Save >>>";
            btnDelete.Enabled = false;
        }
    }
}

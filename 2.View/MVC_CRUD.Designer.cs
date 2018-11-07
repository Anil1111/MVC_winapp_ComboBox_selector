namespace _2.View
{
    partial class MVC_CRUD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbEmployees = new System.Windows.Forms.ComboBox();
            this.cmbAgencies = new System.Windows.Forms.ComboBox();
            this.gvClient = new System.Windows.Forms.DataGridView();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.lblAgencies = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtidclient = new System.Windows.Forms.TextBox();
            this.lblidclient = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtnip = new System.Windows.Forms.TextBox();
            this.lblnip = new System.Windows.Forms.Label();
            this.txtcardNumber = new System.Windows.Forms.TextBox();
            this.lblcardNumber = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.txtimg = new System.Windows.Forms.TextBox();
            this.lblimg = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtlastName = new System.Windows.Forms.TextBox();
            this.lbllastName = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.txtclientNumber = new System.Windows.Forms.TextBox();
            this.lblclientNumber = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtsexe = new System.Windows.Forms.TextBox();
            this.lblsexe = new System.Windows.Forms.Label();
            this.txtemployees = new System.Windows.Forms.TextBox();
            this.txtagencies = new System.Windows.Forms.TextBox();
            this.lblAgencies2 = new System.Windows.Forms.Label();
            this.lblEmployees2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvClient)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEmployees
            // 
            this.cmbEmployees.FormattingEnabled = true;
            this.cmbEmployees.Location = new System.Drawing.Point(497, 11);
            this.cmbEmployees.Name = "cmbEmployees";
            this.cmbEmployees.Size = new System.Drawing.Size(145, 24);
            this.cmbEmployees.TabIndex = 0;
            this.cmbEmployees.SelectedIndexChanged += new System.EventHandler(this.cmbEmployees_SelectedIndexChanged);
            // 
            // cmbAgencies
            // 
            this.cmbAgencies.FormattingEnabled = true;
            this.cmbAgencies.Location = new System.Drawing.Point(754, 11);
            this.cmbAgencies.Name = "cmbAgencies";
            this.cmbAgencies.Size = new System.Drawing.Size(145, 24);
            this.cmbAgencies.TabIndex = 1;
            this.cmbAgencies.SelectedIndexChanged += new System.EventHandler(this.cmbAgencies_SelectedIndexChanged);
            // 
            // gvClient
            // 
            this.gvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvClient.Location = new System.Drawing.Point(23, 55);
            this.gvClient.Name = "gvClient";
            this.gvClient.Size = new System.Drawing.Size(876, 347);
            this.gvClient.TabIndex = 2;
            this.gvClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvClient_CellClick);
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Location = new System.Drawing.Point(407, 14);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(65, 16);
            this.lblEmployees.TabIndex = 3;
            this.lblEmployees.Text = "Employees";
            // 
            // lblAgencies
            // 
            this.lblAgencies.AutoSize = true;
            this.lblAgencies.Location = new System.Drawing.Point(675, 14);
            this.lblAgencies.Name = "lblAgencies";
            this.lblAgencies.Size = new System.Drawing.Size(56, 16);
            this.lblAgencies.TabIndex = 4;
            this.lblAgencies.Text = "Agencies";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(860, 448);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(145, 23);
            this.btnDelete.TabIndex = 96;
            this.btnDelete.Text = "Delete >>>";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtidclient
            // 
            this.txtidclient.Location = new System.Drawing.Point(1011, 11);
            this.txtidclient.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.txtidclient.Name = "txtidclient";
            this.txtidclient.Size = new System.Drawing.Size(145, 22);
            this.txtidclient.TabIndex = 95;
            // 
            // lblidclient
            // 
            this.lblidclient.AutoSize = true;
            this.lblidclient.Location = new System.Drawing.Point(922, 17);
            this.lblidclient.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblidclient.Name = "lblidclient";
            this.lblidclient.Size = new System.Drawing.Size(47, 16);
            this.lblidclient.TabIndex = 94;
            this.lblidclient.Text = "idclient";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1011, 448);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 23);
            this.btnSave.TabIndex = 95;
            this.btnSave.Text = "Save >>>";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtnip
            // 
            this.txtnip.Location = new System.Drawing.Point(1011, 291);
            this.txtnip.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.txtnip.Name = "txtnip";
            this.txtnip.Size = new System.Drawing.Size(145, 22);
            this.txtnip.TabIndex = 88;
            // 
            // lblnip
            // 
            this.lblnip.AutoSize = true;
            this.lblnip.Location = new System.Drawing.Point(922, 297);
            this.lblnip.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblnip.Name = "lblnip";
            this.lblnip.Size = new System.Drawing.Size(25, 16);
            this.lblnip.TabIndex = 87;
            this.lblnip.Text = "nip";
            // 
            // txtcardNumber
            // 
            this.txtcardNumber.Location = new System.Drawing.Point(1011, 255);
            this.txtcardNumber.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.txtcardNumber.Name = "txtcardNumber";
            this.txtcardNumber.Size = new System.Drawing.Size(145, 22);
            this.txtcardNumber.TabIndex = 86;
            // 
            // lblcardNumber
            // 
            this.lblcardNumber.AutoSize = true;
            this.lblcardNumber.Location = new System.Drawing.Point(922, 261);
            this.lblcardNumber.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblcardNumber.Name = "lblcardNumber";
            this.lblcardNumber.Size = new System.Drawing.Size(72, 16);
            this.lblcardNumber.TabIndex = 85;
            this.lblcardNumber.Text = "cardNumber";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(1011, 222);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(145, 22);
            this.txtaddress.TabIndex = 84;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Location = new System.Drawing.Point(922, 228);
            this.lbladdress.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(50, 16);
            this.lbladdress.TabIndex = 83;
            this.lbladdress.Text = "address";
            // 
            // txtimg
            // 
            this.txtimg.Location = new System.Drawing.Point(1011, 187);
            this.txtimg.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.txtimg.Name = "txtimg";
            this.txtimg.Size = new System.Drawing.Size(145, 22);
            this.txtimg.TabIndex = 82;
            // 
            // lblimg
            // 
            this.lblimg.AutoSize = true;
            this.lblimg.Location = new System.Drawing.Point(922, 193);
            this.lblimg.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblimg.Name = "lblimg";
            this.lblimg.Size = new System.Drawing.Size(27, 16);
            this.lblimg.TabIndex = 81;
            this.lblimg.Text = "img";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(1011, 151);
            this.txtemail.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(145, 22);
            this.txtemail.TabIndex = 80;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(922, 157);
            this.lblemail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(35, 16);
            this.lblemail.TabIndex = 79;
            this.lblemail.Text = "email";
            // 
            // txtlastName
            // 
            this.txtlastName.Location = new System.Drawing.Point(1011, 115);
            this.txtlastName.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.txtlastName.Name = "txtlastName";
            this.txtlastName.Size = new System.Drawing.Size(145, 22);
            this.txtlastName.TabIndex = 78;
            // 
            // lbllastName
            // 
            this.lbllastName.AutoSize = true;
            this.lbllastName.Location = new System.Drawing.Point(922, 121);
            this.lbllastName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbllastName.Name = "lbllastName";
            this.lbllastName.Size = new System.Drawing.Size(56, 16);
            this.lbllastName.TabIndex = 77;
            this.lbllastName.Text = "lastName";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(1011, 80);
            this.txtname.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(145, 22);
            this.txtname.TabIndex = 76;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(922, 86);
            this.lblname.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(36, 16);
            this.lblname.TabIndex = 75;
            this.lblname.Text = "name";
            // 
            // txtclientNumber
            // 
            this.txtclientNumber.Location = new System.Drawing.Point(1011, 45);
            this.txtclientNumber.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.txtclientNumber.Name = "txtclientNumber";
            this.txtclientNumber.Size = new System.Drawing.Size(145, 22);
            this.txtclientNumber.TabIndex = 74;
            // 
            // lblclientNumber
            // 
            this.lblclientNumber.AutoSize = true;
            this.lblclientNumber.Location = new System.Drawing.Point(922, 51);
            this.lblclientNumber.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblclientNumber.Name = "lblclientNumber";
            this.lblclientNumber.Size = new System.Drawing.Size(78, 16);
            this.lblclientNumber.TabIndex = 73;
            this.lblclientNumber.Text = "clientNumber";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(709, 447);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(145, 23);
            this.btnRefresh.TabIndex = 97;
            this.btnRefresh.Text = "Refresh >>>";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtsexe
            // 
            this.txtsexe.Location = new System.Drawing.Point(1011, 328);
            this.txtsexe.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.txtsexe.Name = "txtsexe";
            this.txtsexe.Size = new System.Drawing.Size(145, 22);
            this.txtsexe.TabIndex = 90;
            // 
            // lblsexe
            // 
            this.lblsexe.AutoSize = true;
            this.lblsexe.Location = new System.Drawing.Point(922, 334);
            this.lblsexe.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblsexe.Name = "lblsexe";
            this.lblsexe.Size = new System.Drawing.Size(32, 16);
            this.lblsexe.TabIndex = 98;
            this.lblsexe.Text = "sexe";
            // 
            // txtemployees
            // 
            this.txtemployees.Location = new System.Drawing.Point(1011, 401);
            this.txtemployees.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.txtemployees.Name = "txtemployees";
            this.txtemployees.Size = new System.Drawing.Size(145, 22);
            this.txtemployees.TabIndex = 94;
            // 
            // txtagencies
            // 
            this.txtagencies.Location = new System.Drawing.Point(1011, 364);
            this.txtagencies.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.txtagencies.Name = "txtagencies";
            this.txtagencies.Size = new System.Drawing.Size(145, 22);
            this.txtagencies.TabIndex = 92;
            // 
            // lblAgencies2
            // 
            this.lblAgencies2.AutoSize = true;
            this.lblAgencies2.Location = new System.Drawing.Point(922, 370);
            this.lblAgencies2.Name = "lblAgencies2";
            this.lblAgencies2.Size = new System.Drawing.Size(56, 16);
            this.lblAgencies2.TabIndex = 105;
            this.lblAgencies2.Text = "Agencies";
            // 
            // lblEmployees2
            // 
            this.lblEmployees2.AutoSize = true;
            this.lblEmployees2.Location = new System.Drawing.Point(922, 404);
            this.lblEmployees2.Name = "lblEmployees2";
            this.lblEmployees2.Size = new System.Drawing.Size(65, 16);
            this.lblEmployees2.TabIndex = 104;
            this.lblEmployees2.Text = "Employees";
            // 
            // MVC_CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 494);
            this.Controls.Add(this.lblAgencies2);
            this.Controls.Add(this.lblEmployees2);
            this.Controls.Add(this.txtemployees);
            this.Controls.Add(this.txtagencies);
            this.Controls.Add(this.txtsexe);
            this.Controls.Add(this.lblsexe);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtidclient);
            this.Controls.Add(this.lblidclient);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtnip);
            this.Controls.Add(this.lblnip);
            this.Controls.Add(this.txtcardNumber);
            this.Controls.Add(this.lblcardNumber);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.txtimg);
            this.Controls.Add(this.lblimg);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.txtlastName);
            this.Controls.Add(this.lbllastName);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtclientNumber);
            this.Controls.Add(this.lblclientNumber);
            this.Controls.Add(this.lblAgencies);
            this.Controls.Add(this.lblEmployees);
            this.Controls.Add(this.gvClient);
            this.Controls.Add(this.cmbAgencies);
            this.Controls.Add(this.cmbEmployees);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MVC_CRUD";
            this.Text = "MVC_Implementing Basic CRUD in C#.NET";
            this.Load += new System.EventHandler(this.MVC_ComboBoxSelector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEmployees;
        private System.Windows.Forms.ComboBox cmbAgencies;
        private System.Windows.Forms.DataGridView gvClient;
        private System.Windows.Forms.Label lblEmployees;
        private System.Windows.Forms.Label lblAgencies;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtidclient;
        private System.Windows.Forms.Label lblidclient;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtnip;
        private System.Windows.Forms.Label lblnip;
        private System.Windows.Forms.TextBox txtcardNumber;
        private System.Windows.Forms.Label lblcardNumber;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.TextBox txtimg;
        private System.Windows.Forms.Label lblimg;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtlastName;
        private System.Windows.Forms.Label lbllastName;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtclientNumber;
        private System.Windows.Forms.Label lblclientNumber;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtsexe;
        private System.Windows.Forms.Label lblsexe;
        private System.Windows.Forms.TextBox txtemployees;
        private System.Windows.Forms.TextBox txtagencies;
        private System.Windows.Forms.Label lblAgencies2;
        private System.Windows.Forms.Label lblEmployees2;
    }
}


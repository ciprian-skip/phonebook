namespace AgendaTelefonica
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferinteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marimeFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.culoareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cautaPersoanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvContact = new System.Windows.Forms.DataGridView();
            this.txtContactID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContact)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(967, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializareToolStripMenuItem,
            this.preferinteToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // serializareToolStripMenuItem
            // 
            this.serializareToolStripMenuItem.Name = "serializareToolStripMenuItem";
            this.serializareToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.serializareToolStripMenuItem.Text = "Serializare informatii";
            this.serializareToolStripMenuItem.Click += new System.EventHandler(this.serializareToolStripMenuItem_Click);
            // 
            // preferinteToolStripMenuItem
            // 
            this.preferinteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marimeFontToolStripMenuItem,
            this.culoareToolStripMenuItem});
            this.preferinteToolStripMenuItem.Name = "preferinteToolStripMenuItem";
            this.preferinteToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.preferinteToolStripMenuItem.Text = "Preferinte";
            // 
            // marimeFontToolStripMenuItem
            // 
            this.marimeFontToolStripMenuItem.Name = "marimeFontToolStripMenuItem";
            this.marimeFontToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.marimeFontToolStripMenuItem.Text = "Marime font";
            this.marimeFontToolStripMenuItem.Click += new System.EventHandler(this.marimeFontToolStripMenuItem_Click);
            // 
            // culoareToolStripMenuItem
            // 
            this.culoareToolStripMenuItem.Name = "culoareToolStripMenuItem";
            this.culoareToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.culoareToolStripMenuItem.Text = "Culoare";
            this.culoareToolStripMenuItem.Click += new System.EventHandler(this.culoareToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cautaPersoanaToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cautaPersoanaToolStripMenuItem
            // 
            this.cautaPersoanaToolStripMenuItem.Name = "cautaPersoanaToolStripMenuItem";
            this.cautaPersoanaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cautaPersoanaToolStripMenuItem.Text = "Cauta persoana";
            this.cautaPersoanaToolStripMenuItem.Click += new System.EventHandler(this.cautaPersoanaToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Red;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLoad.Location = new System.Drawing.Point(30, 31);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(169, 49);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load data";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Red;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(751, 31);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(168, 49);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save data";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvContact
            // 
            this.dgvContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtContactID,
            this.txtFirstName,
            this.txtLastName,
            this.txtPhoneNumber,
            this.txtAdress,
            this.txtCity});
            this.dgvContact.Location = new System.Drawing.Point(30, 86);
            this.dgvContact.Name = "dgvContact";
            this.dgvContact.RowHeadersWidth = 51;
            this.dgvContact.RowTemplate.Height = 24;
            this.dgvContact.Size = new System.Drawing.Size(889, 458);
            this.dgvContact.TabIndex = 4;
            this.dgvContact.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvContact_UserDeletingRow);
            // 
            // txtContactID
            // 
            this.txtContactID.DataPropertyName = "ContactID";
            this.txtContactID.HeaderText = "ContactID";
            this.txtContactID.MinimumWidth = 6;
            this.txtContactID.Name = "txtContactID";
            this.txtContactID.Visible = false;
            this.txtContactID.Width = 125;
            // 
            // txtFirstName
            // 
            this.txtFirstName.DataPropertyName = "FirstName";
            this.txtFirstName.HeaderText = "First Name";
            this.txtFirstName.MinimumWidth = 6;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Width = 125;
            // 
            // txtLastName
            // 
            this.txtLastName.DataPropertyName = "LastName";
            this.txtLastName.HeaderText = "Last Name";
            this.txtLastName.MinimumWidth = 6;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Width = 125;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.DataPropertyName = "PhoneNumber";
            this.txtPhoneNumber.HeaderText = "Phone Number";
            this.txtPhoneNumber.MinimumWidth = 6;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Width = 125;
            // 
            // txtAdress
            // 
            this.txtAdress.DataPropertyName = "Adress";
            this.txtAdress.HeaderText = "Adress";
            this.txtAdress.MinimumWidth = 6;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Width = 125;
            // 
            // txtCity
            // 
            this.txtCity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtCity.DataPropertyName = "City";
            this.txtCity.HeaderText = "City";
            this.txtCity.MinimumWidth = 6;
            this.txtCity.Name = "txtCity";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(967, 569);
            this.Controls.Add(this.dgvContact);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "FrmMainWindow";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvContact;
        private System.Windows.Forms.ToolStripMenuItem preferinteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cautaPersoanaToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtContactID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAdress;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCity;
        private System.Windows.Forms.ToolStripMenuItem marimeFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem culoareToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}


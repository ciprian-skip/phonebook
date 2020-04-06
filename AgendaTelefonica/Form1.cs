using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Serialization;
using System.IO;

namespace AgendaTelefonica
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=DESKTOP-FFJAKKE\SQLEXPRESS; Initial Catalog=DGVDB; Integrated Security=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void serializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog filedialog = new SaveFileDialog();
                if (filedialog.ShowDialog() == DialogResult.OK)
                {
                    var path = filedialog.FileName;
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Persoana>));
                    StreamWriter writer = new StreamWriter(path);


                    serializer.Serialize(writer, dgvContact.DataSource);
                    writer.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Datele Nu s-au Salvat în Baza de Date ");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dgvContact.AllowUserToAddRows = false;

            if (dgvContact.RowCount != 0 )
            {
                dgvContact.AllowUserToAddRows = true;
                PopulateDataGridView();
               
            }

            else
            {
                
                PopulateDataGridView();
                if (dgvContact.RowCount == 0)

                {
                    MessageBox.Show("Nici un abonat găsit în bază.");
                    dgvContact.AllowUserToAddRows = true;
                }

                }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvContact.CurrentRow != null)
                {
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        DataGridViewRow dgvRow = dgvContact.CurrentRow;
                        SqlCommand sqlCmd = new SqlCommand("ContactAddOrEdit", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        if (dgvRow.Cells["txtContactID"].Value == DBNull.Value)   //insert
                            sqlCmd.Parameters.AddWithValue("@ContactID", 0);
                        else                                                    //update
                            sqlCmd.Parameters.AddWithValue("@ContactID", Convert.ToInt32(dgvRow.Cells["txtContactID"].Value));

                        sqlCmd.Parameters.AddWithValue("@FirstName", dgvRow.Cells["txtFirstName"].Value == DBNull.Value ? "" : dgvRow.Cells["txtFirstName"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@LastName", dgvRow.Cells["txtLastName"].Value == DBNull.Value ? "" : dgvRow.Cells["txtLastName"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@PhoneNumber", dgvRow.Cells["txtPhoneNumber"].Value == DBNull.Value ? "" : dgvRow.Cells["txtPhoneNumber"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@Adress", dgvRow.Cells["txtAdress"].Value == DBNull.Value ? "" : dgvRow.Cells["txtAdress"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@City", dgvRow.Cells["txtCity"].Value == DBNull.Value ? "" : dgvRow.Cells["txtCity"].Value.ToString());
                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Date Salvate cu Succes în Baza de Date");
                        PopulateDataGridView();
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Datele Nu s-au Salvat în Baza de Date ");
            }
        }

        private void dgvContact_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    /*    private void Form1_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        } 
        */
        
        void PopulateDataGridView()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Contact", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgvContact.DataSource = dtbl;

            }
        }



        private void dgvContact_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if(dgvContact.CurrentRow.Cells["txtContactID"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Esti Sigur ca Vrei sa Stergi din Baza de Date?", "DataGridView", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("ContactDeleteByID", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@ContactID", Convert.ToInt32(dgvContact.CurrentRow.Cells["txtContactID"].Value));
                        sqlCmd.ExecuteNonQuery();
                    }
                }
                else
                    e.Cancel = true;

            }
        }

        private void marimeFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fnt = new FontDialog();
            if(fnt.ShowDialog() == DialogResult.OK)
            {
                dgvContact.Font = fnt.Font;
            }

        }

       private void culoareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog() ;
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.FormBackground = colorDlg.Color;
                Properties.Settings.Default.Save();
                this.BackColor = colorDlg.Color;
            }

            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Sunteti sigur ca doriti sa iesiti?", "Exit", MessageBoxButtons.YesNo);
            if(dialog == DialogResult.Yes)
            {
                Application.Exit();

            }
            else if (dialog == DialogResult.No)
            {
                
                //      e.Close();
            }
        }

        private void cautaPersoanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 openForm = new Form2();
            openForm.Show();
        }

    } 
}

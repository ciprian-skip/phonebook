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

namespace AgendaTelefonica
{
    public partial class Form2 : Form
    {
        string connectionString = @"Data Source=DESKTOP-FFJAKKE\SQLEXPRESS; Initial Catalog=DGVDB; Integrated Security=True;";
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                FillDataGridView();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare mesaj");
            }
        }
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
        void FillDataGridView()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("ContactViewOrSearch", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@ContactName", txtSearch.Text.Trim());
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgvContact.DataSource = dtbl;
                 sqlCon.Close();
            }
        }



        /*   private void Form2_Load(object sender, EventArgs e)
           {
               PopulateDataGridView();
           } */
    }
}

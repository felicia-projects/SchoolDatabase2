
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SchoolDatabase
{
    public partial class classDelete : Form
    {
        public classDelete()
        {
            InitializeComponent();
        }

        private void classDelete_Load(object sender, EventArgs e)
        {
            LoadClasses();
        }

        private void LoadClasses()
        {
            using (SqlConnection conn = Form1.DatabaseConnection.GetConnection())
            {
                try
                {
                    string query = "SELECT * FROM Class_Section";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                    dataGridView1.ReadOnly = true;
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridView1.MultiSelect = false;
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.AllowUserToDeleteRows = false;

                    dataGridView1.ClearSelection();
                    dataGridView1.CurrentCell = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading classes: " + ex.Message);
                }
            }
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Before deleting a class, we need to confirm the primary key of Class_Section.");
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

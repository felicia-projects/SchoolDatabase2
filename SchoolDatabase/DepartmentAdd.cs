using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SchoolDatabase
{
    public partial class DepartmentAdd : Form
    {
        public DepartmentAdd()
        {
            InitializeComponent();
        }

        private void DepartmentSavebtn_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Department (DepartmentID, DepartmentName, DepartmentDescription) " +
                           "VALUES (@DepartmentID, @DepartmentName, @DepartmentDescription)";

            using (SqlConnection conn = Form1.DatabaseConnection.GetConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.Add("@DepartmentID", SqlDbType.Int).Value = int.Parse(DIDTextbox.Text.Trim());
                    cmd.Parameters.Add("@DepartmentName", SqlDbType.VarChar).Value = DNTextBox.Text.Trim();
                    cmd.Parameters.Add("@DepartmentDescription", SqlDbType.VarChar).Value = DDTextbox.Text.Trim();

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Department added successfully!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void DepartmentAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
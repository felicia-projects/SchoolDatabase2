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
            String query = "INSERT INTO Department (DepartmentID, DepartmentName, DepartmentDescription) VALUES (@DepartmentID, @DepartmentName, @DepartmentDescription)";

            using (SqlConnection conn = Form1.DatabaseConnection.GetConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.Add("@DepartmentID", SqlDbType.Int).Value = DIDTextbox.Text;
                    cmd.Parameters.Add("@DepartmentName", SqlDbType.VarChar).Value = DNTextBox.Text;
                    cmd.Parameters.Add("@DepartmentDescription", SqlDbType.VarChar).Value = DDTextbox.Text;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Department added successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}

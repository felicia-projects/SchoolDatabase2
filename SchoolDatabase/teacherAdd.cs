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
    public partial class teacherAdd : Form
    {
        public teacherAdd()
        {
            InitializeComponent();
        }

        private void teacherAdd_Load(object sender, EventArgs e)
        {

        }

        private void teacherSavebtn_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Teacher (TeacherID, FirstName, LastName, Email, PhoneNumber, DepartmentKey) VALUES (@TeacherID, @FirstName, @LastName, @Email, @PhoneNumber, @DepartmentKey)";

            using (SqlConnection conn = Form1.DatabaseConnection.GetConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TeacherID", TIDTextbox.Text);
                    cmd.Parameters.AddWithValue("@FirstName", TFNLabel.Text);
                    cmd.Parameters.AddWithValue("@LastName", TLNLabel.Text);
                    cmd.Parameters.AddWithValue("@Email", TEmTextbox.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", TPNLabel.Text);
                    cmd.Parameters.AddWithValue("@DepartmentKey", TDKLabel.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher added successfully!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}

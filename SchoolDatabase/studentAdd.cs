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
    public partial class studentAdd : Form
    {
        public studentAdd()
        {
            InitializeComponent();
        }

        private void studentSavebtn_Click(object sender, EventArgs e)
        {
            
            String query = "INSERT INTO Student (StudentID ,FirstName, LastName, DateOfBirth, Email, PhoneNumber, GradeLevel, EnrollmentDate) VALUES (@StudentID, @FirstName, @LastName, @DateOfBirth, @Email, @PhoneNumber, @GradeLevel, @EnrollmentDate)";

            using (SqlConnection conn = Form1.DatabaseConnection.GetConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@StudentID", SIDTextbox.Text);
                    cmd.Parameters.AddWithValue("@FirstName", FNTextbox.Text);
                    cmd.Parameters.AddWithValue("@LastName", LNTextbox.Text);
                    cmd.Parameters.AddWithValue("@DateOfBirth", DOBTextbox.Text);
                    cmd.Parameters.AddWithValue("@Email", EmailTextbox.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", PNTextbox.Text);
                    cmd.Parameters.AddWithValue("@GradeLevel", GLTextbox.Text);
                    cmd.Parameters.AddWithValue("@EnrollmentDate", EDTextbox.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student added successfully!");

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void studentAdd_Load(object sender, EventArgs e)
        {

        }
    }
}

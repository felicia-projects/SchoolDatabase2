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
    public partial class courseAdd : Form
    {
        public courseAdd()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CourseSavebtn_Click(object sender, EventArgs e)
        {
            String query = "INSERT INTO Course (CourseID, CourseName, CourseDescription, DepartmentID, Credits) VALUES (@CourseID, @CourseName, @CourseDescription, @DepartmentID, @Credits)";

            using (SqlConnection conn = Form1.DatabaseConnection.GetConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CourseID", CourseIDTextbox.Text);
                    cmd.Parameters.AddWithValue("@CourseName", CourseNameTextbox.Text);
                    cmd.Parameters.AddWithValue("@CourseDescription", CourseDescriptionTextbox.Text);
                    cmd.Parameters.AddWithValue("@DepartmentID", CDepartmentIDTextbox.Text);
                    cmd.Parameters.AddWithValue("@Credits", CourseCreditsTextbox.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Course added successfully!");
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

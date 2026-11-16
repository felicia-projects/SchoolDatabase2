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
            string query = "INSERT INTO Course (CourseID, CourseName, CourseDescription, DepartmentID, Credits) " +
                           "VALUES (@CourseID, @CourseName, @CourseDescription, @DepartmentID, @Credits)";

            using (SqlConnection conn = Form1.DatabaseConnection.GetConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.Add("@CourseID", SqlDbType.Int).Value = int.Parse(CourseIDTextbox.Text.Trim());
                    cmd.Parameters.Add("@CourseName", SqlDbType.VarChar).Value = CourseNameTextbox.Text.Trim();
                    cmd.Parameters.Add("@CourseDescription", SqlDbType.VarChar).Value = CourseDescriptionTextbox.Text.Trim();
                    cmd.Parameters.Add("@DepartmentID", SqlDbType.Int).Value = int.Parse(CDepartmentIDTextbox.Text.Trim());
                    cmd.Parameters.Add("@Credits", SqlDbType.Int).Value = int.Parse(CourseCreditsTextbox.Text.Trim());

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

        private void courseAdd_Load(object sender, EventArgs e)
        {

        }
    }
}

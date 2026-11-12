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
    public partial class classAdd : Form
    {
        public classAdd()
        {
            InitializeComponent();
        }

        private void CSectionIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void CSearchbtn_Click(object sender, EventArgs e)
        {
            String query = "INSERT INTO Class (SectionID, CourseID, TeacherID, RoomNumber, Semester, SchoolYear, Capacity) VALUES (@SectionID, @CourseID, @TeacherID, @RoomNumber, @Semester, @SchoolYear, @Capacity)";

            using (SqlConnection conn = Form1.DatabaseConnection.GetConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@SectionID", CSectionIDTextbox.Text);
                    cmd.Parameters.AddWithValue("@CourseID", CCourseIDTextbox.Text);
                    cmd.Parameters.AddWithValue("@TeacherID", CTeacherIDTextbox.Text);
                    cmd.Parameters.AddWithValue("@RoomNumber", CRNTextbox.Text);
                    cmd.Parameters.AddWithValue("@Semester", CSTextbox.Text);
                    cmd.Parameters.AddWithValue("@SchoolYear", CSYTextbox.Text);
                    cmd.Parameters.AddWithValue("@Capacity", CCTextbox.Text);
                    
                    
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Class added successfully!");
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

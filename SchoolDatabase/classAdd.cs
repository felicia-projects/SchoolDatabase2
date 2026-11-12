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
            string query = "INSERT INTO Class_Section (SectionID, CourseID, TeacherID, RoomNumber, Semester, SchoolYear, Capacity) " +
                           "VALUES (@SectionID, @CourseID, @TeacherID, @RoomNumber, @Semester, @SchoolYear, @Capacity)";

            using (SqlConnection conn = Form1.DatabaseConnection.GetConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.Add("@SectionID", SqlDbType.Int).Value = int.Parse(CSectionIDTextbox.Text.Trim());
                    cmd.Parameters.Add("@CourseID", SqlDbType.Int).Value = int.Parse(CCourseIDTextbox.Text.Trim());
                    cmd.Parameters.Add("@TeacherID", SqlDbType.Int).Value = int.Parse(CTeacherIDTextbox.Text.Trim());
                    cmd.Parameters.Add("@RoomNumber", SqlDbType.VarChar).Value = CRNTextbox.Text.Trim();
                    cmd.Parameters.Add("@Semester", SqlDbType.VarChar).Value = CSTextbox.Text.Trim();
                    cmd.Parameters.Add("@SchoolYear", SqlDbType.Int).Value = int.Parse(CSYTextbox.Text.Trim());
                    cmd.Parameters.Add("@Capacity", SqlDbType.Int).Value = int.Parse(CCTextbox.Text.Trim());

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

        private void classAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
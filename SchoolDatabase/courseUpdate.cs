
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SchoolDatabase
{
    public partial class courseUpdate : Form
    {
        public courseUpdate()
        {
            InitializeComponent();
        }

        private void courseUpdate_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

            txtCourseID.ReadOnly = true;
            btnSave.Enabled = false;

            LoadCourses();
        }

        private void LoadCourses()
        {
            using (SqlConnection conn = Form1.DatabaseConnection.GetConnection())
            {
                try
                {
                    string query = @"SELECT CourseID, CourseName,
                        CourseDescription, DepartmentID, Credits
                        FROM Course";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                    dataGridView1.ClearSelection();
                    dataGridView1.CurrentCell = null;

                    ClearFields();
                }
                catch (Exception ex)
                {
                    dataGridView1.DataSource = null;
                    ClearFields();
                    MessageBox.Show("Error loading courses: " + ex.Message);
                }
            }
        }

        private void ClearFields()
        {
            txtCourseID.Clear();
            txtCourseName.Clear();
            txtCourseDescription.Clear();
            txtDepartmentID.Clear();
            txtCredits.Clear();

            btnSave.Enabled = false;
        }

        private void dataGridView1_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            txtCourseID.Text =
                Convert.ToString(row.Cells["CourseID"].Value);

            txtCourseName.Text =
                Convert.ToString(row.Cells["CourseName"].Value);

            txtCourseDescription.Text =
                Convert.ToString(row.Cells["CourseDescription"].Value);

            txtDepartmentID.Text =
                Convert.ToString(row.Cells["DepartmentID"].Value);

            txtCredits.Text =
                Convert.ToString(row.Cells["Credits"].Value);

            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCourseID.Text, out int courseID))
            {
                MessageBox.Show("Please select a course to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCourseName.Text))
            {
                MessageBox.Show("Please enter the course name.");
                return;
            }

            if (!int.TryParse(txtDepartmentID.Text, out int departmentID))
            {
                MessageBox.Show("Please enter a valid Department ID.");
                return;
            }

            if (!int.TryParse(txtCredits.Text, out int credits))
            {
                MessageBox.Show("Please enter a valid number of credits.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to update this course?",
                "Confirm Update",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            using (SqlConnection conn = Form1.DatabaseConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"UPDATE Course
                        SET CourseName = @CourseName,
                            CourseDescription = @CourseDescription,
                            DepartmentID = @DepartmentID,
                            Credits = @Credits
                        WHERE CourseID = @CourseID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@CourseID", SqlDbType.Int).Value =
                            courseID;

                        cmd.Parameters.AddWithValue(
                            "@CourseName", txtCourseName.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@CourseDescription", txtCourseDescription.Text.Trim());

                        cmd.Parameters.Add("@DepartmentID", SqlDbType.Int).Value =
                            departmentID;

                        cmd.Parameters.Add("@Credits", SqlDbType.Int).Value =
                            credits;

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Course updated successfully!");
                            LoadCourses();
                        }
                        else
                        {
                            MessageBox.Show("Course not found.");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547)
                    {
                        MessageBox.Show(
                            "Cannot update the course. The Department ID may not exist.");
                    }
                    else
                    {
                        MessageBox.Show("SQL error updating course: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating course: " + ex.Message);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

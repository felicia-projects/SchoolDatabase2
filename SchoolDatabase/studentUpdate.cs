
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SchoolDatabase
{
    public partial class studentUpdate : Form
    {
        public studentUpdate()
        {
            InitializeComponent();
        }

        private void studentUpdate_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

            txtStudentID.ReadOnly = true;
            btnSave.Enabled = false;

            LoadStudents();
        }

        private void LoadStudents()
        {
            using (SqlConnection conn = Form1.DatabaseConnection.GetConnection())
            {
                try
                {
                    string query = "SELECT StudentID, FirstName, LastName, DateOfBirth, Email, PhoneNumber, GradeLevel, EnrollmentDate FROM Student";

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
                    MessageBox.Show("Error loading students: " + ex.Message);
                }
            }
        }

        private void ClearFields()
        {
            txtStudentID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhoneNumber.Clear();
            txtGradeLevel.Clear();

            dtpDateOfBirth.Value = DateTime.Today;
            dtpEnrollmentDate.Value = DateTime.Today;

            btnSave.Enabled = false;
        }

        private void dataGridView1_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            txtStudentID.Text =
                Convert.ToString(row.Cells["StudentID"].Value);

            txtFirstName.Text =
                Convert.ToString(row.Cells["FirstName"].Value);

            txtLastName.Text =
                Convert.ToString(row.Cells["LastName"].Value);

            txtEmail.Text =
                Convert.ToString(row.Cells["Email"].Value);

            txtPhoneNumber.Text =
                Convert.ToString(row.Cells["PhoneNumber"].Value);

            txtGradeLevel.Text =
                Convert.ToString(row.Cells["GradeLevel"].Value);

            if (row.Cells["DateOfBirth"].Value != DBNull.Value &&
                row.Cells["DateOfBirth"].Value != null)
            {
                dtpDateOfBirth.Value =
                    Convert.ToDateTime(row.Cells["DateOfBirth"].Value);
            }
            else
            {
                dtpDateOfBirth.Value = DateTime.Today;
            }

            if (row.Cells["EnrollmentDate"].Value != DBNull.Value &&
                row.Cells["EnrollmentDate"].Value != null)
            {
                dtpEnrollmentDate.Value =
                    Convert.ToDateTime(row.Cells["EnrollmentDate"].Value);
            }
            else
            {
                dtpEnrollmentDate.Value = DateTime.Today;
            }

            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtStudentID.Text, out int studentID))
            {
                MessageBox.Show("Please select a student to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Please enter the student's first and last name.");
                return;
            }

            if (!int.TryParse(txtGradeLevel.Text, out int gradeLevel))
            {
                MessageBox.Show("Please enter a valid numeric grade level.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to update this student?",
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

                    string query = @"UPDATE Student
                        SET FirstName = @FirstName,
                            LastName = @LastName,
                            DateOfBirth = @DateOfBirth,
                            Email = @Email,
                            PhoneNumber = @PhoneNumber,
                            GradeLevel = @GradeLevel,
                            EnrollmentDate = @EnrollmentDate
                        WHERE StudentID = @StudentID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@StudentID", SqlDbType.Int).Value = studentID;

                        cmd.Parameters.AddWithValue(
                            "@FirstName", txtFirstName.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@LastName", txtLastName.Text.Trim());

                        cmd.Parameters.Add("@DateOfBirth", SqlDbType.Date).Value =
                            dtpDateOfBirth.Value.Date;

                        cmd.Parameters.AddWithValue(
                            "@Email", txtEmail.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@PhoneNumber", txtPhoneNumber.Text.Trim());

                        cmd.Parameters.Add("@GradeLevel", SqlDbType.Int).Value =
                            gradeLevel;

                        cmd.Parameters.Add("@EnrollmentDate", SqlDbType.Date).Value =
                            dtpEnrollmentDate.Value.Date;

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student updated successfully!");
                            LoadStudents();
                        }
                        else
                        {
                            MessageBox.Show("Student not found.");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("SQL error updating student: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating student: " + ex.Message);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}

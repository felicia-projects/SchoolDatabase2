
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SchoolDatabase
{
    public partial class teacherUpdate : Form
    {
        public teacherUpdate()
        {
            InitializeComponent();
        }

        private void teacherUpdate_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

            txtTeacherID.ReadOnly = true;
            btnSave.Enabled = false;

            LoadTeachers();
        }

        private void LoadTeachers()
        {
            using (SqlConnection conn = Form1.DatabaseConnection.GetConnection())
            {
                try
                {
                    string query = "SELECT TeacherID, FirstName, LastName, Email, PhoneNumber, DepartmentID FROM Teacher";

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
                    MessageBox.Show("Error loading teachers: " + ex.Message);
                }
            }
        }

        private void ClearFields()
        {
            txtTeacherID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhoneNumber.Clear();
            txtDepartmentID.Clear();

            btnSave.Enabled = false;
        }

        private void dataGridView1_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            txtTeacherID.Text =
                Convert.ToString(row.Cells["TeacherID"].Value);

            txtFirstName.Text =
                Convert.ToString(row.Cells["FirstName"].Value);

            txtLastName.Text =
                Convert.ToString(row.Cells["LastName"].Value);

            txtEmail.Text =
                Convert.ToString(row.Cells["Email"].Value);

            txtPhoneNumber.Text =
                Convert.ToString(row.Cells["PhoneNumber"].Value);

            txtDepartmentID.Text =
                Convert.ToString(row.Cells["DepartmentID"].Value);

            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtTeacherID.Text, out int teacherID))
            {
                MessageBox.Show("Please select a teacher to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Please enter the teacher's first and last name.");
                return;
            }

            if (!int.TryParse(txtDepartmentID.Text, out int departmentID))
            {
                MessageBox.Show("Please enter a valid Department ID.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to update this teacher?",
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

                    string query = @"UPDATE Teacher
                        SET FirstName = @FirstName,
                            LastName = @LastName,
                            Email = @Email,
                            PhoneNumber = @PhoneNumber,
                            DepartmentID = @DepartmentID
                        WHERE TeacherID = @TeacherID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@TeacherID", SqlDbType.Int).Value =
                            teacherID;

                        cmd.Parameters.AddWithValue(
                            "@FirstName", txtFirstName.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@LastName", txtLastName.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@Email", txtEmail.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@PhoneNumber", txtPhoneNumber.Text.Trim());

                        cmd.Parameters.Add("@DepartmentID", SqlDbType.Int).Value =
                            departmentID;

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Teacher updated successfully!");
                            LoadTeachers();
                        }
                        else
                        {
                            MessageBox.Show("Teacher not found.");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547)
                    {
                        MessageBox.Show(
                            "Cannot update teacher. The Department ID may not exist.");
                    }
                    else
                    {
                        MessageBox.Show("SQL error updating teacher: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating teacher: " + ex.Message);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

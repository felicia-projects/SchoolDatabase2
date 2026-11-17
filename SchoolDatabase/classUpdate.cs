
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SchoolDatabase
{
    public partial class classUpdate : Form
    {
        public classUpdate()
        {
            InitializeComponent();
        }

        private void classUpdate_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

            txtSectionID.ReadOnly = true;
            btnSave.Enabled = false;

            LoadClasses();
        }

        private void LoadClasses()
        {
            using (SqlConnection conn = Form1.DatabaseConnection.GetConnection())
            {
                try
                {
                    string query = @"SELECT SectionID, CourseID, TeacherID,
                                     PeriodID, RoomNumber, Semester,
                                     SchoolYear, Capacity
                                     FROM Class_Section";

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
                    MessageBox.Show("Error loading classes: " + ex.Message);
                }
            }
        }

        private void ClearFields()
        {
            txtSectionID.Clear();
            txtCourseID.Clear();
            txtTeacherID.Clear();
            txtPeriodID.Clear();
            txtRoomNumber.Clear();
            txtSemester.Clear();
            txtSchoolYear.Clear();
            txtCapacity.Clear();

            btnSave.Enabled = false;
        }

        private void dataGridView1_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            txtSectionID.Text =
                Convert.ToString(row.Cells["SectionID"].Value);

            txtCourseID.Text =
                Convert.ToString(row.Cells["CourseID"].Value);

            txtTeacherID.Text =
                Convert.ToString(row.Cells["TeacherID"].Value);

            txtPeriodID.Text =
                Convert.ToString(row.Cells["PeriodID"].Value);

            txtRoomNumber.Text =
                Convert.ToString(row.Cells["RoomNumber"].Value);

            txtSemester.Text =
                Convert.ToString(row.Cells["Semester"].Value);

            txtSchoolYear.Text =
                Convert.ToString(row.Cells["SchoolYear"].Value);

            txtCapacity.Text =
                Convert.ToString(row.Cells["Capacity"].Value);

            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSectionID.Text, out int sectionID))
            {
                MessageBox.Show("Please select a class to update.");
                return;
            }

            if (!int.TryParse(txtCourseID.Text, out int courseID) ||
                !int.TryParse(txtTeacherID.Text, out int teacherID) ||
                !int.TryParse(txtPeriodID.Text, out int periodID) ||
                !int.TryParse(txtSchoolYear.Text, out int schoolYear) ||
                !int.TryParse(txtCapacity.Text, out int capacity))
            {
                MessageBox.Show("Please enter valid numbers for the ID, school year, and capacity fields.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtRoomNumber.Text) ||
                string.IsNullOrWhiteSpace(txtSemester.Text))
            {
                MessageBox.Show("Please enter a room number and semester.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to update this class?",
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

                    string query = @"UPDATE Class_Section
                        SET CourseID = @CourseID,
                            TeacherID = @TeacherID,
                            PeriodID = @PeriodID,
                            RoomNumber = @RoomNumber,
                            Semester = @Semester,
                            SchoolYear = @SchoolYear,
                            Capacity = @Capacity
                        WHERE SectionID = @SectionID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@SectionID", SqlDbType.Int).Value = sectionID;
                        cmd.Parameters.Add("@CourseID", SqlDbType.Int).Value = courseID;
                        cmd.Parameters.Add("@TeacherID", SqlDbType.Int).Value = teacherID;
                        cmd.Parameters.Add("@PeriodID", SqlDbType.Int).Value = periodID;
                        cmd.Parameters.Add("@RoomNumber", SqlDbType.VarChar, 50).Value =
                            txtRoomNumber.Text.Trim();
                        cmd.Parameters.Add("@Semester", SqlDbType.VarChar, 50).Value =
                            txtSemester.Text.Trim();
                        cmd.Parameters.Add("@SchoolYear", SqlDbType.Int).Value = schoolYear;
                        cmd.Parameters.Add("@Capacity", SqlDbType.Int).Value = capacity;

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Class updated successfully!");
                            LoadClasses();
                        }
                        else
                        {
                            MessageBox.Show("Class not found.");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547)
                    {
                        MessageBox.Show(
                            "Cannot update the class. A related Course, Teacher, or Period ID may be invalid.");
                    }
                    else
                    {
                        MessageBox.Show("SQL error updating class: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating class: " + ex.Message);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

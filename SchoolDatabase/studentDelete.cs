
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SchoolDatabase
{
    public partial class studentDelete : Form
    {
        public studentDelete()
        {
            InitializeComponent();
        }

        private void studentDelete_Load(object sender, EventArgs e)
        {
 
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
                    dataGridView1.ReadOnly = true;
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridView1.MultiSelect = false;
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.AllowUserToDeleteRows = false;

                    dataGridView1.ClearSelection();
                    dataGridView1.CurrentCell = null;

        
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading students: " + ex.Message);
                }
            }
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null ||
                dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select a student to delete.");
                return;
            }

            object? studentID =
                dataGridView1.CurrentRow.Cells["StudentID"].Value;

            if (studentID == null || studentID == DBNull.Value)
            {
                MessageBox.Show("Invalid student selected.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this student?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            using (SqlConnection conn = Form1.DatabaseConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = "DELETE FROM Student WHERE StudentID = @StudentID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", studentID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student deleted successfully!");
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
                    if (ex.Number == 547)
                    {
                        MessageBox.Show(
                            "Cannot delete this student because other records depend on it.");
                    }
                    else
                    {
                        MessageBox.Show("Error deleting student: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting student: " + ex.Message);
                }
            }
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

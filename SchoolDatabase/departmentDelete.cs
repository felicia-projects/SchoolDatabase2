
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SchoolDatabase
{
    public partial class departmentDelete : Form
    {
        public departmentDelete()
        {
            InitializeComponent();
        }

        private void departmentDelete_Load(object sender, EventArgs e)
        {
            LoadDepartments();
        }

        private void LoadDepartments()
        {
            using (SqlConnection conn = Form1.DatabaseConnection.GetConnection())
            {
                try
                {
                    string query = "SELECT DepartmentID, DepartmentName, DepartmentDescription FROM Department";

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
                    MessageBox.Show("Error loading departments: " + ex.Message);
                }
            }
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null ||
                dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select a department to delete.");
                return;
            }

            object? departmentID =
                dataGridView1.CurrentRow.Cells["DepartmentID"].Value;

            if (departmentID == null || departmentID == DBNull.Value)
            {
                MessageBox.Show("Invalid department selected.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this department?",
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

                    string query =
                        "DELETE FROM Department WHERE DepartmentID = @DepartmentID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@DepartmentID", departmentID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Department deleted successfully!");
                            LoadDepartments();
                        }
                        else
                        {
                            MessageBox.Show("Department not found.");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547)
                    {
                        MessageBox.Show(
                            "Cannot delete this department because other records depend on it.");
                    }
                    else
                    {
                        MessageBox.Show("Error deleting department: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting department: " + ex.Message);
                }
            }
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

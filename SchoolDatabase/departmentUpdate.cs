
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SchoolDatabase
{
    public partial class departmentUpdate : Form
    {
        public departmentUpdate()
        {
            InitializeComponent();
        }

        private void departmentUpdate_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

            txtDepartmentID.ReadOnly = true;
            btnSave.Enabled = false;

            LoadDepartments();
        }

        private void LoadDepartments()
        {
            using (SqlConnection conn =
                Form1.DatabaseConnection.GetConnection())
            {
                try
                {
                    string query = @"SELECT DepartmentID,
                        DepartmentName, DepartmentDescription
                        FROM Department";

                    using (SqlDataAdapter adapter =
                        new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridView1.DataSource = dt;
                        dataGridView1.ClearSelection();
                        dataGridView1.CurrentCell = null;

                        ClearFields();
                    }
                }
                catch (Exception ex)
                {
                    dataGridView1.DataSource = null;
                    ClearFields();
                    MessageBox.Show(
                        "Error loading departments: " + ex.Message);
                }
            }
        }

        private void ClearFields()
        {
            txtDepartmentID.Clear();
            txtDepartmentName.Clear();
            txtDepartmentDescription.Clear();

            btnSave.Enabled = false;
        }

        private void dataGridView1_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            txtDepartmentID.Text =
                Convert.ToString(row.Cells["DepartmentID"].Value);

            txtDepartmentName.Text =
                Convert.ToString(row.Cells["DepartmentName"].Value);

            txtDepartmentDescription.Text =
                Convert.ToString(row.Cells["DepartmentDescription"].Value);

            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDepartmentID.Text,
                out int departmentID))
            {
                MessageBox.Show(
                    "Please select a department to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDepartmentName.Text))
            {
                MessageBox.Show(
                    "Please enter a department name.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to update this department?",
                "Confirm Update",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            using (SqlConnection conn =
                Form1.DatabaseConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"UPDATE Department
                        SET DepartmentName = @DepartmentName,
                            DepartmentDescription = @DepartmentDescription
                        WHERE DepartmentID = @DepartmentID";

                    using (SqlCommand cmd =
                        new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add(
                            "@DepartmentID", SqlDbType.Int).Value =
                            departmentID;

                        cmd.Parameters.AddWithValue(
                            "@DepartmentName",
                            txtDepartmentName.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@DepartmentDescription",
                            txtDepartmentDescription.Text.Trim());

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show(
                                "Department updated successfully!");

                            LoadDepartments();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Department not found.");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(
                        "SQL error updating department: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error updating department: " + ex.Message);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

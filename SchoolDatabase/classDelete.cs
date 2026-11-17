
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SchoolDatabase
{
    public partial class classDelete : Form
    {
        public classDelete()
        {
            InitializeComponent();
        }

        private void classDelete_Load(object sender, EventArgs e)
        {
            LoadClasses();
        }

        private void LoadClasses()
        {
            using (SqlConnection conn =
                Form1.DatabaseConnection.GetConnection())
            {
                try
                {
                    string query = "SELECT * FROM Class_Section";

                    using (SqlDataAdapter adapter =
                        new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridView1.DataSource = dt;
                    }

                    dataGridView1.ReadOnly = true;
                    dataGridView1.SelectionMode =
                        DataGridViewSelectionMode.FullRowSelect;
                    dataGridView1.MultiSelect = false;
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.AllowUserToDeleteRows = false;

                    dataGridView1.ClearSelection();
                    dataGridView1.CurrentCell = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error loading classes: " + ex.Message);
                }
            }
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null ||
                dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show(
                    "Please select a class to delete.");
                return;
            }

            object? sectionID =
                dataGridView1.CurrentRow.Cells["SectionID"].Value;

            if (sectionID == null || sectionID == DBNull.Value)
            {
                MessageBox.Show("Invalid class selected.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this class?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            using (SqlConnection conn =
                Form1.DatabaseConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query =
                        "DELETE FROM Class_Section WHERE SectionID = @SectionID";

                    using (SqlCommand cmd =
                        new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add(
                            "@SectionID", SqlDbType.Int).Value =
                            Convert.ToInt32(sectionID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show(
                                "Class deleted successfully!");

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
                            "Cannot delete this class because other records depend on it.");
                    }
                    else
                    {
                        MessageBox.Show(
                            "SQL error deleting class: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error deleting class: " + ex.Message);
                }
            }
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

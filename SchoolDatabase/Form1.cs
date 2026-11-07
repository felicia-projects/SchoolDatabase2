using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.Devices;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.LinkLabel;

namespace SchoolDatabase
{
    public partial class Form1 : Form
    {
        public static class DatabaseConnection
        {
            private static string connectionString = @"Server=FELICIA;Initial Catalog=School;Integrated Security=True; Trust Server Certificate=True;";

            public static SqlConnection GetConnection()
            {
                SqlConnection connection = new SqlConnection(connectionString);
                return connection;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            panelStudent.BringToFront();

            //LoadStudentsData();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            panelStudent.BringToFront();

            //LoadStudentsData();

        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            panelStudent.BringToFront();

            //LoadStudentsData();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataIntoGrid("SELECT StudentID, FirstName, LastName, DateOfBirth, Email, PhoneNumber, GradeLevel, EnrollmentDate FROM Student");
        }

        private void LoadDataIntoGrid(string query)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data" + ex.Message);
                }
            }
        }
    }
}

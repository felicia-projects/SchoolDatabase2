using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.Devices;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.LinkLabel;

namespace SchoolDatabase
{
    public partial class Form1 : Form
    {
        private string activeTable = "Student"; // Default active table
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void studentButton_Click(object sender, EventArgs e)
        {
            activeTable = "Student"; // Set active table to Student
            SSTextbox.Visible = true;
            SSbtn.Visible = true;
            SSLabel.Visible = true;
            LoadDataIntoGrid("SELECT StudentID, FirstName, LastName, DateOfBirth, Email, PhoneNumber, GradeLevel, EnrollmentDate FROM Student");
        }

        private void teacherButton_Click(object sender, EventArgs e)
        {
            activeTable = "Teacher"; // Set active table to Teacher
            SSTextbox.Visible = false;
            SSbtn.Visible = false;
            SSLabel.Visible = false;
            LoadDataIntoGrid("SELECT * FROM Teacher");
        }

        private void classbutton_Click(object sender, EventArgs e)
        {
            activeTable = "Class"; // Set active table to Class
            SSTextbox.Visible = false;
            SSbtn.Visible = false;
            SSLabel.Visible = false;
            LoadDataIntoGrid("SELECT * FROM Class_Section");
        }

        private void courseButton_Click(object sender, EventArgs e)
        {
            activeTable = "Course"; // Set active table to Course
            SSTextbox.Visible = false;
            SSbtn.Visible = false;
            SSLabel.Visible = false;
            LoadDataIntoGrid("SELECT * FROM Course");
        }

        private void reportsButton_Click(object sender, EventArgs e)
        {
            activeTable = "Report"; // Set active table to Report
            SSTextbox.Visible = false;
            SSbtn.Visible = false;
            SSLabel.Visible = false;
            LoadDataIntoGrid("SELECT * FROM Report");
        }

        private void panelStudentControls_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {

            switch (activeTable)
            {

                case "Student":
                    studentAdd addForm = new studentAdd();
                    addForm.ShowDialog();

                    LoadDataIntoGrid("SELECT StudentID, FirstName, LastName, DateOfBirth, Email, PhoneNumber, GradeLevel, EnrollmentDate FROM Student");
                    break;
                case "Teacher":
                    MessageBox.Show("Will add later");
                    break;
                case "Class":
                    MessageBox.Show("Will add later");
                    break;
                case "Course":
                    MessageBox.Show("Will add later");
                    break;
                case "Report":
                    MessageBox.Show("Will add later");
                    break;
            }
            MessageBox.Show("Add functionality for " + activeTable + " Query ready!");
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            string query = "";
            switch (activeTable)
            {
                case "Student":
                    query = "UPDATE Student SET FirstName = @FirstName, LastName = @LastName, DateOfBirth = @DateOfBirth, Email = @Email, PhoneNumber = @PhoneNumber, GradeLevel = @GradeLevel, EnrollmentDate = @EnrollmentDate WHERE StudentID = @StudentID";
                    break;
                case "Teacher":
                    query = "UPDATE Teacher SET FirstName = @FirstName, LastName = @LastName, Subject = @Subject WHERE TeacherID = @TeacherID";
                    break;
                case "Class":
                    query = "UPDATE Class SET ClassName = @ClassName, TeacherID = @TeacherID WHERE ClassID = @ClassID";
                    break;
                case "Course":
                    query = "UPDATE Course SET CourseName = @CourseName, Credits = @Credits WHERE CourseID = @CourseID";
                    break;
                case "Report":
                    query = "UPDATE Report SET ReportTitle = @ReportTitle, ReportDate = @ReportDate WHERE ReportID = @ReportID";
                    break;
            }
            MessageBox.Show("Update functionality for " + activeTable);
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            string query = "";
            switch (activeTable)
            {
                case "Student":
                    query = "DELETE FROM Student WHERE StudentID = @StudentID";
                    break;
                case "Teacher":
                    query = "DELETE FROM Teacher WHERE TeacherID = @TeacherID";
                    break;
                case "Class":
                    query = "DELETE FROM Class WHERE ClassID = @ClassID";
                    break;
                case "Course":
                    query = "DELETE FROM Course WHERE CourseID = @CourseID";
                    break;
                case "Report":
                    query = "DELETE FROM Report WHERE ReportID = @ReportID";
                    break;
            }
            MessageBox.Show("Delete functionality for " + activeTable);
        }

        private void SSTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SSbtn_Click(object sender, EventArgs e)
        {
            string searchValue = SSTextbox.Text.Trim();
            string query = "SELECT StudentID, FirstName, LastName, DateOfBirth, Email, PhoneNumber, GradeLevel, EnrollmentDate FROM Student WHERE FirstName LIKE @search OR LastName LIKE @search";

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@search", "%" + searchValue + "%");
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error filtering data: " + ex.Message);
                }
            }
        }
    }
}

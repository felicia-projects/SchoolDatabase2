using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.Devices;
using System.Data;
using System.Net.Http.Headers;
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
            SSLabel.Text = "Student Search";
            LoadDataIntoGrid("SELECT StudentID, FirstName, LastName, DateOfBirth, Email, PhoneNumber, GradeLevel, EnrollmentDate FROM Student");
        }

        private void teacherButton_Click(object sender, EventArgs e)
        {
            activeTable = "Teacher"; // Set active table to Teacher
            SSLabel.Text = "Teacher Search";
            LoadDataIntoGrid("SELECT TeacherID, FirstName, LastName, Email, PhoneNumber, DepartmentID FROM Teacher");
        }

        private void classbutton_Click(object sender, EventArgs e)
        {
            activeTable = "Class"; // Set active table to Class
            SSLabel.Text = "Class Search";
            LoadDataIntoGrid("SELECT * FROM Class_Section");
        }

        private void courseButton_Click(object sender, EventArgs e)
        {
            activeTable = "Course"; // Set active table to Course
            SSLabel.Text = "Course Search";
            LoadDataIntoGrid("SELECT * FROM Course");
        }

        private void departmentButton_Click(object sender, EventArgs e)
        {
            activeTable = "Department"; // Set active table to Department
            SSLabel.Text = "Department Search";
            LoadDataIntoGrid("SELECT * FROM Department");
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
                    teacherAdd teacherAdd = new teacherAdd();
                    teacherAdd.ShowDialog();

                    LoadDataIntoGrid("SELECT TeacherID, FirstName, LastName, Email, PhoneNumber, DepartmentID FROM Teacher");
                    break;
                case "Class":
                    classAdd classAdd = new classAdd();
                    classAdd.ShowDialog();

                    LoadDataIntoGrid("SELECT SectionID, CourseID, TeacherID, RoomNumber, Semester, SchoolYear, Capacity FROM Class");
                    break;
                case "Course":
                    MessageBox.Show("Will add later");
                    break;
                case "Department":
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
                case "Department":
                    query = "UPDATE Department SET DepartmentName = @DepartmentName WHERE DepartmentID = @DepartmentID";
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
                case "Department":
                    query = "DELETE FROM Department WHERE DepartmentID = @DepartmentID";
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
            string query = "";

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    switch (activeTable)
                    {
                        case "Student":
                            query = @"SELECT StudentID, FirstName, LastName, DateOfBirth, Email, PhoneNumber, GradeLevel, EnrollmentDate 
                              FROM Student 
                              WHERE CAST(StudentID AS VARCHAR) LIKE @SearchValue
                                 OR FirstName LIKE @SearchValue
                                 OR LastName LIKE @SearchValue
                                 OR CAST(DateOfBirth AS VARCHAR) LIKE @SearchValue
                                 OR Email LIKE @SearchValue
                                 OR PhoneNumber LIKE @SearchValue
                                 OR CAST(GradeLevel AS VARCHAR) LIKE @SearchValue
                                 OR CAST(EnrollmentDate AS VARCHAR) LIKE @SearchValue";
                            break;

                        case "Teacher":
                            
                            query = @"SELECT TeacherID, FirstName, LastName, Email, PhoneNumber, DepartmentID
                              FROM Teacher
                              WHERE CAST(TeacherID AS VARCHAR) LIKE @SearchValue
                                 OR FirstName LIKE @SearchValue
                                 OR LastName LIKE @SearchValue
                                 OR Email LIKE @SearchValue
                                 OR PhoneNumber LIKE @SearchValue
                                 OR CAST(DepartmentID AS VARCHAR) LIKE @SearchValue";
                            break;

                        case "Class":
                            query = @"SELECT SectionID, CourseID, TeacherID, RoomNumber, Semester, SchoolYear, Capacity 
                              FROM Class
                              WHERE CAST(SectionID AS VARCHAR) LIKE @SearchValue
                                 OR CAST(CourseID AS VARCHAR) LIKE @SearchValue
                                 OR CAST(TeacherID AS VARCHAR) LIKE @SearchValue
                                 OR CAST(RoomNumber AS VARCHAR) LIKE @SearchValue
                                 OR Semester LIKE @SearchValue
                                 OR CAST(SchoolYear AS VARCHAR) LIKE @SearchValue
                                 OR CAST(Capacity AS VARCHAR) LIKE @SearchValue";
                            break;

                        case "Course":
                            query = "SELECT * FROM Course WHERE CourseName LIKE @SearchValue";
                            break;

                        case "Department":
                            query = "SELECT * FROM Department WHERE DepartmentName LIKE @SearchValue";
                            break;
                    }

                    
                    cmd.Parameters.Add("@SearchValue", SqlDbType.VarChar).Value = "%" + searchValue + "%";
                    cmd.CommandText = query;

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

        private void SSbtn_Click_1(object sender, EventArgs e)
        {
            SSbtn_Click(sender, e);
        }
    }
}

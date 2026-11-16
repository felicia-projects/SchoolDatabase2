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
            private static string connectionString = @"Server=DESKTOP-G8BUTIS;Initial Catalog=CopySchoolDatabase;Integrated Security=True; Trust Server Certificate=True;";

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
            activeTable = "Class_Section"; // Set active table to Class
            SSLabel.Text = "Class_Section Search";
            LoadDataIntoGrid("SELECT SectionID, CourseID, TeacherID, PeriodID, RoomNumber, Semester, SchoolYear, Capacity FROM Class_Section");
        }

        private void courseButton_Click(object sender, EventArgs e)
        {
            activeTable = "Course"; // Set active table to Course
            SSLabel.Text = "Course Search";
            LoadDataIntoGrid("SELECT CourseID, CourseName, CourseDescription, DepartmentID, Credits FROM Course");
        }

        private void departmentButton_Click(object sender, EventArgs e)
        {
            activeTable = "Department"; // Set active table to Department
            SSLabel.Text = "Department Search";
            LoadDataIntoGrid("SELECT DepartmentID, DepartmentName, DepartmentDescription FROM Department");
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
                case "Class_Section":
                    classAdd classAdd = new classAdd();
                    classAdd.ShowDialog();

                    LoadDataIntoGrid("SELECT SectionID, CourseID, TeacherID, RoomNumber, Semester, SchoolYear, Capacity FROM Class_Section");
                    break;
                case "Course":
                    courseAdd courseAdd = new courseAdd();
                    courseAdd.ShowDialog();

                    LoadDataIntoGrid("SELECT CourseID, CourseName, CourseDescription, DepartmentID, Credits FROM Course");
                    break;
                case "Department":
                    DepartmentAdd departmentAdd = new DepartmentAdd();
                    departmentAdd.ShowDialog();

                    LoadDataIntoGrid("SELECT DepartmentID, DepartmentName, DepartmentDescription FROM Department");
                    break;
            }

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
                case "Class_Section":
                    query = "UPDATE Class_Section SET CourseID = @CourseID, TeacherID = @TeacherID, RoomNumber = @RoomNumber, Semester = @Semester, SchoolYear = @SchoolYear, Capacity = @Capacity WHERE SectionID = @SectionID";
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
                case "Class_Section":
                    query = "DELETE FROM Class_Section WHERE SectionID = @SectionID";
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

        private void SSbtn_Click(object sender, EventArgs e)
        {
            string searchValue = SSTextbox.Text.Trim();
            string query = "";
            bool isExact = chkExactMatch.Checked;

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                try
                {
                    switch (activeTable)
                    {
                        case "Student":
                            if (isExact)
                            {
                                query = @"SELECT StudentID, FirstName, LastName, DateOfBirth, Email, PhoneNumber, GradeLevel, EnrollmentDate 
                                  FROM Student 
                                  WHERE StudentID = TRY_CAST(@SearchValue AS INT)
                                     OR FirstName = @SearchValue
                                     OR LastName = @SearchValue
                                     OR Email = @SearchValue
                                     OR PhoneNumber = @SearchValue
                                     OR GradeLevel = TRY_CAST(@SearchValue AS INT)";
                            }
                            else
                            {
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
                            }
                            break;

                        case "Teacher":
                            if (isExact)
                            {
                                query = @"SELECT TeacherID, FirstName, LastName, Email, PhoneNumber, DepartmentID 
                                  FROM Teacher 
                                  WHERE TeacherID = TRY_CAST(@SearchValue AS INT)
                                     OR FirstName = @SearchValue
                                     OR LastName = @SearchValue
                                     OR Email = @SearchValue
                                     OR PhoneNumber = @SearchValue
                                     OR DepartmentID = TRY_CAST(@SearchValue AS INT)";
                            }
                            else
                            {
                                query = @"SELECT TeacherID, FirstName, LastName, Email, PhoneNumber, DepartmentID 
                                  FROM Teacher 
                                  WHERE CAST(TeacherID AS VARCHAR) LIKE @SearchValue 
                                     OR FirstName LIKE @SearchValue 
                                     OR LastName LIKE @SearchValue 
                                     OR Email LIKE @SearchValue 
                                     OR PhoneNumber LIKE @SearchValue 
                                     OR CAST(DepartmentID AS VARCHAR) LIKE @SearchValue";
                            }
                            break;

                        case "Class_Section":
                            if (isExact)
                            {
                                query = @"SELECT SectionID, CourseID, TeacherID, RoomNumber, Semester, SchoolYear, Capacity 
                                  FROM Class_Section 
                                  WHERE SectionID = TRY_CAST(@SearchValue AS INT)
                                     OR CourseID = TRY_CAST(@SearchValue AS INT)
                                     OR TeacherID = TRY_CAST(@SearchValue AS INT)
                                     OR RoomNumber = @SearchValue
                                     OR Semester = @SearchValue
                                     OR SchoolYear = TRY_CAST(@SearchValue AS INT)
                                     OR Capacity = TRY_CAST(@SearchValue AS INT)";
                            }
                            else
                            {
                                query = @"SELECT SectionID, CourseID, TeacherID, RoomNumber, Semester, SchoolYear, Capacity 
                                  FROM Class_Section 
                                  WHERE CAST(SectionID AS VARCHAR) LIKE @SearchValue 
                                     OR CAST(CourseID AS VARCHAR) LIKE @SearchValue 
                                     OR CAST(TeacherID AS VARCHAR) LIKE @SearchValue 
                                     OR CAST(RoomNumber AS VARCHAR) LIKE @SearchValue 
                                     OR Semester LIKE @SearchValue 
                                     OR CAST(SchoolYear AS VARCHAR) LIKE @SearchValue 
                                     OR CAST(Capacity AS VARCHAR) LIKE @SearchValue";
                            }
                            break;

                        case "Course":
                            if (isExact)
                            {
                                query = @"SELECT CourseID, CourseName, CourseDescription, DepartmentID, Credits 
                                  FROM Course 
                                  WHERE CourseID = TRY_CAST(@SearchValue AS INT)
                                     OR CourseName = @SearchValue
                                     OR DepartmentID = TRY_CAST(@SearchValue AS INT)
                                     OR Credits = TRY_CAST(@SearchValue AS INT)";
                            }
                            else
                            {
                                query = @"SELECT CourseID, CourseName, CourseDescription, DepartmentID, Credits 
                                  FROM Course 
                                  WHERE CAST(CourseID AS VARCHAR) LIKE @SearchValue 
                                     OR CourseName LIKE @SearchValue 
                                     OR CourseDescription LIKE @SearchValue 
                                     OR CAST(DepartmentID AS VARCHAR) LIKE @SearchValue 
                                     OR CAST(Credits AS VARCHAR) LIKE @SearchValue";
                            }
                            break;

                        case "Department":
                            if (isExact)
                            {
                                query = @"SELECT DepartmentID, DepartmentName, DepartmentDescription 
                                  FROM Department 
                                  WHERE DepartmentID = TRY_CAST(@SearchValue AS INT)
                                     OR DepartmentName = @SearchValue";
                            }
                            else
                            {
                                query = @"SELECT DepartmentID, DepartmentName, DepartmentDescription 
                                  FROM Department 
                                  WHERE CAST(DepartmentID AS VARCHAR) LIKE @SearchValue 
                                     OR DepartmentName LIKE @SearchValue 
                                     OR DepartmentDescription LIKE @SearchValue";
                            }
                            break;
                    }

                    if (string.IsNullOrEmpty(query))
                    {
                        MessageBox.Show("Please select a valid table tab before searching.");
                        return;
                    }

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        string parameterValue = isExact ? searchValue : "%" + searchValue + "%";
                        cmd.Parameters.Add("@SearchValue", SqlDbType.VarChar).Value = parameterValue;

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
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

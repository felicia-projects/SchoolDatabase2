namespace SchoolDatabase
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            departmentButton = new Button();
            courseButton = new Button();
            classbutton = new Button();
            teacherButton = new Button();
            studentButton = new Button();
            dataGridView1 = new DataGridView();
            panelStudentControls = new Panel();
            Deletebtn = new Button();
            SSbtn = new Button();
            SSTextbox = new TextBox();
            Updatebtn = new Button();
            SSLabel = new Label();
            Addbtn = new Button();
            panelStudent = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelStudentControls.SuspendLayout();
            panelStudent.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(departmentButton);
            panel1.Controls.Add(courseButton);
            panel1.Controls.Add(classbutton);
            panel1.Controls.Add(teacherButton);
            panel1.Controls.Add(studentButton);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(188, 361);
            panel1.TabIndex = 0;
            // 
            // departmentButton
            // 
            departmentButton.Location = new Point(32, 250);
            departmentButton.Margin = new Padding(2);
            departmentButton.Name = "departmentButton";
            departmentButton.Size = new Size(104, 27);
            departmentButton.TabIndex = 4;
            departmentButton.Text = "Departments";
            departmentButton.UseVisualStyleBackColor = true;
            departmentButton.Click += departmentButton_Click;
            // 
            // courseButton
            // 
            courseButton.Location = new Point(33, 202);
            courseButton.Margin = new Padding(2);
            courseButton.Name = "courseButton";
            courseButton.Size = new Size(90, 27);
            courseButton.TabIndex = 3;
            courseButton.Text = "Course";
            courseButton.UseVisualStyleBackColor = true;
            courseButton.Click += courseButton_Click;
            // 
            // classbutton
            // 
            classbutton.Location = new Point(32, 151);
            classbutton.Margin = new Padding(2);
            classbutton.Name = "classbutton";
            classbutton.Size = new Size(90, 27);
            classbutton.TabIndex = 2;
            classbutton.Text = "Classes";
            classbutton.UseVisualStyleBackColor = true;
            classbutton.Click += classbutton_Click;
            // 
            // teacherButton
            // 
            teacherButton.Location = new Point(32, 101);
            teacherButton.Margin = new Padding(2);
            teacherButton.Name = "teacherButton";
            teacherButton.Size = new Size(90, 27);
            teacherButton.TabIndex = 1;
            teacherButton.Text = "Teacher";
            teacherButton.UseVisualStyleBackColor = true;
            teacherButton.Click += teacherButton_Click;
            // 
            // studentButton
            // 
            studentButton.Location = new Point(33, 46);
            studentButton.Margin = new Padding(2);
            studentButton.Name = "studentButton";
            studentButton.Size = new Size(90, 27);
            studentButton.TabIndex = 0;
            studentButton.Text = "Student";
            studentButton.UseVisualStyleBackColor = true;
            studentButton.Click += studentButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(5, 2);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(339, 180);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // panelStudentControls
            // 
            panelStudentControls.BackColor = SystemColors.ControlDark;
            panelStudentControls.Controls.Add(Deletebtn);
            panelStudentControls.Controls.Add(SSbtn);
            panelStudentControls.Controls.Add(SSTextbox);
            panelStudentControls.Controls.Add(Updatebtn);
            panelStudentControls.Controls.Add(SSLabel);
            panelStudentControls.Controls.Add(Addbtn);
            panelStudentControls.Location = new Point(5, 187);
            panelStudentControls.Name = "panelStudentControls";
            panelStudentControls.Size = new Size(339, 171);
            panelStudentControls.TabIndex = 6;
            // 
            // Deletebtn
            // 
            Deletebtn.Location = new Point(214, 120);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(94, 29);
            Deletebtn.TabIndex = 5;
            Deletebtn.Text = "Delete";
            Deletebtn.UseVisualStyleBackColor = true;
            // 
            // SSbtn
            // 
            SSbtn.Location = new Point(214, 48);
            SSbtn.Name = "SSbtn";
            SSbtn.Size = new Size(94, 29);
            SSbtn.TabIndex = 2;
            SSbtn.Text = "Search";
            SSbtn.UseVisualStyleBackColor = true;
            SSbtn.Click += SSbtn_Click_1;
            // 
            // SSTextbox
            // 
            SSTextbox.Location = new Point(14, 49);
            SSTextbox.Name = "SSTextbox";
            SSTextbox.Size = new Size(194, 27);
            SSTextbox.TabIndex = 1;
            // 
            // Updatebtn
            // 
            Updatebtn.Location = new Point(114, 120);
            Updatebtn.Name = "Updatebtn";
            Updatebtn.Size = new Size(94, 29);
            Updatebtn.TabIndex = 4;
            Updatebtn.Text = "Update";
            Updatebtn.UseVisualStyleBackColor = true;
            // 
            // SSLabel
            // 
            SSLabel.AutoSize = true;
            SSLabel.Location = new Point(14, 26);
            SSLabel.Name = "SSLabel";
            SSLabel.Size = new Size(108, 20);
            SSLabel.TabIndex = 0;
            SSLabel.Text = "Student Search";
            // 
            // Addbtn
            // 
            Addbtn.Location = new Point(14, 120);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(94, 29);
            Addbtn.TabIndex = 3;
            Addbtn.Text = "Add";
            Addbtn.UseVisualStyleBackColor = true;
            Addbtn.Click += Addbtn_Click;
            // 
            // panelStudent
            // 
            panelStudent.Controls.Add(panelStudentControls);
            panelStudent.Controls.Add(dataGridView1);
            panelStudent.Dock = DockStyle.Fill;
            panelStudent.Location = new Point(188, 0);
            panelStudent.Margin = new Padding(2);
            panelStudent.Name = "panelStudent";
            panelStudent.Size = new Size(347, 361);
            panelStudent.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 361);
            Controls.Add(panelStudent);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Student Database";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelStudentControls.ResumeLayout(false);
            panelStudentControls.PerformLayout();
            panelStudent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button departmentButton;
        private Button courseButton;
        private Button classbutton;
        private Button teacherButton;
        private Button studentButton;
        private Label studentLabel;
        private Button btnFilterStudent;
        private TextBox txtStudentFilter;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dataGridView1;
        private Panel panelStudentControls;
        private Button Deletebtn;
        private Button SSbtn;
        private TextBox SSTextbox;
        private Button Updatebtn;
        private Label SSLabel;
        private Button Addbtn;
        private Panel panelStudent;
    }
}

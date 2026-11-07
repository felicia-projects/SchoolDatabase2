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
            reportsButton = new Button();
            courseButton = new Button();
            classbutton = new Button();
            teacherButton = new Button();
            studentButton = new Button();
            panelStudent = new Panel();
            updateButton = new Button();
            deleteButton = new Button();
            addButton = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panelStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(reportsButton);
            panel1.Controls.Add(courseButton);
            panel1.Controls.Add(classbutton);
            panel1.Controls.Add(teacherButton);
            panel1.Controls.Add(studentButton);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 450);
            panel1.TabIndex = 0;
            // 
            // reportsButton
            // 
            reportsButton.Location = new Point(40, 312);
            reportsButton.Name = "reportsButton";
            reportsButton.Size = new Size(112, 34);
            reportsButton.TabIndex = 4;
            reportsButton.Text = "Reports";
            reportsButton.UseVisualStyleBackColor = true;
            // 
            // courseButton
            // 
            courseButton.Location = new Point(41, 252);
            courseButton.Name = "courseButton";
            courseButton.Size = new Size(112, 34);
            courseButton.TabIndex = 3;
            courseButton.Text = "Course";
            courseButton.UseVisualStyleBackColor = true;
            // 
            // classbutton
            // 
            classbutton.Location = new Point(40, 189);
            classbutton.Name = "classbutton";
            classbutton.Size = new Size(112, 34);
            classbutton.TabIndex = 2;
            classbutton.Text = "Classes";
            classbutton.UseVisualStyleBackColor = true;
            // 
            // teacherButton
            // 
            teacherButton.Location = new Point(40, 126);
            teacherButton.Name = "teacherButton";
            teacherButton.Size = new Size(112, 34);
            teacherButton.TabIndex = 1;
            teacherButton.Text = "Teacher";
            teacherButton.UseVisualStyleBackColor = true;
            // 
            // studentButton
            // 
            studentButton.Location = new Point(41, 57);
            studentButton.Name = "studentButton";
            studentButton.Size = new Size(112, 34);
            studentButton.TabIndex = 0;
            studentButton.Text = "Student";
            studentButton.UseVisualStyleBackColor = true;
            // 
            // panelStudent
            // 
            panelStudent.Controls.Add(updateButton);
            panelStudent.Controls.Add(deleteButton);
            panelStudent.Controls.Add(addButton);
            panelStudent.Controls.Add(dataGridView1);
            panelStudent.Dock = DockStyle.Fill;
            panelStudent.Location = new Point(300, 0);
            panelStudent.Name = "panelStudent";
            panelStudent.Size = new Size(367, 450);
            panelStudent.TabIndex = 1;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(201, 252);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(112, 34);
            updateButton.TabIndex = 3;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(117, 312);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(112, 34);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(31, 252);
            addButton.Name = "addButton";
            addButton.Size = new Size(112, 34);
            addButton.TabIndex = 1;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(360, 225);
            dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 450);
            Controls.Add(panelStudent);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panelStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button reportsButton;
        private Button courseButton;
        private Button classbutton;
        private Button teacherButton;
        private Button studentButton;
        private Panel panelStudent;
        private DataGridView dataGridView1;
        private Button updateButton;
        private Button deleteButton;
        private Button addButton;
    }
}

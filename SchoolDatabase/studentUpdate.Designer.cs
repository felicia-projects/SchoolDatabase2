namespace SchoolDatabase
{
    partial class studentUpdate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            txtStudentID = new TextBox();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            txtGradeLevel = new TextBox();
            txtPhoneNumber = new TextBox();
            txtFirstName = new TextBox();
            dtpDateOfBirth = new DateTimePicker();
            dtpEnrollmentDate = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(667, 160);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(25, 246);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.ReadOnly = true;
            txtStudentID.Size = new Size(282, 27);
            txtStudentID.TabIndex = 1;
            txtStudentID.TabStop = false;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(25, 298);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(282, 27);
            txtLastName.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(25, 348);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(282, 27);
            txtEmail.TabIndex = 3;
            // 
            // txtGradeLevel
            // 
            txtGradeLevel.Location = new Point(429, 348);
            txtGradeLevel.Name = "txtGradeLevel";
            txtGradeLevel.Size = new Size(263, 27);
            txtGradeLevel.TabIndex = 6;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(429, 298);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(263, 27);
            txtPhoneNumber.TabIndex = 5;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(429, 246);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(263, 27);
            txtFirstName.TabIndex = 4;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(25, 400);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(250, 27);
            dtpDateOfBirth.TabIndex = 7;
            // 
            // dtpEnrollmentDate
            // 
            dtpEnrollmentDate.Location = new Point(429, 400);
            dtpEnrollmentDate.Name = "dtpEnrollmentDate";
            dtpEnrollmentDate.Size = new Size(250, 27);
            dtpEnrollmentDate.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 223);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 9;
            label1.Text = "Student ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 276);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 10;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 328);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 11;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 377);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 12;
            label4.Text = "Date of Birth:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(430, 223);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 13;
            label5.Text = "First Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(430, 276);
            label6.Name = "label6";
            label6.Size = new Size(111, 20);
            label6.TabIndex = 14;
            label6.Text = "Phone Number:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(430, 325);
            label7.Name = "label7";
            label7.Size = new Size(90, 20);
            label7.TabIndex = 15;
            label7.Text = "Grade Level:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(430, 378);
            label8.Name = "label8";
            label8.Size = new Size(120, 20);
            label8.TabIndex = 16;
            label8.Text = "Enrollment Date:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(241, 186);
            label9.Name = "label9";
            label9.Size = new Size(196, 20);
            label9.TabIndex = 17;
            label9.Text = "Select the student to update";
            label9.Click += label9_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(209, 464);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(146, 29);
            btnSave.TabIndex = 18;
            btnSave.Text = "SAVE CHANGES";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(393, 464);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 29);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // studentUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 523);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpEnrollmentDate);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(txtGradeLevel);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtFirstName);
            Controls.Add(txtEmail);
            Controls.Add(txtLastName);
            Controls.Add(txtStudentID);
            Controls.Add(dataGridView1);
            Name = "studentUpdate";
            Text = "Update Student";
            Load += studentUpdate_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtStudentID;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private TextBox txtGradeLevel;
        private TextBox txtPhoneNumber;
        private TextBox txtFirstName;
        private DateTimePicker dtpDateOfBirth;
        private DateTimePicker dtpEnrollmentDate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnSave;
        private Button btnCancel;
    }
}
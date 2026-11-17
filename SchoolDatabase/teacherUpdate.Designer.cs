namespace SchoolDatabase
{
    partial class teacherUpdate
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
            btnCancel = new Button();
            btnSave = new Button();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtDepartmentID = new TextBox();
            txtPhoneNumber = new TextBox();
            txtFirstName = new TextBox();
            txtEmail = new TextBox();
            txtLastName = new TextBox();
            txtTeacherID = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(435, 409);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 29);
            btnCancel.TabIndex = 39;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(251, 409);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(146, 29);
            btnSave.TabIndex = 38;
            btnSave.Text = "SAVE CHANGES";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(273, 197);
            label9.Name = "label9";
            label9.Size = new Size(196, 20);
            label9.TabIndex = 37;
            label9.Text = "Select the teacher to update";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(472, 330);
            label7.Name = "label7";
            label7.Size = new Size(108, 20);
            label7.TabIndex = 35;
            label7.Text = "Department ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(472, 281);
            label6.Name = "label6";
            label6.Size = new Size(111, 20);
            label6.TabIndex = 34;
            label6.Text = "Phone Number:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(472, 228);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 33;
            label5.Text = "First Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 333);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 31;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 281);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 30;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 228);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 29;
            label1.Text = "Teacher ID";
            // 
            // txtDepartmentID
            // 
            txtDepartmentID.Location = new Point(471, 353);
            txtDepartmentID.Name = "txtDepartmentID";
            txtDepartmentID.Size = new Size(263, 27);
            txtDepartmentID.TabIndex = 26;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(471, 303);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(263, 27);
            txtPhoneNumber.TabIndex = 25;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(471, 251);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(263, 27);
            txtFirstName.TabIndex = 24;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(67, 353);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(282, 27);
            txtEmail.TabIndex = 23;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(67, 303);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(282, 27);
            txtLastName.TabIndex = 22;
            // 
            // txtTeacherID
            // 
            txtTeacherID.Location = new Point(67, 251);
            txtTeacherID.Name = "txtTeacherID";
            txtTeacherID.ReadOnly = true;
            txtTeacherID.Size = new Size(282, 27);
            txtTeacherID.TabIndex = 21;
            txtTeacherID.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(67, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(667, 160);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // teacherUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDepartmentID);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtFirstName);
            Controls.Add(txtEmail);
            Controls.Add(txtLastName);
            Controls.Add(txtTeacherID);
            Controls.Add(dataGridView1);
            Name = "teacherUpdate";
            Text = "teacherUpdate";
            Load += teacherUpdate_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtDepartmentID;
        private TextBox txtPhoneNumber;
        private TextBox txtFirstName;
        private TextBox txtEmail;
        private TextBox txtLastName;
        private TextBox txtTeacherID;
        private DataGridView dataGridView1;
    }
}
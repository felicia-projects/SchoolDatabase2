namespace SchoolDatabase
{
    partial class classUpdate
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
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtSemester = new TextBox();
            txtPeriodID = new TextBox();
            txtCourseID = new TextBox();
            txtRoomNumber = new TextBox();
            txtTeacherID = new TextBox();
            txtSectionID = new TextBox();
            dataGridView1 = new DataGridView();
            label8 = new Label();
            label7 = new Label();
            txtCapacity = new TextBox();
            txtSchoolYear = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(435, 409);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 29);
            btnCancel.TabIndex = 55;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(251, 409);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(146, 29);
            btnSave.TabIndex = 54;
            btnSave.Text = "SAVE CHANGES";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(350, 165);
            label9.Name = "label9";
            label9.Size = new Size(96, 20);
            label9.TabIndex = 53;
            label9.Text = "Select a class";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(324, 324);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 52;
            label6.Text = "Semester";
            label6.Click += label7_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(324, 272);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 51;
            label5.Text = "Period ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(324, 219);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 50;
            label4.Text = "Course ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 324);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 49;
            label3.Text = "Room Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 272);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 48;
            label2.Text = "Teacher ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 219);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 47;
            label1.Text = "Section ID";
            // 
            // txtSemester
            // 
            txtSemester.Location = new Point(324, 344);
            txtSemester.Name = "txtSemester";
            txtSemester.Size = new Size(160, 27);
            txtSemester.TabIndex = 46;
            // 
            // txtPeriodID
            // 
            txtPeriodID.Location = new Point(324, 294);
            txtPeriodID.Name = "txtPeriodID";
            txtPeriodID.Size = new Size(160, 27);
            txtPeriodID.TabIndex = 45;
            // 
            // txtCourseID
            // 
            txtCourseID.Location = new Point(324, 242);
            txtCourseID.Name = "txtCourseID";
            txtCourseID.Size = new Size(160, 27);
            txtCourseID.TabIndex = 44;
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Location = new Point(67, 344);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.Size = new Size(174, 27);
            txtRoomNumber.TabIndex = 43;
            // 
            // txtTeacherID
            // 
            txtTeacherID.Location = new Point(67, 294);
            txtTeacherID.Name = "txtTeacherID";
            txtTeacherID.Size = new Size(174, 27);
            txtTeacherID.TabIndex = 42;
            // 
            // txtSectionID
            // 
            txtSectionID.Location = new Point(67, 242);
            txtSectionID.Name = "txtSectionID";
            txtSectionID.ReadOnly = true;
            txtSectionID.Size = new Size(174, 27);
            txtSectionID.TabIndex = 41;
            txtSectionID.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(67, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(667, 134);
            dataGridView1.TabIndex = 40;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(574, 272);
            label8.Name = "label8";
            label8.Size = new Size(66, 20);
            label8.TabIndex = 60;
            label8.Text = "Capacity";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(574, 219);
            label7.Name = "label7";
            label7.Size = new Size(89, 20);
            label7.TabIndex = 59;
            label7.Text = "School Year:";
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(574, 294);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(160, 27);
            txtCapacity.TabIndex = 57;
            // 
            // txtSchoolYear
            // 
            txtSchoolYear.Location = new Point(574, 242);
            txtSchoolYear.Name = "txtSchoolYear";
            txtSchoolYear.Size = new Size(160, 27);
            txtSchoolYear.TabIndex = 56;
            // 
            // classUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtCapacity);
            Controls.Add(txtSchoolYear);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSemester);
            Controls.Add(txtPeriodID);
            Controls.Add(txtCourseID);
            Controls.Add(txtRoomNumber);
            Controls.Add(txtTeacherID);
            Controls.Add(txtSectionID);
            Controls.Add(dataGridView1);
            Name = "classUpdate";
            Text = "classUpdate";
            Load += classUpdate_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private Label label9;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtSemester;
        private TextBox txtPeriodID;
        private TextBox txtCourseID;
        private TextBox txtRoomNumber;
        private TextBox txtTeacherID;
        private TextBox txtSectionID;
        private DataGridView dataGridView1;
        private Label label4;
        private Label label8;
        private Label label7;
        private TextBox txtCapacity;
        private TextBox txtSchoolYear;
    }
}
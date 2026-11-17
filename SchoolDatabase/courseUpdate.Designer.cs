namespace SchoolDatabase
{
    partial class courseUpdate
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtDepartmentID = new TextBox();
            txtCredits = new TextBox();
            txtCourseDescription = new TextBox();
            txtCourseName = new TextBox();
            txtCourseID = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(435, 409);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 29);
            btnCancel.TabIndex = 76;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(251, 409);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(146, 29);
            btnSave.TabIndex = 75;
            btnSave.Text = "SAVE CHANGES";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(350, 165);
            label9.Name = "label9";
            label9.Size = new Size(110, 20);
            label9.TabIndex = 74;
            label9.Text = "Select a Course";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(574, 232);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 72;
            label5.Text = "Department ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(320, 284);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 71;
            label4.Text = "Credits";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(574, 286);
            label3.Name = "label3";
            label3.Size = new Size(134, 20);
            label3.TabIndex = 70;
            label3.Text = "Course Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(320, 231);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 69;
            label2.Text = "Course Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 231);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 68;
            label1.Text = "Course ID";
            // 
            // txtDepartmentID
            // 
            txtDepartmentID.Location = new Point(574, 254);
            txtDepartmentID.Name = "txtDepartmentID";
            txtDepartmentID.Size = new Size(160, 27);
            txtDepartmentID.TabIndex = 66;
            // 
            // txtCredits
            // 
            txtCredits.Location = new Point(320, 306);
            txtCredits.Name = "txtCredits";
            txtCredits.Size = new Size(174, 27);
            txtCredits.TabIndex = 65;
            // 
            // txtCourseDescription
            // 
            txtCourseDescription.Location = new Point(574, 306);
            txtCourseDescription.Name = "txtCourseDescription";
            txtCourseDescription.Size = new Size(160, 27);
            txtCourseDescription.TabIndex = 64;
            // 
            // txtCourseName
            // 
            txtCourseName.Location = new Point(320, 254);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(174, 27);
            txtCourseName.TabIndex = 63;
            // 
            // txtCourseID
            // 
            txtCourseID.Location = new Point(67, 254);
            txtCourseID.Name = "txtCourseID";
            txtCourseID.ReadOnly = true;
            txtCourseID.Size = new Size(174, 27);
            txtCourseID.TabIndex = 62;
            txtCourseID.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(67, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(667, 134);
            dataGridView1.TabIndex = 61;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // courseUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDepartmentID);
            Controls.Add(txtCredits);
            Controls.Add(txtCourseDescription);
            Controls.Add(txtCourseName);
            Controls.Add(txtCourseID);
            Controls.Add(dataGridView1);
            Name = "courseUpdate";
            Text = "Update Course";
            Load += courseUpdate_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Button btnCancel;
        private Button btnSave;

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label9;

        private TextBox txtCourseID;
        private TextBox txtCourseName;
        private TextBox txtCourseDescription;
        private TextBox txtDepartmentID;
        private TextBox txtCredits;

        private DataGridView dataGridView1;
    }
}

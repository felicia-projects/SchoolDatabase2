namespace SchoolDatabase
{
    partial class departmentUpdate
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
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtDepartmentDescription = new TextBox();
            txtDepartmentName = new TextBox();
            txtDepartmentID = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(435, 409);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 29);
            btnCancel.TabIndex = 86;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(251, 409);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(146, 29);
            btnSave.TabIndex = 85;
            btnSave.Text = "SAVE CHANGES";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(329, 149);
            label9.Name = "label9";
            label9.Size = new Size(145, 20);
            label9.TabIndex = 84;
            label9.Text = "Select a Department";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(296, 315);
            label4.Name = "label4";
            label4.Size = new Size(169, 20);
            label4.TabIndex = 83;
            label4.Text = "Department Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(296, 267);
            label2.Name = "label2";
            label2.Size = new Size(133, 20);
            label2.TabIndex = 82;
            label2.Text = "Department Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(296, 217);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 81;
            label1.Text = "Department ID";
            // 
            // txtDepartmentDescription
            // 
            txtDepartmentDescription.Location = new Point(296, 337);
            txtDepartmentDescription.Name = "txtDepartmentDescription";
            txtDepartmentDescription.Size = new Size(220, 27);
            txtDepartmentDescription.TabIndex = 80;
            // 
            // txtDepartmentName
            // 
            txtDepartmentName.Location = new Point(296, 290);
            txtDepartmentName.Name = "txtDepartmentName";
            txtDepartmentName.Size = new Size(220, 27);
            txtDepartmentName.TabIndex = 79;
            // 
            // txtDepartmentID
            // 
            txtDepartmentID.Location = new Point(296, 240);
            txtDepartmentID.Name = "txtDepartmentID";
            txtDepartmentID.ReadOnly = true;
            txtDepartmentID.Size = new Size(220, 27);
            txtDepartmentID.TabIndex = 78;
            txtDepartmentID.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(67, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(667, 134);
            dataGridView1.TabIndex = 77;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // departmentUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDepartmentDescription);
            Controls.Add(txtDepartmentName);
            Controls.Add(txtDepartmentID);
            Controls.Add(dataGridView1);
            Name = "departmentUpdate";
            Text = "Update Department";
            Load += departmentUpdate_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private Label label9;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox txtDepartmentDescription;
        private TextBox txtDepartmentName;
        private TextBox txtDepartmentID;
        private DataGridView dataGridView1;
    }
}
namespace SchoolDatabase
{
    partial class DepartmentAdd
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
            DIDLabel = new Label();
            DNLabel = new Label();
            DDLabel = new Label();
            DIDTextbox = new TextBox();
            DNTextBox = new TextBox();
            DDTextbox = new TextBox();
            DepartmentSavebtn = new Button();
            SuspendLayout();
            // 
            // DIDLabel
            // 
            DIDLabel.AutoSize = true;
            DIDLabel.Location = new Point(12, 9);
            DIDLabel.Name = "DIDLabel";
            DIDLabel.Size = new Size(108, 20);
            DIDLabel.TabIndex = 0;
            DIDLabel.Text = "Department ID";
            // 
            // DNLabel
            // 
            DNLabel.AutoSize = true;
            DNLabel.Location = new Point(12, 76);
            DNLabel.Name = "DNLabel";
            DNLabel.Size = new Size(133, 20);
            DNLabel.TabIndex = 1;
            DNLabel.Text = "Department Name";
            // 
            // DDLabel
            // 
            DDLabel.AutoSize = true;
            DDLabel.Location = new Point(231, 9);
            DDLabel.Name = "DDLabel";
            DDLabel.Size = new Size(169, 20);
            DDLabel.TabIndex = 2;
            DDLabel.Text = "Department Description";
            // 
            // DIDTextbox
            // 
            DIDTextbox.Location = new Point(12, 32);
            DIDTextbox.Name = "DIDTextbox";
            DIDTextbox.Size = new Size(170, 27);
            DIDTextbox.TabIndex = 3;
            // 
            // DNTextBox
            // 
            DNTextBox.Location = new Point(12, 99);
            DNTextBox.Name = "DNTextBox";
            DNTextBox.Size = new Size(170, 27);
            DNTextBox.TabIndex = 4;
            // 
            // DDTextbox
            // 
            DDTextbox.Location = new Point(231, 32);
            DDTextbox.Name = "DDTextbox";
            DDTextbox.Size = new Size(170, 27);
            DDTextbox.TabIndex = 5;
            // 
            // DepartmentSavebtn
            // 
            DepartmentSavebtn.Location = new Point(152, 132);
            DepartmentSavebtn.Name = "DepartmentSavebtn";
            DepartmentSavebtn.Size = new Size(94, 29);
            DepartmentSavebtn.TabIndex = 7;
            DepartmentSavebtn.Text = "Save";
            DepartmentSavebtn.UseVisualStyleBackColor = true;
            DepartmentSavebtn.Click += DepartmentSavebtn_Click;
            // 
            // DepartmentAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 172);
            Controls.Add(DepartmentSavebtn);
            Controls.Add(DDTextbox);
            Controls.Add(DNTextBox);
            Controls.Add(DIDTextbox);
            Controls.Add(DDLabel);
            Controls.Add(DNLabel);
            Controls.Add(DIDLabel);
            Name = "DepartmentAdd";
            Text = "DepartmentAdd";
            Load += DepartmentAdd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DIDLabel;
        private Label DNLabel;
        private Label DDLabel;
        private TextBox DIDTextbox;
        private TextBox DNTextBox;
        private TextBox DDTextbox;
        private Button DepartmentSavebtn;
    }
}
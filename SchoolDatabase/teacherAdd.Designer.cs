namespace SchoolDatabase
{
    partial class teacherAdd
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
            TIDTextbox = new TextBox();
            DKTextbox = new TextBox();
            TPNTextbox = new TextBox();
            TEmTextbox = new TextBox();
            LNTextbox = new TextBox();
            FNTextbox = new TextBox();
            TIDLabel = new Label();
            TFNLabel = new Label();
            TLNLabel = new Label();
            TEmLabel = new Label();
            TPNLabel = new Label();
            TDIDLabel = new Label();
            teacherSavebtn = new Button();
            SuspendLayout();
            // 
            // TIDTextbox
            // 
            TIDTextbox.Location = new Point(15, 41);
            TIDTextbox.Margin = new Padding(4, 4, 4, 4);
            TIDTextbox.Name = "TIDTextbox";
            TIDTextbox.Size = new Size(192, 31);
            TIDTextbox.TabIndex = 0;
            // 
            // DKTextbox
            // 
            DKTextbox.Location = new Point(282, 208);
            DKTextbox.Margin = new Padding(4, 4, 4, 4);
            DKTextbox.Name = "DKTextbox";
            DKTextbox.Size = new Size(192, 31);
            DKTextbox.TabIndex = 2;
            // 
            // TPNTextbox
            // 
            TPNTextbox.Location = new Point(282, 124);
            TPNTextbox.Margin = new Padding(4, 4, 4, 4);
            TPNTextbox.Name = "TPNTextbox";
            TPNTextbox.Size = new Size(192, 31);
            TPNTextbox.TabIndex = 3;
            // 
            // TEmTextbox
            // 
            TEmTextbox.Location = new Point(282, 41);
            TEmTextbox.Margin = new Padding(4, 4, 4, 4);
            TEmTextbox.Name = "TEmTextbox";
            TEmTextbox.Size = new Size(192, 31);
            TEmTextbox.TabIndex = 4;
            // 
            // LNTextbox
            // 
            LNTextbox.Location = new Point(15, 208);
            LNTextbox.Margin = new Padding(4, 4, 4, 4);
            LNTextbox.Name = "LNTextbox";
            LNTextbox.Size = new Size(192, 31);
            LNTextbox.TabIndex = 5;
            // 
            // FNTextbox
            // 
            FNTextbox.Location = new Point(15, 124);
            FNTextbox.Margin = new Padding(4, 4, 4, 4);
            FNTextbox.Name = "FNTextbox";
            FNTextbox.Size = new Size(192, 31);
            FNTextbox.TabIndex = 6;
            // 
            // TIDLabel
            // 
            TIDLabel.AutoSize = true;
            TIDLabel.Location = new Point(15, 12);
            TIDLabel.Margin = new Padding(4, 0, 4, 0);
            TIDLabel.Name = "TIDLabel";
            TIDLabel.Size = new Size(88, 25);
            TIDLabel.TabIndex = 7;
            TIDLabel.Text = "TeacherID";
            // 
            // TFNLabel
            // 
            TFNLabel.AutoSize = true;
            TFNLabel.Location = new Point(15, 95);
            TFNLabel.Margin = new Padding(4, 0, 4, 0);
            TFNLabel.Name = "TFNLabel";
            TFNLabel.Size = new Size(97, 25);
            TFNLabel.TabIndex = 8;
            TFNLabel.Text = "First Name";
            // 
            // TLNLabel
            // 
            TLNLabel.AutoSize = true;
            TLNLabel.Location = new Point(15, 179);
            TLNLabel.Margin = new Padding(4, 0, 4, 0);
            TLNLabel.Name = "TLNLabel";
            TLNLabel.Size = new Size(95, 25);
            TLNLabel.TabIndex = 9;
            TLNLabel.Text = "Last Name";
            // 
            // TEmLabel
            // 
            TEmLabel.AutoSize = true;
            TEmLabel.Location = new Point(282, 12);
            TEmLabel.Margin = new Padding(4, 0, 4, 0);
            TEmLabel.Name = "TEmLabel";
            TEmLabel.Size = new Size(54, 25);
            TEmLabel.TabIndex = 10;
            TEmLabel.Text = "Email";
            // 
            // TPNLabel
            // 
            TPNLabel.AutoSize = true;
            TPNLabel.Location = new Point(282, 95);
            TPNLabel.Margin = new Padding(4, 0, 4, 0);
            TPNLabel.Name = "TPNLabel";
            TPNLabel.Size = new Size(132, 25);
            TPNLabel.TabIndex = 11;
            TPNLabel.Text = "Phone Number";
            // 
            // TDIDLabel
            // 
            TDIDLabel.AutoSize = true;
            TDIDLabel.Location = new Point(282, 179);
            TDIDLabel.Margin = new Padding(4, 0, 4, 0);
            TDIDLabel.Name = "TDIDLabel";
            TDIDLabel.Size = new Size(125, 25);
            TDIDLabel.TabIndex = 12;
            TDIDLabel.Text = "DepartmentID";
            // 
            // teacherSavebtn
            // 
            teacherSavebtn.Location = new Point(185, 249);
            teacherSavebtn.Margin = new Padding(4, 4, 4, 4);
            teacherSavebtn.Name = "teacherSavebtn";
            teacherSavebtn.Size = new Size(118, 36);
            teacherSavebtn.TabIndex = 13;
            teacherSavebtn.Text = "Save";
            teacherSavebtn.UseVisualStyleBackColor = true;
            teacherSavebtn.Click += teacherSavebtn_Click;
            // 
            // teacherAdd
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 318);
            Controls.Add(teacherSavebtn);
            Controls.Add(TDIDLabel);
            Controls.Add(TPNLabel);
            Controls.Add(TEmLabel);
            Controls.Add(TLNLabel);
            Controls.Add(TFNLabel);
            Controls.Add(TIDLabel);
            Controls.Add(FNTextbox);
            Controls.Add(LNTextbox);
            Controls.Add(TEmTextbox);
            Controls.Add(TPNTextbox);
            Controls.Add(DKTextbox);
            Controls.Add(TIDTextbox);
            Margin = new Padding(4, 4, 4, 4);
            Name = "teacherAdd";
            Text = "teacherAdd";
            Load += teacherAdd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TIDTextbox;
        private TextBox DKTextbox;
        private TextBox TPNTextbox;
        private TextBox TEmTextbox;
        private TextBox LNTextbox;
        private TextBox FNTextbox;
        private Label TIDLabel;
        private Label TFNLabel;
        private Label TLNLabel;
        private Label TEmLabel;
        private Label TPNLabel;
        private Label TDIDLabel;
        private Button teacherSavebtn;
    }
}
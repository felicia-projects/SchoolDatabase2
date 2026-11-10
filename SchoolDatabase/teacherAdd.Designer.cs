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
            TDKLabel = new Label();
            teacherSavebtn = new Button();
            SuspendLayout();
            // 
            // TIDTextbox
            // 
            TIDTextbox.Location = new Point(12, 33);
            TIDTextbox.Name = "TIDTextbox";
            TIDTextbox.Size = new Size(154, 27);
            TIDTextbox.TabIndex = 0;
            // 
            // DKTextbox
            // 
            DKTextbox.Location = new Point(226, 166);
            DKTextbox.Name = "DKTextbox";
            DKTextbox.Size = new Size(154, 27);
            DKTextbox.TabIndex = 2;
            // 
            // TPNTextbox
            // 
            TPNTextbox.Location = new Point(226, 99);
            TPNTextbox.Name = "TPNTextbox";
            TPNTextbox.Size = new Size(154, 27);
            TPNTextbox.TabIndex = 3;
            // 
            // TEmTextbox
            // 
            TEmTextbox.Location = new Point(226, 33);
            TEmTextbox.Name = "TEmTextbox";
            TEmTextbox.Size = new Size(154, 27);
            TEmTextbox.TabIndex = 4;
            // 
            // LNTextbox
            // 
            LNTextbox.Location = new Point(12, 166);
            LNTextbox.Name = "LNTextbox";
            LNTextbox.Size = new Size(154, 27);
            LNTextbox.TabIndex = 5;
            // 
            // FNTextbox
            // 
            FNTextbox.Location = new Point(12, 99);
            FNTextbox.Name = "FNTextbox";
            FNTextbox.Size = new Size(154, 27);
            FNTextbox.TabIndex = 6;
            // 
            // TIDLabel
            // 
            TIDLabel.AutoSize = true;
            TIDLabel.Location = new Point(12, 10);
            TIDLabel.Name = "TIDLabel";
            TIDLabel.Size = new Size(75, 20);
            TIDLabel.TabIndex = 7;
            TIDLabel.Text = "TeacherID";
            // 
            // TFNLabel
            // 
            TFNLabel.AutoSize = true;
            TFNLabel.Location = new Point(12, 76);
            TFNLabel.Name = "TFNLabel";
            TFNLabel.Size = new Size(80, 20);
            TFNLabel.TabIndex = 8;
            TFNLabel.Text = "First Name";
            // 
            // TLNLabel
            // 
            TLNLabel.AutoSize = true;
            TLNLabel.Location = new Point(12, 143);
            TLNLabel.Name = "TLNLabel";
            TLNLabel.Size = new Size(79, 20);
            TLNLabel.TabIndex = 9;
            TLNLabel.Text = "Last Name";
            // 
            // TEmLabel
            // 
            TEmLabel.AutoSize = true;
            TEmLabel.Location = new Point(226, 10);
            TEmLabel.Name = "TEmLabel";
            TEmLabel.Size = new Size(46, 20);
            TEmLabel.TabIndex = 10;
            TEmLabel.Text = "Email";
            // 
            // TPNLabel
            // 
            TPNLabel.AutoSize = true;
            TPNLabel.Location = new Point(226, 76);
            TPNLabel.Name = "TPNLabel";
            TPNLabel.Size = new Size(108, 20);
            TPNLabel.TabIndex = 11;
            TPNLabel.Text = "Phone Number";
            // 
            // TDKLabel
            // 
            TDKLabel.AutoSize = true;
            TDKLabel.Location = new Point(226, 143);
            TDKLabel.Name = "TDKLabel";
            TDKLabel.Size = new Size(117, 20);
            TDKLabel.TabIndex = 12;
            TDKLabel.Text = "Department Key";
            // 
            // teacherSavebtn
            // 
            teacherSavebtn.Location = new Point(148, 199);
            teacherSavebtn.Name = "teacherSavebtn";
            teacherSavebtn.Size = new Size(94, 29);
            teacherSavebtn.TabIndex = 13;
            teacherSavebtn.Text = "Save";
            teacherSavebtn.UseVisualStyleBackColor = true;
            teacherSavebtn.Click += teacherSavebtn_Click;
            // 
            // teacherAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 254);
            Controls.Add(teacherSavebtn);
            Controls.Add(TDKLabel);
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
        private Label TDKLabel;
        private Button teacherSavebtn;
    }
}
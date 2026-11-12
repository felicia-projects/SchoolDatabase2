namespace SchoolDatabase
{
    partial class classAdd
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
            CSectionIDTextbox = new TextBox();
            CCourseIDTextbox = new TextBox();
            CTeacherIDTextbox = new TextBox();
            CPeriodIDTextbox = new TextBox();
            CSectionIDLabel = new Label();
            CCourseIDLabel = new Label();
            CTeacherIDLabel = new Label();
            CPeriodIDLabel = new Label();
            CRNLabel = new Label();
            CSLabel = new Label();
            CSYLabel = new Label();
            CRNTextbox = new TextBox();
            CSTextbox = new TextBox();
            CSYTextbox = new TextBox();
            CCLabel = new Label();
            CCTextbox = new TextBox();
            CSearchbtn = new Button();
            SuspendLayout();
            // 
            // CSectionIDTextbox
            // 
            CSectionIDTextbox.Location = new Point(12, 32);
            CSectionIDTextbox.Name = "CSectionIDTextbox";
            CSectionIDTextbox.Size = new Size(162, 27);
            CSectionIDTextbox.TabIndex = 0;
            // 
            // CCourseIDTextbox
            // 
            CCourseIDTextbox.Location = new Point(12, 92);
            CCourseIDTextbox.Name = "CCourseIDTextbox";
            CCourseIDTextbox.Size = new Size(162, 27);
            CCourseIDTextbox.TabIndex = 1;
            // 
            // CTeacherIDTextbox
            // 
            CTeacherIDTextbox.Location = new Point(12, 154);
            CTeacherIDTextbox.Name = "CTeacherIDTextbox";
            CTeacherIDTextbox.Size = new Size(162, 27);
            CTeacherIDTextbox.TabIndex = 2;
            // 
            // CPeriodIDTextbox
            // 
            CPeriodIDTextbox.Location = new Point(12, 215);
            CPeriodIDTextbox.Name = "CPeriodIDTextbox";
            CPeriodIDTextbox.Size = new Size(162, 27);
            CPeriodIDTextbox.TabIndex = 3;
            // 
            // CSectionIDLabel
            // 
            CSectionIDLabel.AutoSize = true;
            CSectionIDLabel.Location = new Point(12, 9);
            CSectionIDLabel.Name = "CSectionIDLabel";
            CSectionIDLabel.Size = new Size(77, 20);
            CSectionIDLabel.TabIndex = 7;
            CSectionIDLabel.Text = "Section ID";
            CSectionIDLabel.Click += CSectionIDLabel_Click;
            // 
            // CCourseIDLabel
            // 
            CCourseIDLabel.AutoSize = true;
            CCourseIDLabel.Location = new Point(12, 69);
            CCourseIDLabel.Name = "CCourseIDLabel";
            CCourseIDLabel.Size = new Size(73, 20);
            CCourseIDLabel.TabIndex = 8;
            CCourseIDLabel.Text = "Course ID";
            // 
            // CTeacherIDLabel
            // 
            CTeacherIDLabel.AutoSize = true;
            CTeacherIDLabel.Location = new Point(12, 131);
            CTeacherIDLabel.Name = "CTeacherIDLabel";
            CTeacherIDLabel.Size = new Size(79, 20);
            CTeacherIDLabel.TabIndex = 9;
            CTeacherIDLabel.Text = "Teacher ID";
            // 
            // CPeriodIDLabel
            // 
            CPeriodIDLabel.AutoSize = true;
            CPeriodIDLabel.Location = new Point(12, 192);
            CPeriodIDLabel.Name = "CPeriodIDLabel";
            CPeriodIDLabel.Size = new Size(70, 20);
            CPeriodIDLabel.TabIndex = 10;
            CPeriodIDLabel.Text = "Period ID";
            // 
            // CRNLabel
            // 
            CRNLabel.AutoSize = true;
            CRNLabel.Location = new Point(222, 9);
            CRNLabel.Name = "CRNLabel";
            CRNLabel.Size = new Size(107, 20);
            CRNLabel.TabIndex = 11;
            CRNLabel.Text = "Room Number";
            // 
            // CSLabel
            // 
            CSLabel.AutoSize = true;
            CSLabel.Location = new Point(222, 69);
            CSLabel.Name = "CSLabel";
            CSLabel.Size = new Size(70, 20);
            CSLabel.TabIndex = 12;
            CSLabel.Text = "Semester";
            // 
            // CSYLabel
            // 
            CSYLabel.AutoSize = true;
            CSYLabel.Location = new Point(222, 131);
            CSYLabel.Name = "CSYLabel";
            CSYLabel.Size = new Size(86, 20);
            CSYLabel.TabIndex = 13;
            CSYLabel.Text = "School Year";
            // 
            // CRNTextbox
            // 
            CRNTextbox.Location = new Point(222, 32);
            CRNTextbox.Name = "CRNTextbox";
            CRNTextbox.Size = new Size(162, 27);
            CRNTextbox.TabIndex = 14;
            // 
            // CSTextbox
            // 
            CSTextbox.Location = new Point(222, 92);
            CSTextbox.Name = "CSTextbox";
            CSTextbox.Size = new Size(162, 27);
            CSTextbox.TabIndex = 15;
            // 
            // CSYTextbox
            // 
            CSYTextbox.Location = new Point(222, 154);
            CSYTextbox.Name = "CSYTextbox";
            CSYTextbox.Size = new Size(162, 27);
            CSYTextbox.TabIndex = 16;
            // 
            // CCLabel
            // 
            CCLabel.AutoSize = true;
            CCLabel.Location = new Point(222, 192);
            CCLabel.Name = "CCLabel";
            CCLabel.Size = new Size(66, 20);
            CCLabel.TabIndex = 17;
            CCLabel.Text = "Capacity";
            // 
            // CCTextbox
            // 
            CCTextbox.Location = new Point(222, 215);
            CCTextbox.Name = "CCTextbox";
            CCTextbox.Size = new Size(162, 27);
            CCTextbox.TabIndex = 18;
            // 
            // CSearchbtn
            // 
            CSearchbtn.Location = new Point(151, 248);
            CSearchbtn.Name = "CSearchbtn";
            CSearchbtn.Size = new Size(94, 29);
            CSearchbtn.TabIndex = 19;
            CSearchbtn.Text = "Save";
            CSearchbtn.UseVisualStyleBackColor = true;
            CSearchbtn.Click += CSearchbtn_Click;
            // 
            // classAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 287);
            Controls.Add(CSearchbtn);
            Controls.Add(CCTextbox);
            Controls.Add(CCLabel);
            Controls.Add(CSYTextbox);
            Controls.Add(CSTextbox);
            Controls.Add(CRNTextbox);
            Controls.Add(CSYLabel);
            Controls.Add(CSLabel);
            Controls.Add(CRNLabel);
            Controls.Add(CPeriodIDLabel);
            Controls.Add(CTeacherIDLabel);
            Controls.Add(CCourseIDLabel);
            Controls.Add(CSectionIDLabel);
            Controls.Add(CPeriodIDTextbox);
            Controls.Add(CTeacherIDTextbox);
            Controls.Add(CCourseIDTextbox);
            Controls.Add(CSectionIDTextbox);
            Name = "classAdd";
            Text = "classAdd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CSectionIDTextbox;
        private TextBox CCourseIDTextbox;
        private TextBox CTeacherIDTextbox;
        private TextBox CPeriodIDTextbox;
        private Label CSectionIDLabel;
        private Label CCourseIDLabel;
        private Label CTeacherIDLabel;
        private Label CPeriodIDLabel;
        private Label CRNLabel;
        private Label CSLabel;
        private Label CSYLabel;
        private TextBox CRNTextbox;
        private TextBox CSTextbox;
        private TextBox CSYTextbox;
        private Label CCLabel;
        private TextBox CCTextbox;
        private Button CSearchbtn;
    }
}
namespace SchoolDatabase
{
    partial class studentAdd
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
            SIDLabel = new Label();
            Fnamelabel = new Label();
            label3 = new Label();
            LnameLabel = new Label();
            DOBlabel = new Label();
            Emaillabel = new Label();
            PNlabel = new Label();
            GLlabel = new Label();
            SIDTextbox = new TextBox();
            FNTextbox = new TextBox();
            LNTextbox = new TextBox();
            DOBTextbox = new TextBox();
            EmailTextbox = new TextBox();
            PNTextbox = new TextBox();
            GLTextbox = new TextBox();
            EDlabel = new Label();
            EDTextbox = new TextBox();
            studentSavebtn = new Button();
            SuspendLayout();
            // 
            // SIDLabel
            // 
            SIDLabel.AutoSize = true;
            SIDLabel.Location = new Point(12, 9);
            SIDLabel.Name = "SIDLabel";
            SIDLabel.Size = new Size(75, 20);
            SIDLabel.TabIndex = 0;
            SIDLabel.Text = "StudentID";
            // 
            // Fnamelabel
            // 
            Fnamelabel.AutoSize = true;
            Fnamelabel.Location = new Point(12, 71);
            Fnamelabel.Name = "Fnamelabel";
            Fnamelabel.Size = new Size(80, 20);
            Fnamelabel.TabIndex = 1;
            Fnamelabel.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(192, 218);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 2;
            // 
            // LnameLabel
            // 
            LnameLabel.AutoSize = true;
            LnameLabel.Location = new Point(12, 136);
            LnameLabel.Name = "LnameLabel";
            LnameLabel.Size = new Size(79, 20);
            LnameLabel.TabIndex = 3;
            LnameLabel.Text = "Last Name";
            // 
            // DOBlabel
            // 
            DOBlabel.AutoSize = true;
            DOBlabel.Location = new Point(12, 195);
            DOBlabel.Name = "DOBlabel";
            DOBlabel.Size = new Size(94, 20);
            DOBlabel.TabIndex = 4;
            DOBlabel.Text = "Date of Birth";
            // 
            // Emaillabel
            // 
            Emaillabel.AutoSize = true;
            Emaillabel.Location = new Point(253, 9);
            Emaillabel.Name = "Emaillabel";
            Emaillabel.Size = new Size(46, 20);
            Emaillabel.TabIndex = 5;
            Emaillabel.Text = "Email";
            // 
            // PNlabel
            // 
            PNlabel.AutoSize = true;
            PNlabel.Location = new Point(253, 71);
            PNlabel.Name = "PNlabel";
            PNlabel.Size = new Size(108, 20);
            PNlabel.TabIndex = 6;
            PNlabel.Text = "Phone Number";
            // 
            // GLlabel
            // 
            GLlabel.AutoSize = true;
            GLlabel.Location = new Point(253, 136);
            GLlabel.Name = "GLlabel";
            GLlabel.Size = new Size(87, 20);
            GLlabel.TabIndex = 7;
            GLlabel.Text = "Grade Level";
            // 
            // SIDTextbox
            // 
            SIDTextbox.Location = new Point(12, 32);
            SIDTextbox.Name = "SIDTextbox";
            SIDTextbox.Size = new Size(166, 27);
            SIDTextbox.TabIndex = 8;
            // 
            // FNTextbox
            // 
            FNTextbox.Location = new Point(12, 94);
            FNTextbox.Name = "FNTextbox";
            FNTextbox.Size = new Size(166, 27);
            FNTextbox.TabIndex = 9;
            // 
            // LNTextbox
            // 
            LNTextbox.Location = new Point(12, 159);
            LNTextbox.Name = "LNTextbox";
            LNTextbox.Size = new Size(166, 27);
            LNTextbox.TabIndex = 10;
            // 
            // DOBTextbox
            // 
            DOBTextbox.Location = new Point(12, 218);
            DOBTextbox.Name = "DOBTextbox";
            DOBTextbox.Size = new Size(166, 27);
            DOBTextbox.TabIndex = 11;
            // 
            // EmailTextbox
            // 
            EmailTextbox.Location = new Point(253, 32);
            EmailTextbox.Name = "EmailTextbox";
            EmailTextbox.Size = new Size(170, 27);
            EmailTextbox.TabIndex = 12;
            // 
            // PNTextbox
            // 
            PNTextbox.Location = new Point(253, 94);
            PNTextbox.Name = "PNTextbox";
            PNTextbox.Size = new Size(170, 27);
            PNTextbox.TabIndex = 13;
            // 
            // GLTextbox
            // 
            GLTextbox.Location = new Point(253, 159);
            GLTextbox.Name = "GLTextbox";
            GLTextbox.Size = new Size(170, 27);
            GLTextbox.TabIndex = 14;
            // 
            // EDlabel
            // 
            EDlabel.AutoSize = true;
            EDlabel.Location = new Point(253, 195);
            EDlabel.Name = "EDlabel";
            EDlabel.Size = new Size(125, 20);
            EDlabel.TabIndex = 15;
            EDlabel.Text = "Enrollement Date";
            // 
            // EDTextbox
            // 
            EDTextbox.Location = new Point(253, 218);
            EDTextbox.Name = "EDTextbox";
            EDTextbox.Size = new Size(170, 27);
            EDTextbox.TabIndex = 16;
            // 
            // studentSavebtn
            // 
            studentSavebtn.Location = new Point(165, 251);
            studentSavebtn.Name = "studentSavebtn";
            studentSavebtn.Size = new Size(94, 29);
            studentSavebtn.TabIndex = 17;
            studentSavebtn.Text = "Save";
            studentSavebtn.UseVisualStyleBackColor = true;
            studentSavebtn.Click += studentSavebtn_Click;
            // 
            // studentAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 296);
            Controls.Add(studentSavebtn);
            Controls.Add(EDTextbox);
            Controls.Add(EDlabel);
            Controls.Add(GLTextbox);
            Controls.Add(PNTextbox);
            Controls.Add(EmailTextbox);
            Controls.Add(DOBTextbox);
            Controls.Add(LNTextbox);
            Controls.Add(FNTextbox);
            Controls.Add(SIDTextbox);
            Controls.Add(GLlabel);
            Controls.Add(PNlabel);
            Controls.Add(Emaillabel);
            Controls.Add(DOBlabel);
            Controls.Add(LnameLabel);
            Controls.Add(label3);
            Controls.Add(Fnamelabel);
            Controls.Add(SIDLabel);
            Name = "studentAdd";
            Text = "Add Student";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SIDLabel;
        private Label Fnamelabel;
        private Label label3;
        private Label LnameLabel;
        private Label DOBlabel;
        private Label Emaillabel;
        private Label PNlabel;
        private Label GLlabel;
        private TextBox SIDTextbox;
        private TextBox FNTextbox;
        private TextBox LNTextbox;
        private TextBox DOBTextbox;
        private TextBox EmailTextbox;
        private TextBox PNTextbox;
        private TextBox GLTextbox;
        private Label EDlabel;
        private TextBox EDTextbox;
        private Button studentSavebtn;
    }
}
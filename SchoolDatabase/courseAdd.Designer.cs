namespace SchoolDatabase
{
    partial class courseAdd
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
            CourseIDLabel = new Label();
            CourseNumberLabel = new Label();
            CourseDescriptionLabel = new Label();
            CDepartmentIDLabel = new Label();
            CourseCreditsLabel = new Label();
            CourseIDTextbox = new TextBox();
            CourseNameTextbox = new TextBox();
            CourseDescriptionTextbox = new TextBox();
            CDepartmentIDTextbox = new TextBox();
            CourseCreditsTextbox = new TextBox();
            CourseSavebtn = new Button();
            SuspendLayout();
            // 
            // CourseIDLabel
            // 
            CourseIDLabel.AutoSize = true;
            CourseIDLabel.Location = new Point(12, 9);
            CourseIDLabel.Name = "CourseIDLabel";
            CourseIDLabel.Size = new Size(73, 20);
            CourseIDLabel.TabIndex = 0;
            CourseIDLabel.Text = "Course ID";
            CourseIDLabel.Click += label1_Click;
            // 
            // CourseNumberLabel
            // 
            CourseNumberLabel.AutoSize = true;
            CourseNumberLabel.Location = new Point(12, 73);
            CourseNumberLabel.Name = "CourseNumberLabel";
            CourseNumberLabel.Size = new Size(98, 20);
            CourseNumberLabel.TabIndex = 1;
            CourseNumberLabel.Text = "Course Name";
            // 
            // CourseDescriptionLabel
            // 
            CourseDescriptionLabel.AutoSize = true;
            CourseDescriptionLabel.Location = new Point(12, 134);
            CourseDescriptionLabel.Name = "CourseDescriptionLabel";
            CourseDescriptionLabel.Size = new Size(134, 20);
            CourseDescriptionLabel.TabIndex = 2;
            CourseDescriptionLabel.Text = "Course Description";
            // 
            // CDepartmentIDLabel
            // 
            CDepartmentIDLabel.AutoSize = true;
            CDepartmentIDLabel.Location = new Point(245, 9);
            CDepartmentIDLabel.Name = "CDepartmentIDLabel";
            CDepartmentIDLabel.Size = new Size(108, 20);
            CDepartmentIDLabel.TabIndex = 3;
            CDepartmentIDLabel.Text = "Department ID";
            // 
            // CourseCreditsLabel
            // 
            CourseCreditsLabel.AutoSize = true;
            CourseCreditsLabel.Location = new Point(245, 73);
            CourseCreditsLabel.Name = "CourseCreditsLabel";
            CourseCreditsLabel.Size = new Size(55, 20);
            CourseCreditsLabel.TabIndex = 4;
            CourseCreditsLabel.Text = "Credits";
            // 
            // CourseIDTextbox
            // 
            CourseIDTextbox.Location = new Point(12, 32);
            CourseIDTextbox.Name = "CourseIDTextbox";
            CourseIDTextbox.Size = new Size(175, 27);
            CourseIDTextbox.TabIndex = 5;
            // 
            // CourseNameTextbox
            // 
            CourseNameTextbox.Location = new Point(12, 96);
            CourseNameTextbox.Name = "CourseNameTextbox";
            CourseNameTextbox.Size = new Size(175, 27);
            CourseNameTextbox.TabIndex = 6;
            // 
            // CourseDescriptionTextbox
            // 
            CourseDescriptionTextbox.Location = new Point(12, 157);
            CourseDescriptionTextbox.Name = "CourseDescriptionTextbox";
            CourseDescriptionTextbox.Size = new Size(175, 27);
            CourseDescriptionTextbox.TabIndex = 7;
            // 
            // CDepartmentIDTextbox
            // 
            CDepartmentIDTextbox.Location = new Point(245, 32);
            CDepartmentIDTextbox.Name = "CDepartmentIDTextbox";
            CDepartmentIDTextbox.Size = new Size(175, 27);
            CDepartmentIDTextbox.TabIndex = 8;
            // 
            // CourseCreditsTextbox
            // 
            CourseCreditsTextbox.Location = new Point(245, 96);
            CourseCreditsTextbox.Name = "CourseCreditsTextbox";
            CourseCreditsTextbox.Size = new Size(175, 27);
            CourseCreditsTextbox.TabIndex = 9;
            // 
            // CourseSavebtn
            // 
            CourseSavebtn.Location = new Point(160, 190);
            CourseSavebtn.Name = "CourseSavebtn";
            CourseSavebtn.Size = new Size(94, 29);
            CourseSavebtn.TabIndex = 10;
            CourseSavebtn.Text = "Save";
            CourseSavebtn.UseVisualStyleBackColor = true;
            CourseSavebtn.Click += CourseSavebtn_Click;
            // 
            // courseAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 234);
            Controls.Add(CourseSavebtn);
            Controls.Add(CourseCreditsTextbox);
            Controls.Add(CDepartmentIDTextbox);
            Controls.Add(CourseDescriptionTextbox);
            Controls.Add(CourseNameTextbox);
            Controls.Add(CourseIDTextbox);
            Controls.Add(CourseCreditsLabel);
            Controls.Add(CDepartmentIDLabel);
            Controls.Add(CourseDescriptionLabel);
            Controls.Add(CourseNumberLabel);
            Controls.Add(CourseIDLabel);
            Name = "courseAdd";
            Text = "courseAdd";
            Load += courseAdd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CourseIDLabel;
        private Label CourseNumberLabel;
        private Label CourseDescriptionLabel;
        private Label CDepartmentIDLabel;
        private Label CourseCreditsLabel;
        private TextBox CourseIDTextbox;
        private TextBox CourseNameTextbox;
        private TextBox CourseDescriptionTextbox;
        private TextBox CDepartmentIDTextbox;
        private TextBox CourseCreditsTextbox;
        private Button CourseSavebtn;
    }
}
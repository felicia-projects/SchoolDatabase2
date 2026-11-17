
namespace SchoolDatabase
{
    partial class courseDelete
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
            dataGridView1 = new DataGridView();
            label2 = new Label();
            noButton = new Button();
            yesButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(537, 219);
            dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(205, 232);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 2;
            label2.Text = "Delete Course?";
            // 
            // noButton
            // 
            noButton.Location = new Point(309, 292);
            noButton.Name = "noButton";
            noButton.Size = new Size(94, 29);
            noButton.TabIndex = 3;
            noButton.Text = "NO";
            noButton.UseVisualStyleBackColor = true;
            noButton.Click += noButton_Click;
            // 
            // yesButton
            // 
            yesButton.Location = new Point(115, 292);
            yesButton.Name = "yesButton";
            yesButton.Size = new Size(94, 29);
            yesButton.TabIndex = 4;
            yesButton.Text = "YES";
            yesButton.UseVisualStyleBackColor = true;
            yesButton.Click += yesButton_Click;
            // 
            // courseDelete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 450);
            Controls.Add(yesButton);
            Controls.Add(noButton);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Name = "courseDelete";
            Text = "CourseDelete";
            Load += courseDelete_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label2;
        private Button noButton;
        private Button yesButton;
    }
}
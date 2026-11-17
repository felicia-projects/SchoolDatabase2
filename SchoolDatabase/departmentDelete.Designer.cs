namespace SchoolDatabase
{
    partial class departmentDelete
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
            noButton = new Button();
            yesButton = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // noButton
            // 
            noButton.Location = new Point(308, 308);
            noButton.Name = "noButton";
            noButton.Size = new Size(94, 29);
            noButton.TabIndex = 0;
            noButton.Text = "NO";
            noButton.UseVisualStyleBackColor = true;
            noButton.Click += noButton_Click;
            // 
            // yesButton
            // 
            yesButton.Location = new Point(109, 308);
            yesButton.Name = "yesButton";
            yesButton.Size = new Size(94, 29);
            yesButton.TabIndex = 1;
            yesButton.Text = "YES";
            yesButton.UseVisualStyleBackColor = true;
            yesButton.Click += this.yesButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(172, 265);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 2;
            label1.Text = "Delete Department? ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(488, 208);
            dataGridView1.TabIndex = 3;
            // 
            // departmentDelete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 450);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(yesButton);
            Controls.Add(noButton);
            Name = "departmentDelete";
            Text = "Delete Department";
            Load += departmentDelete_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button noButton;
        private Button yesButton;
        private Label label1;
        private DataGridView dataGridView1;
    }
}
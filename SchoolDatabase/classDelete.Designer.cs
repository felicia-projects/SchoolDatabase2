namespace SchoolDatabase
{
    partial class classDelete
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
            yesButton = new Button();
            noButton = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // yesButton
            // 
            yesButton.Location = new Point(97, 271);
            yesButton.Name = "yesButton";
            yesButton.Size = new Size(94, 29);
            yesButton.TabIndex = 0;
            yesButton.Text = "YES";
            yesButton.UseVisualStyleBackColor = true;
            yesButton.Click += this.yesButton_Click;
            // 
            // noButton
            // 
            noButton.Location = new Point(287, 271);
            noButton.Name = "noButton";
            noButton.Size = new Size(94, 29);
            noButton.TabIndex = 1;
            noButton.Text = "NO";
            noButton.UseVisualStyleBackColor = true;
            noButton.Click += noButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(190, 236);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 2;
            label1.Text = "Delete Class?";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(454, 192);
            dataGridView1.TabIndex = 3;
            // 
            // classDelete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 450);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(noButton);
            Controls.Add(yesButton);
            Name = "classDelete";
            Text = "classDelete.cs";
            Load += classDelete_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button yesButton;
        private Button noButton;
        private Label label1;
        private DataGridView dataGridView1;
    }
}
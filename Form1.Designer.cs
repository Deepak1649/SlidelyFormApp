namespace SlidelyFormApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnViewSubmissions = new Button();
            btnCreateSubmission = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btnViewSubmissions
            // 
            btnViewSubmissions.BackColor = Color.Yellow;
            btnViewSubmissions.Location = new Point(235, 133);
            btnViewSubmissions.Name = "btnViewSubmissions";
            btnViewSubmissions.Size = new Size(316, 55);
            btnViewSubmissions.TabIndex = 0;
            btnViewSubmissions.Text = "View Submissions (CTRL + V)";
            btnViewSubmissions.UseVisualStyleBackColor = false;
            btnViewSubmissions.Click += button1_Click;
            // 
            // btnCreateSubmission
            // 
            btnCreateSubmission.BackColor = Color.SkyBlue;
            btnCreateSubmission.Location = new Point(235, 201);
            btnCreateSubmission.Name = "btnCreateSubmission";
            btnCreateSubmission.Size = new Size(316, 55);
            btnCreateSubmission.TabIndex = 1;
            btnCreateSubmission.Text = "Create New Submission (CTRL + N)";
            btnCreateSubmission.UseVisualStyleBackColor = false;
            btnCreateSubmission.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Enabled = false;
            textBox1.Location = new Point(235, 35);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(403, 20);
            textBox1.TabIndex = 2;
            textBox1.Text = "Deepak Kumar Singh, Slidely Task 2- Form App";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(btnCreateSubmission);
            Controls.Add(btnViewSubmissions);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnViewSubmissions;
        private Button btnCreateSubmission;
        private TextBox textBox1;
    }
}

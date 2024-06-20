namespace SlidelyFormApp
{
    partial class CreateSubmissionForm
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
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtGithubLink = new TextBox();
            btnToggleStopwatch = new Button();
            txtStopwatch = new TextBox();
            btnSubmit = new Button();
            textBox1 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.Location = new Point(503, 86);
            txtName.Name = "txtName";
            txtName.Size = new Size(212, 27);
            txtName.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(503, 133);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(212, 27);
            txtEmail.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(503, 184);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(212, 27);
            txtPhone.TabIndex = 2;
            // 
            // txtGithubLink
            // 
            txtGithubLink.Location = new Point(503, 240);
            txtGithubLink.Name = "txtGithubLink";
            txtGithubLink.Size = new Size(212, 27);
            txtGithubLink.TabIndex = 3;
            // 
            // btnToggleStopwatch
            // 
            btnToggleStopwatch.BackColor = Color.Yellow;
            btnToggleStopwatch.Location = new Point(142, 322);
            btnToggleStopwatch.Name = "btnToggleStopwatch";
            btnToggleStopwatch.Size = new Size(302, 36);
            btnToggleStopwatch.TabIndex = 4;
            btnToggleStopwatch.Text = "TOGGLE STOPWATCH (CTRL+T)";
            btnToggleStopwatch.UseVisualStyleBackColor = false;
            btnToggleStopwatch.Click += btnToggleStopwatch_Click;
            // 
            // txtStopwatch
            // 
            txtStopwatch.Enabled = false;
            txtStopwatch.Location = new Point(549, 327);
            txtStopwatch.Name = "txtStopwatch";
            txtStopwatch.ReadOnly = true;
            txtStopwatch.Size = new Size(125, 27);
            txtStopwatch.TabIndex = 5;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.SkyBlue;
            btnSubmit.Location = new Point(322, 383);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(215, 33);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "SUBMIT (CTRL +S)";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(223, 29);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Name";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(492, 20);
            textBox1.TabIndex = 11;
            textBox1.Text = "Deepak Kumar Singh, Slidely Task 2- Create Submission ";
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Enabled = false;
            textBox6.Location = new Point(142, 242);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(276, 20);
            textBox6.TabIndex = 15;
            textBox6.Text = "Github Link for Task 2";
            // 
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Enabled = false;
            textBox7.Location = new Point(142, 191);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(276, 20);
            textBox7.TabIndex = 14;
            textBox7.Text = "Phone";
            // 
            // textBox8
            // 
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Enabled = false;
            textBox8.Location = new Point(142, 141);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(276, 20);
            textBox8.TabIndex = 13;
            textBox8.Text = "Email";
            // 
            // textBox9
            // 
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Enabled = false;
            textBox9.Location = new Point(142, 93);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(276, 20);
            textBox9.TabIndex = 12;
            textBox9.Text = "Name";
            // 
            // CreateSubmissionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox6);
            Controls.Add(textBox7);
            Controls.Add(textBox8);
            Controls.Add(textBox9);
            Controls.Add(textBox1);
            Controls.Add(btnSubmit);
            Controls.Add(txtStopwatch);
            Controls.Add(btnToggleStopwatch);
            Controls.Add(txtGithubLink);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            KeyPreview = true;
            Name = "CreateSubmissionForm";
            Text = "CreateSubmissionForm";
            Load += CreateSubmissionForm_Load;
            KeyDown += CreateSubmissionForm_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtGithubLink;
        private Button btnToggleStopwatch;
        private TextBox txtStopwatch;
        private Button btnSubmit;
        private TextBox textBox1;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
    }
}
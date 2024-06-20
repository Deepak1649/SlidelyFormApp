namespace SlidelyFormApp
{
    partial class ViewSubmissionForm
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
            textName = new TextBox();
            textEmail = new TextBox();
            textPhone = new TextBox();
            btnNext = new Button();
            btnPrevious = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            btnDelete = new Button();
            btnEdit = new Button();
            textGithubLink = new TextBox();
            textStopwatch = new TextBox();
            textBoxSearchEmail = new TextBox();
            btnSearch = new Button();
            SuspendLayout();
            // 
            // textName
            // 
            textName.Enabled = false;
            textName.Location = new Point(440, 105);
            textName.Name = "textName";
            textName.ReadOnly = true;
            textName.Size = new Size(276, 27);
            textName.TabIndex = 0;
            textName.TextChanged += textName_TextChanged;
            textName.KeyDown += ViewSubmissionForm_KeyDown;
            // 
            // textEmail
            // 
            textEmail.Enabled = false;
            textEmail.Location = new Point(440, 144);
            textEmail.Name = "textEmail";
            textEmail.ReadOnly = true;
            textEmail.Size = new Size(276, 27);
            textEmail.TabIndex = 1;
            // 
            // textPhone
            // 
            textPhone.Enabled = false;
            textPhone.Location = new Point(440, 182);
            textPhone.Name = "textPhone";
            textPhone.ReadOnly = true;
            textPhone.Size = new Size(276, 27);
            textPhone.TabIndex = 2;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.SkyBlue;
            btnNext.Location = new Point(475, 358);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(228, 40);
            btnNext.TabIndex = 5;
            btnNext.Text = "NEXT (CTRL + N)";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.Yellow;
            btnPrevious.Location = new Point(142, 358);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(228, 40);
            btnPrevious.TabIndex = 6;
            btnPrevious.Text = "PREVIOUS (CTRL + P)";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Enabled = false;
            textBox1.Location = new Point(94, 105);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(276, 20);
            textBox1.TabIndex = 7;
            textBox1.Text = "Name";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Enabled = false;
            textBox2.Location = new Point(94, 144);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(276, 20);
            textBox2.TabIndex = 8;
            textBox2.Text = "Email";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Enabled = false;
            textBox3.Location = new Point(94, 182);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(276, 20);
            textBox3.TabIndex = 9;
            textBox3.Text = "Phone";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Enabled = false;
            textBox4.Location = new Point(94, 223);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(276, 20);
            textBox4.TabIndex = 10;
            textBox4.Text = "Github Link for Task 2";
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Enabled = false;
            textBox5.Location = new Point(94, 265);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(276, 20);
            textBox5.TabIndex = 11;
            textBox5.Text = "StopwatchTime";
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Enabled = false;
            textBox6.Location = new Point(191, 23);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(472, 20);
            textBox6.TabIndex = 12;
            textBox6.Text = "Deepak Kumar Singh, Slidely Task 2- View Submission ";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Location = new Point(630, 307);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(144, 29);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "DELETE (CTRL + D)";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(475, 307);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 14;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // textGithubLink
            // 
            textGithubLink.Enabled = false;
            textGithubLink.Location = new Point(440, 223);
            textGithubLink.Name = "textGithubLink";
            textGithubLink.ReadOnly = true;
            textGithubLink.Size = new Size(276, 27);
            textGithubLink.TabIndex = 15;
            // 
            // textStopwatch
            // 
            textStopwatch.Enabled = false;
            textStopwatch.Location = new Point(440, 262);
            textStopwatch.Name = "textStopwatch";
            textStopwatch.ReadOnly = true;
            textStopwatch.Size = new Size(276, 27);
            textStopwatch.TabIndex = 16;
            // 
            // textBoxSearchEmail
            // 
            textBoxSearchEmail.Location = new Point(245, 63);
            textBoxSearchEmail.Name = "textBoxSearchEmail";
            textBoxSearchEmail.PlaceholderText = "Enter email for search";
            textBoxSearchEmail.Size = new Size(188, 27);
            textBoxSearchEmail.TabIndex = 17;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(499, 63);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 18;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // ViewSubmissionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSearch);
            Controls.Add(textBoxSearchEmail);
            Controls.Add(textStopwatch);
            Controls.Add(textGithubLink);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            Controls.Add(textPhone);
            Controls.Add(textEmail);
            Controls.Add(textName);
            KeyPreview = true;
            Name = "ViewSubmissionForm";
            Text = "Form2";
            KeyDown += ViewSubmissionForm_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textName;
        private TextBox textEmail;
        private TextBox textPhone;
        private Button btnNext;
        private Button btnPrevious;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button btnDelete;
        private Button btnEdit;
        private TextBox textGithubLink;
        private TextBox textStopwatch;
        private TextBox textBoxSearchEmail;
        private Button btnSearch;
    }
}
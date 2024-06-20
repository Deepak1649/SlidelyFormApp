namespace SlidelyFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           OpenViewSubmissionsForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenCreateSubmissionForm();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                OpenViewSubmissionsForm();
            }
            if (e.Control && e.KeyCode == Keys.N)
            {
                OpenCreateSubmissionForm();
            }
        }

        private void OpenViewSubmissionsForm()
        {
            ViewSubmissionForm viewForm = new ViewSubmissionForm();
            viewForm.Show();
        }
       
        private void OpenCreateSubmissionForm()
        {
            CreateSubmissionForm createForm = new CreateSubmissionForm();
            createForm.Show();
        }
    }
}

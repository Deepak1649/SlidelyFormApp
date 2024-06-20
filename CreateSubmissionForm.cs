using System;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Threading;

namespace SlidelyFormApp
{
    public partial class CreateSubmissionForm : Form
    {
        private HttpClient httpClient;
        private Stopwatch stopwatch;
        private System.Windows.Forms.Timer timer;
        private bool isEditMode;
        private int currentIndex;
        public CreateSubmissionForm(Submission submission = null, int index = -1)
        {
            httpClient = new HttpClient();
            stopwatch = new Stopwatch();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 100; // Update every 100 milliseconds
            timer.Enabled = true;
            timer.Tick += Timer_Tick;
            InitializeComponent();
            this.Activated += new EventHandler(CreateSubmissionForm_Activated);

            if (submission != null)
            {
                txtName.Text = submission.Name;
                txtEmail.Text = submission.Email;
                txtPhone.Text = submission.Phone;
                txtGithubLink.Text = submission.GithubLink;
                txtStopwatch.Text = submission.Stopwatch;
                stopwatch.Start(); // Resume stopwatch if necessary

                isEditMode = true;
                currentIndex = index;
            }
            else { isEditMode = false; }
        }

        private void CreateSubmissionForm_Activated(object sender, EventArgs e)
        {
            this.Focus();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {

            UpdateStopwatchDisplay();
        }

        private void CreateSubmissionForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.T)
            {
                ToggleStopwatch();
                e.Handled = true; // Mark the event as handled to stop further processing
                e.SuppressKeyPress = true;
            }
            if (e.Control && e.KeyCode == Keys.S)
            {
                SubmitForm();
                e.Handled = true; // Mark the event as handled to stop further processing
                e.SuppressKeyPress = true;
            }
        }


        private void btnToggleStopwatch_Click(object sender, EventArgs e)
        {
            ToggleStopwatch();
        }

        private void ToggleStopwatch()
        {

            if (stopwatch.IsRunning)
            {
                stopwatch.Stop();
            }
            else
            {
                stopwatch.Start();
            }
            UpdateStopwatchDisplay();

        }

        private void UpdateStopwatchDisplay()
        {
            txtStopwatch.Text = stopwatch.Elapsed.ToString(@"mm\:ss\.ff");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SubmitForm();
        }

        private async void SubmitForm()
        {
            var submission = new Submission
            {
                Name = txtName.Text,
                Email = txtEmail.Text,
                Phone = txtPhone.Text,
                GithubLink = txtGithubLink.Text,
                Stopwatch = txtStopwatch.Text,
            };


            // Save submission to JSON file or send to API


            var json = JsonConvert.SerializeObject(new
            {
                name = submission.Name,
                email = submission.Email,
                phone = submission.Phone,
                GithubLink = submission.GithubLink,
                Stopwatch = submission.Stopwatch
            });
            

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response;
                if (isEditMode)
                {
                    
                    // Include the index in the update request
                    json = JsonConvert.SerializeObject(new
                    {
                        index = currentIndex, // Set the current index for the submission
                        name = submission.Name,
                        email = submission.Email,
                        phone = submission.Phone,
                        GithubLink = submission.GithubLink,
                        Stopwatch = submission.Stopwatch
                    });
                    content = new StringContent(json, Encoding.UTF8, "application/json");
                    
                    response = await httpClient.PostAsync("http://localhost:3000/update", content);
                    
                }
                else
                {
                    response = await httpClient.PostAsync("http://localhost:3000/submit", content);
                }

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Submission successful!");
                }
                else
                {
                    MessageBox.Show("Submission failed. Status code: " + response.StatusCode);
                }
           
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateSubmissionForm_Load(object sender, EventArgs e)
        {

        }
    }
    public class Submission
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string GithubLink { get; set; }
        public string Stopwatch { get; set; }
    }
}


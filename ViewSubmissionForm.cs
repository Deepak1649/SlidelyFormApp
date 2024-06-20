using System;
using System.Diagnostics;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace SlidelyFormApp
{
    public partial class ViewSubmissionForm : Form
    {
        private HttpClient httpClient;
        private int currentIndex;

        public ViewSubmissionForm()
        {
            InitializeComponent();
            httpClient = new HttpClient();

            currentIndex = 0;
            this.Load += ViewSubmissionForm_Load; // Register the Load event
            this.Focus();

        }

        private async void ViewSubmissionForm_Load(object sender, EventArgs e)
        {
            await FetchSubmission(currentIndex); // Call the async method in the Load event handler
        }

        private void ViewSubmissionForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.P)
            {
                FetchPreviousSubmission();
            }
            else if (e.Control && e.KeyCode == Keys.N)
            {
                FetchNextSubmission();
            }
            else if (e.Control && e.KeyCode == Keys.D) 
            {
                DeleteSubmission();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            FetchPreviousSubmission();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteSubmission();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            FetchNextSubmission();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditCurrentSubmission();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchByEmail();
        }

        private void EditCurrentSubmission()
        {
            var editForm = new CreateSubmissionForm(currentSubmission,currentIndex);
            editForm.Show();
        }


        private async void FetchPreviousSubmission()
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                await FetchSubmission(currentIndex);
            }
        }

        private async void DeleteSubmission(){
            try
            {
                var response = await httpClient.DeleteAsync($"http://localhost:3000/delete?index={currentIndex}");
                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    await FetchSubmission(currentIndex);
                }
                else
                {
                    MessageBox.Show("Failed to Delete submission. Status code: " + response.StatusCode);
                    if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                    {
                        currentIndex = (currentIndex == 0) ? 0 : currentIndex - 1; // Reset index if at start or move back one step
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void SearchByEmail()
        {
            string email = textBoxSearchEmail.Text; // Assuming you have a TextBox named textBoxSearchEmail

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter an email to search for.");
                return;
            }

            try
            {
                var response = await httpClient.GetAsync($"http://localhost:3000/search?email={email}");
                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var submissions = JsonConvert.DeserializeObject<List<Submission>>(jsonResponse);
                    if (submissions.Count > 0)
                    {
                        currentIndex = 0; // Reset index to the first matching submission
                        DisplaySubmission(submissions[currentIndex]);
                    }
                    else
                    {
                        MessageBox.Show("No submissions found for the provided email.");
                    }
                }
                else
                {
                    MessageBox.Show("Failed to search submissions. Status code: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void FetchNextSubmission()
        {
            currentIndex++;
            await FetchSubmission(currentIndex);
        }

        public Submission currentSubmission;
        private async Task FetchSubmission(int index)
        {
            try
            {
                var response = await httpClient.GetAsync($"http://localhost:3000/read?index={index}");
                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    
                    var submission = JsonConvert.DeserializeObject<Submission>(jsonResponse);

                    currentSubmission = submission;
                    DisplaySubmission(submission);

                }
                else
                {
                    MessageBox.Show("Failed to fetch submission. Status code: " + response.StatusCode);
                    if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                    {
                        currentIndex = (index == 0) ? 0 : currentIndex - 1; // Reset index if at start or move back one step
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DisplaySubmission(Submission submission)
        {
            textName.Text = submission.Name;
            textEmail.Text = submission.Email;
            textPhone.Text = submission.Phone;
            textGithubLink.Text = submission.GithubLink;
            textStopwatch.Text = submission.Stopwatch;
            
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }


}

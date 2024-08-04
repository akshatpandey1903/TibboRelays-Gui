using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace relays
{
    public partial class Form1 : Form
    {
        private string sessionId;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Hide relay buttons initially
            relayButton1On.Visible = false;
            relayButton1Off.Visible = false;
            relayButton2On.Visible = false;
            relayButton2Off.Visible = false;
            relayButton3On.Visible = false;
            relayButton3Off.Visible = false;
            relayButton4On.Visible = false;
            relayButton4Off.Visible = false;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // Navigate to the login page
            webBrowser1.Navigate("http://1.0.0.1"); // Replace with the actual IP address
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser1.Url.ToString().EndsWith("home.html"))
            {
                // Extract the HTML content
                string htmlContent = webBrowser1.Document.Body.InnerHtml;

                // Use a regular expression to find the session ID
                string pattern = @"session=(\d+)";
                Match match = Regex.Match(htmlContent, pattern);

                if (match.Success)
                {
                    sessionId = match.Groups[1].Value;
                    MessageBox.Show("Session ID extracted: " + sessionId);

                    // Show relay buttons after successful login and session ID extraction
                    relayButton1On.Visible = true;
                    relayButton1Off.Visible = true;
                    relayButton2On.Visible = true;
                    relayButton2Off.Visible = true;
                    relayButton3On.Visible = true;
                    relayButton3Off.Visible = true;
                    relayButton4On.Visible = true;
                    relayButton4Off.Visible = true;
                }
                else
                {
                    MessageBox.Show("Session ID not found");
                }

                // Unsubscribe to avoid repeated event triggers
                webBrowser1.DocumentCompleted -= webBrowser1_DocumentCompleted;
            }
        }

        private async void ControlRelay(int relayNumber, bool state)
        {
            string relayParam = $"RL{relayNumber}={(state ? 1 : 0)}";
            string url = $"http://1.0.0.1/relays.html?session={sessionId}&{relayParam}";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Failed to control Relay {relayNumber}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void relayButton1On_Click(object sender, EventArgs e)
        {
            ControlRelay(1, true);
        }

        private void relayButton1Off_Click(object sender, EventArgs e)
        {
            ControlRelay(1, false);
        }

        private void relayButton2On_Click(object sender, EventArgs e)
        {
            ControlRelay(2, true);
        }

        private void relayButton2Off_Click(object sender, EventArgs e)
        {
            ControlRelay(2, false);
        }

        private void relayButton3On_Click(object sender, EventArgs e)
        {
            ControlRelay(3, true);
        }

        private void relayButton3Off_Click(object sender, EventArgs e)
        {
            ControlRelay(3, false);
        }

        private void relayButton4On_Click(object sender, EventArgs e)
        {
            ControlRelay(4, true);
        }

        private void relayButton4Off_Click(object sender, EventArgs e)
        {
            ControlRelay(4, false);
        }
    }
}

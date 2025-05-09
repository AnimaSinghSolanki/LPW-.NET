//Form1.cs

using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace LPW
{
    

    public partial class Form1 : Form
    {
        private string RunAdbCommand(string arguments)
        {
            Process process = null;
            try
            {
                // Create the process
                process = new Process();
                process.StartInfo.FileName = "adb";
                process.StartInfo.Arguments = arguments;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;

                // Start the process
                process.Start();

                // Read output and error streams
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                // Wait for the process to exit
                process.WaitForExit();

                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show($"ADB Error: {error}", "ADB Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                return output;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to execute ADB command: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
            finally
            {
                // Ensure the process is properly disposed
                process?.Dispose();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            // Simulating connection with ADB
            lblStatus.Text = "Connecting to device...";
            progressBar1.Value = 25;

            // Simulate checking ADB connection
            var adbProcess = new Process();
            adbProcess.StartInfo.FileName = "adb";
            adbProcess.StartInfo.Arguments = "devices";
            adbProcess.StartInfo.RedirectStandardOutput = true;
            adbProcess.StartInfo.UseShellExecute = false;
            adbProcess.StartInfo.CreateNoWindow = true;
            adbProcess.Start();
            string output = adbProcess.StandardOutput.ReadToEnd();
            adbProcess.WaitForExit();

            if (output.Contains("device"))
            {
                lblStatus.Text = "Device connected successfully!";
                progressBar1.Value = 100;
                btnRetrieveData.Enabled = true;
            }
            else
            {
                lblStatus.Text = "Failed to connect to device!";
                progressBar1.Value = 0;
            }
        }

        private void btnRetrieveData_Click(object sender, EventArgs e)
        {
            // Simulate retrieving data
            lblStatus.Text = "Retrieving data...";
            progressBar1.Value = 25;

            // Simulating data extraction process
            ExtractContacts();
            ExtractSMS();
            ExtractCallLogs();
            ExtractDeviceInfo();

            lblStatus.Text = "Data extraction complete!";
            progressBar1.Value = 100;
        }

        private void ExtractContacts()
        {
            // Placeholder for extracting contacts via ADB
            lblContactsStatus.Text = "Extracting Contacts...";
            string contacts = RunAdbCommand("shell content query --uri content://contacts/phones/");

            // Append the result to the TextBox (textBox1)
            textBox1.AppendText("----- Contacts -----\r\n");
            textBox1.AppendText(contacts);
            textBox1.AppendText("\r\n\r\n");  // Add some space between sections

            MessageBox.Show("Contacts displayed on the screen.");
        }


        private void ExtractSMS()
        {
            // Placeholder for extracting SMS via ADB
            lblSMSStatus.Text = "Extracting SMS...";
            string smsData = RunAdbCommand("shell content query --uri content://sms/");

            // Append the result to the TextBox (textBox1)
            textBox1.AppendText("----- SMS -----\r\n");
            textBox1.AppendText(smsData);
            textBox1.AppendText("\r\n\r\n");  // Add some space between sections

            MessageBox.Show("SMS messages displayed on the screen.");
        }
        

        private void ExtractCallLogs()
        {
            // Placeholder for extracting call logs via ADB
            lblCallLogsStatus.Text = "Extracting Call Logs...";
            string callLogData = RunAdbCommand("shell content query --uri content://call_log/calls/");

            // Append the result to the TextBox (textBox1)
            textBox1.AppendText("----- Call Logs -----\r\n");
            textBox1.AppendText(callLogData);
            textBox1.AppendText("\r\n\r\n");  // Add some space between sections

            MessageBox.Show("Call logs displayed on the screen.");
        }

        private void ExtractDeviceInfo()
        {
            // Placeholder for extracting device info via ADB
            lblDeviceInfoStatus.Text = "Extracting Device Info...";
            string deviceInfo = RunAdbCommand("shell getprop");

            // Append the result to the TextBox (textBox1)
            textBox1.AppendText("----- Device Info -----\r\n");
            textBox1.AppendText(deviceInfo);
            textBox1.AppendText("\r\n\r\n");  // Add some space between sections

            MessageBox.Show("Device information displayed on the screen.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Example: Display the number of characters in the TextBox
            lblStatus.Text = $"Text length: {textBox1.Text.Length} characters";
        }
    }
}

//Form1.Designer.cs

using System;
using System.Windows.Forms;


namespace LPW
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnConnect;
        private Label lblStatus;
        private ProgressBar progressBar1;
        private Button btnRetrieveData;
        private Label lblContactsStatus;
        private Label lblSMSStatus;
        private Label lblCallLogsStatus;
        private Label lblDeviceInfoStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnRetrieveData = new System.Windows.Forms.Button();
            this.lblContactsStatus = new System.Windows.Forms.Label();
            this.lblSMSStatus = new System.Windows.Forms.Label();
            this.lblCallLogsStatus = new System.Windows.Forms.Label();
            this.lblDeviceInfoStatus = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnConnect.Location = new System.Drawing.Point(40, 30);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(200, 40);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect to Device";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(40, 80);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(300, 23);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status: Waiting for connection...";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(40, 110);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(300, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // btnRetrieveData
            // 
            this.btnRetrieveData.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRetrieveData.Enabled = false;
            this.btnRetrieveData.Location = new System.Drawing.Point(40, 150);
            this.btnRetrieveData.Name = "btnRetrieveData";
            this.btnRetrieveData.Size = new System.Drawing.Size(200, 40);
            this.btnRetrieveData.TabIndex = 3;
            this.btnRetrieveData.Text = "Retrieve Data from Device";
            this.btnRetrieveData.UseVisualStyleBackColor = false;
            this.btnRetrieveData.Click += new System.EventHandler(this.btnRetrieveData_Click);
            // 
            // lblContactsStatus
            // 
            this.lblContactsStatus.Location = new System.Drawing.Point(40, 200);
            this.lblContactsStatus.Name = "lblContactsStatus";
            this.lblContactsStatus.Size = new System.Drawing.Size(300, 23);
            this.lblContactsStatus.TabIndex = 4;
            this.lblContactsStatus.Text = "Contacts: Not started";
            // 
            // lblSMSStatus
            // 
            this.lblSMSStatus.Location = new System.Drawing.Point(40, 230);
            this.lblSMSStatus.Name = "lblSMSStatus";
            this.lblSMSStatus.Size = new System.Drawing.Size(300, 23);
            this.lblSMSStatus.TabIndex = 5;
            this.lblSMSStatus.Text = "SMS: Not started";
            // 
            // lblCallLogsStatus
            // 
            this.lblCallLogsStatus.Location = new System.Drawing.Point(40, 260);
            this.lblCallLogsStatus.Name = "lblCallLogsStatus";
            this.lblCallLogsStatus.Size = new System.Drawing.Size(300, 23);
            this.lblCallLogsStatus.TabIndex = 6;
            this.lblCallLogsStatus.Text = "Call Logs: Not started";
            // 
            // lblDeviceInfoStatus
            // 
            this.lblDeviceInfoStatus.Location = new System.Drawing.Point(40, 290);
            this.lblDeviceInfoStatus.Name = "lblDeviceInfoStatus";
            this.lblDeviceInfoStatus.Size = new System.Drawing.Size(300, 23);
            this.lblDeviceInfoStatus.TabIndex = 7;
            this.lblDeviceInfoStatus.Text = "Device Info: Not started";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(701, 30);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(539, 477);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1467, 678);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblDeviceInfoStatus);
            this.Controls.Add(this.lblCallLogsStatus);
            this.Controls.Add(this.lblSMSStatus);
            this.Controls.Add(this.lblContactsStatus);
            this.Controls.Add(this.btnRetrieveData);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "LPW - Data Extraction from Android";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private TextBox textBox1;
    }
}

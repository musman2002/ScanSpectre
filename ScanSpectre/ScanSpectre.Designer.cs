using System.Drawing;
using System.Windows.Forms;

namespace ScanSpectre
{
    partial class ScanSpectre
    {
        private Guna.UI2.WinForms.Guna2Panel topPanel;
        private Guna.UI2.WinForms.Guna2Panel settingsPanel;
        private Guna.UI2.WinForms.Guna2Button btnSettings;
        private Guna.UI2.WinForms.Guna2ToggleSwitch themeToggle;
        private Guna.UI2.WinForms.Guna2HtmlLabel themeLabel;
        private Guna.UI2.WinForms.Guna2Panel inputPanel;
        private Guna.UI2.WinForms.Guna2TextBox txtHost;
        private Guna.UI2.WinForms.Guna2TextBox txtStartPort;
        private Guna.UI2.WinForms.Guna2TextBox txtEndPort;
        private Guna.UI2.WinForms.Guna2TextBox txtTimeout;
        private Guna.UI2.WinForms.Guna2TextBox txtThreads;
        private Guna.UI2.WinForms.Guna2Button btnStart;
        private System.Windows.Forms.DataGridView gridResults;

        private void InitializeComponent()
        {
            this.topPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSettings = new Guna.UI2.WinForms.Guna2Button();
            var appTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            var logoSmall = new Guna.UI2.WinForms.Guna2PictureBox();
            this.settingsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.themeLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.themeToggle = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.inputPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.txtHost = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtStartPort = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEndPort = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTimeout = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtThreads = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnStart = new Guna.UI2.WinForms.Guna2Button();
            this.gridResults = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(logoSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridResults)).BeginInit();
            this.topPanel.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.inputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Dock = DockStyle.Top;
            this.topPanel.Location = new Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new Size(1000, 50);
            this.topPanel.TabIndex = 0;
            this.topPanel.ShadowDecoration.Enabled = false;
            // 
            // logoSmall
            // 
            logoSmall.SizeMode = PictureBoxSizeMode.Zoom;
            logoSmall.Location = new Point(12, 7);
            logoSmall.Size = new Size(36, 36);
            logoSmall.BackColor = Color.Transparent;
            try
            {
                if (System.IO.File.Exists("assets/logo.png"))
                {
                    logoSmall.Image = Image.FromFile("assets/logo.png");
                }
            }
            catch { }
            // 
            // appTitle
            // 
            appTitle.BackColor = Color.Transparent;
            appTitle.Text = "ScanSpectre";
            appTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            appTitle.ForeColor = Color.White;
            appTitle.Location = new Point(56, 12);
            // 
            // btnSettings
            // 
            this.btnSettings.BorderRadius = 8;
            this.btnSettings.Font = new Font("Segoe UI", 9F);
            this.btnSettings.ForeColor = Color.White;
            this.btnSettings.Location = new Point(940, 7);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new Size(45, 35);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "⚙";
            this.btnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // add controls to topPanel
            // 
            this.topPanel.Controls.Add(logoSmall);
            this.topPanel.Controls.Add(appTitle);
            this.topPanel.Controls.Add(this.btnSettings);
            // 
            // settingsPanel
            // 
            this.settingsPanel.Dock = DockStyle.Left;
            this.settingsPanel.Location = new Point(0, 50);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new Size(200, 600);
            this.settingsPanel.TabIndex = 1;
            this.settingsPanel.Visible = false;
            // 
            // themeLabel
            // 
            this.themeLabel.BackColor = Color.Transparent;
            this.themeLabel.Location = new Point(20, 40);
            this.themeLabel.Name = "themeLabel";
            this.themeLabel.Size = new Size(61, 17);
            this.themeLabel.TabIndex = 0;
            this.themeLabel.Text = "Dark Mode";
            // 
            // themeToggle
            // 
            this.themeToggle.Location = new Point(120, 40);
            this.themeToggle.Name = "themeToggle";
            this.themeToggle.Size = new Size(40, 20);
            this.themeToggle.TabIndex = 1;
            this.themeToggle.CheckedChanged += new System.EventHandler(this.ThemeToggle_CheckedChanged);
            // 
            // add controls to settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.themeLabel);
            this.settingsPanel.Controls.Add(this.themeToggle);
            // 
            // inputPanel
            // 
            this.inputPanel.Location = new Point(220, 60);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new Size(720, 80);
            this.inputPanel.FillColor = Color.FromArgb(32, 32, 38);
            this.inputPanel.BorderRadius = 12;
            this.inputPanel.TabIndex = 2;
            // 
            // txtHost
            // 
            this.txtHost.Font = new Font("Segoe UI", 9F);
            this.txtHost.Location = new Point(15, 20);
            this.txtHost.Name = "txtHost";
            this.txtHost.PlaceholderText = "Host / Domain";
            this.txtHost.Size = new Size(230, 36);
            this.txtHost.TabIndex = 0;
            // 
            // txtStartPort
            // 
            this.txtStartPort.Font = new Font("Segoe UI", 9F);
            this.txtStartPort.Location = new Point(255, 20);
            this.txtStartPort.Name = "txtStartPort";
            this.txtStartPort.PlaceholderText = "Start Port";
            this.txtStartPort.Size = new Size(100, 36);
            this.txtStartPort.TabIndex = 1;
            // 
            // txtEndPort
            // 
            this.txtEndPort.Font = new Font("Segoe UI", 9F);
            this.txtEndPort.Location = new Point(365, 20);
            this.txtEndPort.Name = "txtEndPort";
            this.txtEndPort.PlaceholderText = "End Port";
            this.txtEndPort.Size = new Size(100, 36);
            this.txtEndPort.TabIndex = 2;
            // 
            // txtTimeout
            // 
            this.txtTimeout.Font = new Font("Segoe UI", 9F);
            this.txtTimeout.Location = new Point(475, 20);
            this.txtTimeout.Name = "txtTimeout";
            this.txtTimeout.PlaceholderText = "Timeout (ms)";
            this.txtTimeout.Size = new Size(110, 36);
            this.txtTimeout.TabIndex = 3;
            // 
            // txtThreads
            // 
            this.txtThreads.Font = new Font("Segoe UI", 9F);
            this.txtThreads.Location = new Point(595, 20);
            this.txtThreads.Name = "txtThreads";
            this.txtThreads.PlaceholderText = "Threads";
            this.txtThreads.Size = new Size(110, 36);
            this.txtThreads.TabIndex = 4;
            // 
            // add input controls to inputPanel
            // 
            this.inputPanel.Controls.Add(this.txtHost);
            this.inputPanel.Controls.Add(this.txtStartPort);
            this.inputPanel.Controls.Add(this.txtEndPort);
            this.inputPanel.Controls.Add(this.txtTimeout);
            this.inputPanel.Controls.Add(this.txtThreads);
            // 
            // btnStart
            // 
            this.btnStart.BorderRadius = 10;
            this.btnStart.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnStart.ForeColor = Color.White;
            this.btnStart.Location = new Point(220, 150);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new Size(200, 45);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start Scan";
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // gridResults
            // 
            this.gridResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.gridResults.Location = new Point(220, 210);
            this.gridResults.Name = "gridResults";
            this.gridResults.ReadOnly = true;
            this.gridResults.Size = new Size(720, 400);
            this.gridResults.TabIndex = 4;
            this.gridResults.AllowUserToAddRows = false;
            this.gridResults.AllowUserToDeleteRows = false;
            this.gridResults.RowHeadersVisible = false;
            this.gridResults.BorderStyle = BorderStyle.None;
            this.gridResults.EnableHeadersVisualStyles = false;
            this.gridResults.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 50);
            this.gridResults.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.gridResults.DefaultCellStyle.BackColor = Color.FromArgb(30, 30, 35);
            this.gridResults.DefaultCellStyle.ForeColor = Color.White;
            this.gridResults.DefaultCellStyle.SelectionBackColor = Color.FromArgb(55, 105, 255);
            this.gridResults.DefaultCellStyle.SelectionForeColor = Color.White;
            this.gridResults.RowTemplate.Height = 32;
            this.gridResults.Columns.Clear();
            this.gridResults.Columns.Add("Port", "Port");
            this.gridResults.Columns.Add("Status", "Status");
            // 
            // ScanSpectreForm
            // 
            this.ClientSize = new Size(1000, 650);
            this.Controls.Add(this.gridResults);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.inputPanel);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.topPanel);
            this.Name = "ScanSpectreForm";
            this.Text = "ScanSpectre";
            this.StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(logoSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridResults)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.inputPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}

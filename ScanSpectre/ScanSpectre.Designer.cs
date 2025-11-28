namespace ScanSpectre
{
    partial class ScanSpectre
    {
        private Guna.UI2.WinForms.Guna2Panel topPanel;
        private Guna.UI2.WinForms.Guna2Panel settingsPanel;
        private Guna.UI2.WinForms.Guna2Button btnSettings;
        private Guna.UI2.WinForms.Guna2ToggleSwitch themeToggle;
        private Guna.UI2.WinForms.Guna2HtmlLabel themeLabel;
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
            this.settingsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.themeToggle = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.themeLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtHost = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtStartPort = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEndPort = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTimeout = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtThreads = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnStart = new Guna.UI2.WinForms.Guna2Button();
            this.gridResults = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.gridResults)).BeginInit();
            this.SuspendLayout();

            // topPanel
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Size = new System.Drawing.Size(900, 50);
            this.topPanel.Controls.Add(this.btnSettings);

            // btnSettings
            this.btnSettings.Text = "⚙";
            this.btnSettings.Size = new System.Drawing.Size(45, 45);
            this.btnSettings.Location = new System.Drawing.Point(840, 3);
            this.btnSettings.BorderRadius = 8;
            this.btnSettings.Click += (s, e) => settingsPanel.Visible = !settingsPanel.Visible;

            // settingsPanel
            this.settingsPanel.Size = new System.Drawing.Size(200, 900);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.settingsPanel.Visible = false;
            this.settingsPanel.Controls.Add(this.themeLabel);
            this.settingsPanel.Controls.Add(this.themeToggle);

            // themeLabel
            this.themeLabel.Text = "Dark Mode";
            this.themeLabel.Location = new System.Drawing.Point(20, 40);

            // themeToggle
            this.themeToggle.Location = new System.Drawing.Point(120, 40);
            this.themeToggle.CheckedChanged += (s, e) =>
            {
                ThemeManager.ToggleTheme(this);
            };

            // txtHost
            this.txtHost.PlaceholderText = "Host / Domain";
            this.txtHost.Location = new System.Drawing.Point(220, 70);
            this.txtHost.Width = 250;

            // txtStartPort
            this.txtStartPort.PlaceholderText = "Start Port";
            this.txtStartPort.Location = new System.Drawing.Point(480, 70);
            this.txtStartPort.Width = 100;

            // txtEndPort
            this.txtEndPort.PlaceholderText = "End Port";
            this.txtEndPort.Location = new System.Drawing.Point(590, 70);
            this.txtEndPort.Width = 100;

            // txtTimeout
            this.txtTimeout.PlaceholderText = "Timeout (ms)";
            this.txtTimeout.Location = new System.Drawing.Point(700, 70);
            this.txtTimeout.Width = 120;

            // txtThreads
            this.txtThreads.PlaceholderText = "Threads";
            this.txtThreads.Location = new System.Drawing.Point(830, 70);
            this.txtThreads.Width = 100;

            // btnStart
            this.btnStart.Text = "Start Scan";
            this.btnStart.Location = new System.Drawing.Point(220, 120);
            this.btnStart.Size = new System.Drawing.Size(150, 40);
            this.btnStart.BorderRadius = 10;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);

            // gridResults
            this.gridResults.Location = new System.Drawing.Point(220, 180);
            this.gridResults.Size = new System.Drawing.Size(710, 400);
            this.gridResults.ReadOnly = true;
            this.gridResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // Form
            this.Controls.Add(this.gridResults);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtThreads);
            this.Controls.Add(this.txtTimeout);
            this.Controls.Add(this.txtEndPort);
            this.Controls.Add(this.txtStartPort);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.topPanel);
            this.Text = "ScanSpectre";
            this.ClientSize = new System.Drawing.Size(1000, 650);

            ThemeManager.ApplyTheme(this);

            ((System.ComponentModel.ISupportInitialize)(this.gridResults)).EndInit();
            this.ResumeLayout(false);
        }
    }
}

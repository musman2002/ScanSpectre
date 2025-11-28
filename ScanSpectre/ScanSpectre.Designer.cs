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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            topPanel = new Guna.UI2.WinForms.Guna2Panel();
            btnSettings = new Guna.UI2.WinForms.Guna2Button();
            settingsPanel = new Guna.UI2.WinForms.Guna2Panel();
            themeLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            themeToggle = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            txtHost = new Guna.UI2.WinForms.Guna2TextBox();
            txtStartPort = new Guna.UI2.WinForms.Guna2TextBox();
            txtEndPort = new Guna.UI2.WinForms.Guna2TextBox();
            txtTimeout = new Guna.UI2.WinForms.Guna2TextBox();
            txtThreads = new Guna.UI2.WinForms.Guna2TextBox();
            btnStart = new Guna.UI2.WinForms.Guna2Button();
            gridResults = new DataGridView();
            topPanel.SuspendLayout();
            settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridResults).BeginInit();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.Controls.Add(btnSettings);
            topPanel.CustomizableEdges = customizableEdges3;
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            topPanel.Size = new Size(1000, 50);
            topPanel.TabIndex = 8;
            // 
            // btnSettings
            // 
            btnSettings.BorderRadius = 8;
            btnSettings.CustomizableEdges = customizableEdges1;
            btnSettings.Font = new Font("Segoe UI", 9F);
            btnSettings.ForeColor = Color.White;
            btnSettings.Location = new Point(840, 3);
            btnSettings.Name = "btnSettings";
            btnSettings.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSettings.Size = new Size(45, 45);
            btnSettings.TabIndex = 0;
            btnSettings.Text = "⚙";
            btnSettings.Click += BtnSettings_Click;
            // 
            // settingsPanel
            // 
            settingsPanel.Controls.Add(themeLabel);
            settingsPanel.Controls.Add(themeToggle);
            settingsPanel.CustomizableEdges = customizableEdges7;
            settingsPanel.Dock = DockStyle.Left;
            settingsPanel.Location = new Point(0, 50);
            settingsPanel.Name = "settingsPanel";
            settingsPanel.ShadowDecoration.CustomizableEdges = customizableEdges8;
            settingsPanel.Size = new Size(200, 600);
            settingsPanel.TabIndex = 7;
            settingsPanel.Visible = false;
            // 
            // themeLabel
            // 
            themeLabel.BackColor = Color.Transparent;
            themeLabel.Location = new Point(20, 40);
            themeLabel.Name = "themeLabel";
            themeLabel.Size = new Size(61, 17);
            themeLabel.TabIndex = 0;
            themeLabel.Text = "Dark Mode";
            // 
            // themeToggle
            // 
            themeToggle.CustomizableEdges = customizableEdges5;
            themeToggle.Location = new Point(120, 40);
            themeToggle.Name = "themeToggle";
            themeToggle.ShadowDecoration.CustomizableEdges = customizableEdges6;
            themeToggle.Size = new Size(35, 20);
            themeToggle.TabIndex = 1;
            themeToggle.CheckedChanged += ThemeToggle_CheckedChanged;
            // 
            // txtHost
            // 
            txtHost.CustomizableEdges = customizableEdges9;
            txtHost.DefaultText = "";
            txtHost.Font = new Font("Segoe UI", 9F);
            txtHost.Location = new Point(220, 70);
            txtHost.Name = "txtHost";
            txtHost.PlaceholderText = "Host / Domain";
            txtHost.SelectedText = "";
            txtHost.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtHost.Size = new Size(250, 36);
            txtHost.TabIndex = 6;
            // 
            // txtStartPort
            // 
            txtStartPort.CustomizableEdges = customizableEdges11;
            txtStartPort.DefaultText = "";
            txtStartPort.Font = new Font("Segoe UI", 9F);
            txtStartPort.Location = new Point(480, 70);
            txtStartPort.Name = "txtStartPort";
            txtStartPort.PlaceholderText = "Start Port";
            txtStartPort.SelectedText = "";
            txtStartPort.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtStartPort.Size = new Size(100, 36);
            txtStartPort.TabIndex = 5;
            // 
            // txtEndPort
            // 
            txtEndPort.CustomizableEdges = customizableEdges13;
            txtEndPort.DefaultText = "";
            txtEndPort.Font = new Font("Segoe UI", 9F);
            txtEndPort.Location = new Point(590, 70);
            txtEndPort.Name = "txtEndPort";
            txtEndPort.PlaceholderText = "End Port";
            txtEndPort.SelectedText = "";
            txtEndPort.ShadowDecoration.CustomizableEdges = customizableEdges14;
            txtEndPort.Size = new Size(100, 36);
            txtEndPort.TabIndex = 4;
            // 
            // txtTimeout
            // 
            txtTimeout.CustomizableEdges = customizableEdges15;
            txtTimeout.DefaultText = "";
            txtTimeout.Font = new Font("Segoe UI", 9F);
            txtTimeout.Location = new Point(700, 70);
            txtTimeout.Name = "txtTimeout";
            txtTimeout.PlaceholderText = "Timeout (ms)";
            txtTimeout.SelectedText = "";
            txtTimeout.ShadowDecoration.CustomizableEdges = customizableEdges16;
            txtTimeout.Size = new Size(120, 36);
            txtTimeout.TabIndex = 3;
            // 
            // txtThreads
            // 
            txtThreads.CustomizableEdges = customizableEdges17;
            txtThreads.DefaultText = "";
            txtThreads.Font = new Font("Segoe UI", 9F);
            txtThreads.Location = new Point(830, 70);
            txtThreads.Name = "txtThreads";
            txtThreads.PlaceholderText = "Threads";
            txtThreads.SelectedText = "";
            txtThreads.ShadowDecoration.CustomizableEdges = customizableEdges18;
            txtThreads.Size = new Size(100, 36);
            txtThreads.TabIndex = 2;
            // 
            // btnStart
            // 
            btnStart.BorderRadius = 10;
            btnStart.CustomizableEdges = customizableEdges19;
            btnStart.Font = new Font("Segoe UI", 9F);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(220, 120);
            btnStart.Name = "btnStart";
            btnStart.ShadowDecoration.CustomizableEdges = customizableEdges20;
            btnStart.Size = new Size(150, 40);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start Scan";
            btnStart.Click += BtnStart_Click;
            // 
            // gridResults
            // 
            gridResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridResults.Location = new Point(220, 180);
            gridResults.Name = "gridResults";
            gridResults.ReadOnly = true;
            gridResults.Size = new Size(710, 400);
            gridResults.TabIndex = 0;
            // 
            // ScanSpectre
            // 
            ClientSize = new Size(1000, 650);
            Controls.Add(gridResults);
            Controls.Add(btnStart);
            Controls.Add(txtThreads);
            Controls.Add(txtTimeout);
            Controls.Add(txtEndPort);
            Controls.Add(txtStartPort);
            Controls.Add(txtHost);
            Controls.Add(settingsPanel);
            Controls.Add(topPanel);
            Name = "ScanSpectre";
            Text = "ScanSpectre";
            topPanel.ResumeLayout(false);
            settingsPanel.ResumeLayout(false);
            settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridResults).EndInit();
            ResumeLayout(false);
        }
    }
}

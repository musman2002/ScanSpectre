using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace ScanSpectre
{
    partial class ScanSpectre
    {
        private Guna2TextBox txtHost;
        private Guna2TextBox txtStart;
        private Guna2TextBox txtEnd;
        private Guna2TextBox txtTimeout;
        private Guna2TextBox txtThreads;
        private Guna2Button btnScan;
        private Guna2ComboBox cmbTheme;
        private DataGridView gridResults;
        private Label lblCurrentPort;

        private void InitializeComponent()
        {
            this.txtHost = new Guna2TextBox();
            this.txtStart = new Guna2TextBox();
            this.txtEnd = new Guna2TextBox();
            this.txtTimeout = new Guna2TextBox();
            this.txtThreads = new Guna2TextBox();
            this.cmbTheme = new Guna2ComboBox();
            this.btnScan = new Guna2Button();
            this.gridResults = new DataGridView();
            this.lblCurrentPort = new Label();

            this.SuspendLayout();

            // Host
            txtHost.PlaceholderText = "IP or Domain";
            txtHost.Location = new System.Drawing.Point(20, 20);
            txtHost.Size = new System.Drawing.Size(300, 40);

            // Start Port
            txtStart.PlaceholderText = "Start Port";
            txtStart.Location = new System.Drawing.Point(20, 70);
            txtStart.Size = new System.Drawing.Size(140, 40);

            // End Port
            txtEnd.PlaceholderText = "End Port";
            txtEnd.Location = new System.Drawing.Point(180, 70);
            txtEnd.Size = new System.Drawing.Size(140, 40);

            // Timeout
            txtTimeout.PlaceholderText = "Timeout (ms)";
            txtTimeout.Location = new System.Drawing.Point(20, 120);
            txtTimeout.Size = new System.Drawing.Size(140, 40);

            // Threads
            txtThreads.PlaceholderText = "Threads";
            txtThreads.Location = new System.Drawing.Point(180, 120);
            txtThreads.Size = new System.Drawing.Size(140, 40);

            // Theme Combo
            cmbTheme.Location = new System.Drawing.Point(20, 170);
            cmbTheme.Size = new System.Drawing.Size(300, 40);
            cmbTheme.Items.AddRange(new string[] { "Dark", "Light", "Hybrid", "Blue Modern" });

            // Scan Button
            btnScan.Text = "Start Scan";
            btnScan.Location = new System.Drawing.Point(20, 220);
            btnScan.Size = new System.Drawing.Size(300, 45);

            // DataGridView
            gridResults.Location = new System.Drawing.Point(20, 280);
            gridResults.Size = new System.Drawing.Size(500, 300);
            gridResults.Columns.Add("Port", "Port");
            gridResults.Columns.Add("Status", "Status");

            // Current Port Label
            lblCurrentPort.Location = new System.Drawing.Point(350, 20);
            lblCurrentPort.Size = new System.Drawing.Size(200, 40);
            lblCurrentPort.Text = "Current Port: -";

            // Form
            this.ClientSize = new System.Drawing.Size(550, 600);
            this.Controls.Add(txtHost);
            this.Controls.Add(txtStart);
            this.Controls.Add(txtEnd);
            this.Controls.Add(txtTimeout);
            this.Controls.Add(txtThreads);
            this.Controls.Add(btnScan);
            this.Controls.Add(cmbTheme);
            this.Controls.Add(gridResults);
            this.Controls.Add(lblCurrentPort);

            this.Text = "ScanSpectre — TCP Scanner";
            this.Load += ScanSpectre_Load;

            this.ResumeLayout(false);
        }
    }
}

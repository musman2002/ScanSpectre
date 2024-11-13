namespace ScanSpectre
{
    partial class ScanSpectre
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.NumericUpDown txtStartPort;
        private System.Windows.Forms.NumericUpDown txtEndPort;
        private System.Windows.Forms.NumericUpDown txtTimeout;
        private System.Windows.Forms.TextBox txtCurrentPort;
        private System.Windows.Forms.Button btnStartScan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.Label lblStartPort;
        private System.Windows.Forms.Label lblEndPort;
        private System.Windows.Forms.Label lblTimeout;
        private System.Windows.Forms.Label lblCurrentPort;
        private System.Windows.Forms.GroupBox grpSettings;

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
            this.txtIp = new System.Windows.Forms.TextBox();
            this.txtStartPort = new System.Windows.Forms.NumericUpDown();
            this.txtEndPort = new System.Windows.Forms.NumericUpDown();
            this.txtTimeout = new System.Windows.Forms.NumericUpDown();
            this.txtCurrentPort = new System.Windows.Forms.TextBox();
            this.btnStartScan = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblIp = new System.Windows.Forms.Label();
            this.lblStartPort = new System.Windows.Forms.Label();
            this.lblEndPort = new System.Windows.Forms.Label();
            this.lblTimeout = new System.Windows.Forms.Label();
            this.lblCurrentPort = new System.Windows.Forms.Label();
            this.grpSettings = new System.Windows.Forms.GroupBox();

            ((System.ComponentModel.ISupportInitialize)(this.txtStartPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();

            this.SuspendLayout();

            // txtIp
            this.txtIp.Location = new System.Drawing.Point(120, 25);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(140, 23);
            this.txtIp.TabIndex = 0;
            this.txtIp.Text = "Enter IP/Domain";

            // txtStartPort
            this.txtStartPort.Location = new System.Drawing.Point(120, 60);
            this.txtStartPort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            this.txtStartPort.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.txtStartPort.Name = "txtStartPort";
            this.txtStartPort.Size = new System.Drawing.Size(140, 23);
            this.txtStartPort.TabIndex = 1;

            // txtEndPort
            this.txtEndPort.Location = new System.Drawing.Point(120, 95);
            this.txtEndPort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            this.txtEndPort.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.txtEndPort.Name = "txtEndPort";
            this.txtEndPort.Size = new System.Drawing.Size(140, 23);
            this.txtEndPort.TabIndex = 2;

            // txtTimeout
            this.txtTimeout.Location = new System.Drawing.Point(120, 130);
            this.txtTimeout.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.txtTimeout.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.txtTimeout.Name = "txtTimeout";
            this.txtTimeout.Size = new System.Drawing.Size(140, 23);
            this.txtTimeout.TabIndex = 3;
            this.txtTimeout.Value = 1000;

            // txtCurrentPort
            this.txtCurrentPort.Location = new System.Drawing.Point(120, 165);
            this.txtCurrentPort.Name = "txtCurrentPort";
            this.txtCurrentPort.ReadOnly = true;
            this.txtCurrentPort.Size = new System.Drawing.Size(140, 23);
            this.txtCurrentPort.TabIndex = 4;
            this.txtCurrentPort.Text = "Current Port";

            // btnStartScan
            this.btnStartScan.Location = new System.Drawing.Point(15, 200);
            this.btnStartScan.Name = "btnStartScan";
            this.btnStartScan.Size = new System.Drawing.Size(245, 35);
            this.btnStartScan.TabIndex = 5;
            this.btnStartScan.Text = "Start Scan";
            this.btnStartScan.UseVisualStyleBackColor = true;
            this.btnStartScan.Click += new System.EventHandler(this.btnStartScan_Click);

            // dataGridView1
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                new System.Windows.Forms.DataGridViewTextBoxColumn() { Name = "Port", HeaderText = "Port", Width = 75 },
                new System.Windows.Forms.DataGridViewTextBoxColumn() { Name = "Status", HeaderText = "Status", Width = 75 },
                new System.Windows.Forms.DataGridViewTextBoxColumn() { Name = "Service", HeaderText = "Service/Banner", Width = 200 }
            });
            this.dataGridView1.Location = new System.Drawing.Point(15, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(400, 200);
            this.dataGridView1.TabIndex = 6;

            // lblIp
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(15, 28);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(75, 15);
            this.lblIp.TabIndex = 7;
            this.lblIp.Text = "IP/Domain:";

            // lblStartPort
            this.lblStartPort.AutoSize = true;
            this.lblStartPort.Location = new System.Drawing.Point(15, 63);
            this.lblStartPort.Name = "lblStartPort";
            this.lblStartPort.Size = new System.Drawing.Size(58, 15);
            this.lblStartPort.TabIndex = 8;
            this.lblStartPort.Text = "Start Port:";

            // lblEndPort
            this.lblEndPort.AutoSize = true;
            this.lblEndPort.Location = new System.Drawing.Point(15, 98);
            this.lblEndPort.Name = "lblEndPort";
            this.lblEndPort.Size = new System.Drawing.Size(54, 15);
            this.lblEndPort.TabIndex = 9;
            this.lblEndPort.Text = "End Port:";

            // lblTimeout
            this.lblTimeout.AutoSize = true;
            this.lblTimeout.Location = new System.Drawing.Point(15, 133);
            this.lblTimeout.Name = "lblTimeout";
            this.lblTimeout.Size = new System.Drawing.Size(81, 15);
            this.lblTimeout.TabIndex = 10;
            this.lblTimeout.Text = "Timeout (ms):";

            // lblCurrentPort
            this.lblCurrentPort.AutoSize = true;
            this.lblCurrentPort.Location = new System.Drawing.Point(15, 168);
            this.lblCurrentPort.Name = "lblCurrentPort";
            this.lblCurrentPort.Size = new System.Drawing.Size(75, 15);
            this.lblCurrentPort.TabIndex = 11;
            this.lblCurrentPort.Text = "Current Port:";

            // grpSettings
            this.grpSettings.Controls.Add(this.txtIp);
            this.grpSettings.Controls.Add(this.lblCurrentPort);
            this.grpSettings.Controls.Add(this.txtStartPort);
            this.grpSettings.Controls.Add(this.lblTimeout);
            this.grpSettings.Controls.Add(this.txtEndPort);
            this.grpSettings.Controls.Add(this.lblEndPort);
            this.grpSettings.Controls.Add(this.txtTimeout);
            this.grpSettings.Controls.Add(this.lblStartPort);
            this.grpSettings.Controls.Add(this.txtCurrentPort);
            this.grpSettings.Controls.Add(this.lblIp);
            this.grpSettings.Location = new System.Drawing.Point(12, 12);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Size = new System.Drawing.Size(270, 220);
            this.grpSettings.TabIndex = 12;
            this.grpSettings.TabStop = false;
            this.grpSettings.Text = "Scan Settings";

            // ScanSpectre (Main Form)
            this.ClientSize = new System.Drawing.Size(450, 500);
            this.Controls.Add(this.grpSettings);
            this.Controls.Add(this.btnStartScan);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ScanSpectre";
            this.Text = "ScanSpectre - TCP Port Scanner";

            ((System.ComponentModel.ISupportInitialize)(this.txtStartPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

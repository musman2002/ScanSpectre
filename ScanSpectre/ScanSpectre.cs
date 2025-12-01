using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScanSpectre
{
    public partial class ScanSpectre : Form
    {
        public ScanSpectre()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            // Optional: uncomment if you want acrylic on the main window too
            // AcrylicBlur.ApplyAcrylic(this.Handle);
        }

        private async void BtnStart_Click(object sender, EventArgs e)
        {
            gridResults.Rows.Clear();

            string host = txtHost.Text.Trim();
            if (string.IsNullOrWhiteSpace(host))
            {
                MessageBox.Show("Please enter a host or domain.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtStartPort.Text, out int start) ||
                !int.TryParse(txtEndPort.Text, out int end) ||
                !int.TryParse(txtTimeout.Text, out int timeout) ||
                !int.TryParse(txtThreads.Text, out int threads))
            {
                MessageBox.Show("Please enter valid numeric values for ports, timeout and threads.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AddressList list = new() { StartPort = start, EndPort = end };
            if (!list.IsValidRange())
            {
                MessageBox.Show("Invalid port range.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (threads <= 0)
            {
                MessageBox.Show("Threads must be greater than zero.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnStart.Enabled = false;
            btnStart.Text = "Scanning...";

            try
            {
                AddressScanner scanner = new(host, timeout, threads);

                foreach (var port in list.GetPorts())
                {
                    var result = await scanner.ScanPortAsync(port);
                    gridResults.Rows.Add(result.Port, result.Status);
                    gridResults.FirstDisplayedScrollingRowIndex = gridResults.RowCount - 1;
                    Application.DoEvents();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during scan: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnStart.Enabled = true;
                btnStart.Text = "Start Scan";
            }
        }

        private async void BtnSettings_Click(object sender, EventArgs e)
        {
            await AnimatePanel(settingsPanel);
        }

        private void ThemeToggle_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.ToggleTheme(this);
        }

        private async Task AnimatePanel(Control panel)
        {
            int targetWidth;
            bool opening;

            if (!panel.Visible || panel.Width == 0)
            {
                panel.Visible = true;
                panel.Width = 0;
                targetWidth = 200;
                opening = true;
            }
            else
            {
                targetWidth = 0;
                opening = false;
            }

            while (opening ? panel.Width < targetWidth : panel.Width > targetWidth)
            {
                panel.Width += opening ? 20 : -20;
                if (panel.Width < 0) panel.Width = 0;
                if (panel.Width > 200) panel.Width = 200;
                await Task.Delay(10);
            }

            if (!opening)
            {
                panel.Visible = false;
            }
        }
    }
}

using System;
using System.Windows.Forms;

namespace ScanSpectre
{
    public partial class ScanSpectre : Form
    {
        public ScanSpectre()
        {
            InitializeComponent();
        }

        private void ScanSpectre_Load(object? sender, EventArgs e)
        {
            cmbTheme.SelectedIndexChanged += (s, ev) =>
            {
                ThemeManager.CurrentTheme = (ThemeManager.AppTheme)cmbTheme.SelectedIndex;
                ThemeManager.ApplyTheme(this);
            };

            ThemeManager.ApplyTheme(this);

            btnScan.Click += async (s, ev) =>
            {
                gridResults.Rows.Clear();

                string host = txtHost.Text;
                int start = int.Parse(txtStart.Text);
                int end = int.Parse(txtEnd.Text);
                int timeout = int.Parse(txtTimeout.Text);
                int threads = int.Parse(txtThreads.Text);

                var scanner = new AddressScanner(host, timeout, threads);
                var range = new AddressList(start, end);

                scanner.OnResult += result =>
                {
                    Invoke(new Action(() =>
                    {
                        gridResults.Rows.Add(result.Port, result.Status);
                    }));
                };

                scanner.OnCurrentPort += port =>
                {
                    Invoke(new Action(() =>
                    {
                        lblCurrentPort.Text = $"Current Port: {port}";
                    }));
                };

                await scanner.StartAsync(range);
                MessageBox.Show("Scan complete!", "Done");
            };
        }
    }
}

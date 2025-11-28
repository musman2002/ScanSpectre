using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScanSpectre
{
    public partial class ScanSpectre : Form
    {
        public ScanSpectre()
        {
            InitializeComponent();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            gridResults.Rows.Clear();

            string host = txtHost.Text.Trim();
            int start = int.Parse(txtStartPort.Text);
            int end = int.Parse(txtEndPort.Text);
            int timeout = int.Parse(txtTimeout.Text);
            int threads = int.Parse(txtThreads.Text);

            AddressList list = new() { StartPort = start, EndPort = end };
            if (!list.IsValidRange())
            {
                MessageBox.Show("Invalid port range.");
                return;
            }

            AddressScanner scanner = new(host, timeout, threads);

            foreach (var port in list.GetPorts())
            {
                var result = await scanner.ScanPortAsync(port);
                gridResults.Rows.Add(result.Port, result.Status);
            }
        }
    }
}

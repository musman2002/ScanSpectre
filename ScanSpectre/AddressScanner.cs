using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScanSpectre
{
    public class AddressScanner
    {
        private readonly string ipAddress;
        private readonly int startPort;
        private readonly int endPort;
        private readonly int timeout;
        private readonly DataGridView dataGridView;
        private readonly TextBox txtCurrentPort;
        private readonly Form form;
        private readonly Button scanButton;
        private readonly List<string> scanResults;

        public AddressScanner(string ipAddress, int startPort, int endPort, int timeout,
                              DataGridView dataGridView, TextBox txtCurrentPort, Form form, Button scanButton)
        {
            this.ipAddress = ipAddress;
            this.startPort = startPort;
            this.endPort = endPort;
            this.timeout = timeout;
            this.dataGridView = dataGridView;
            this.txtCurrentPort = txtCurrentPort;
            this.form = form;
            this.scanButton = scanButton;
            this.scanResults = new List<string>();
        }

        public async void StartScan()
        {
            scanResults.Clear(); // Clear previous scan results

            for (int port = startPort; port <= endPort; port++)
            {
                txtCurrentPort.Invoke((Action)(() => txtCurrentPort.Text = port.ToString()));

                bool isOpen = await ScanPortAsync(ipAddress, port, timeout);
                string status = isOpen ? "Open" : "Closed";
                scanResults.Add($"Port {port}: {status}");

                dataGridView.Invoke((Action)(() =>
                {
                    int rowIndex = dataGridView.Rows.Add();
                    dataGridView.Rows[rowIndex].Cells[0].Value = port;
                    dataGridView.Rows[rowIndex].Cells[1].Value = status;
                }));
            }

            MessageBox.Show("Scanning Complete", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            scanButton.Invoke((Action)(() => scanButton.Enabled = true));
        }

        private async Task<bool> ScanPortAsync(string ipAddress, int port, int timeout)
        {
            try
            {
                using (var client = new TcpClient())
                {
                    var connectTask = client.ConnectAsync(ipAddress, port);
                    var resultTask = await Task.WhenAny(connectTask, Task.Delay(timeout));
                    return connectTask == resultTask && client.Connected;
                }
            }
            catch
            {
                return false;
            }
        }

        public void SaveResultsToFile(string filePath)
        {
            try
            {
                File.WriteAllLines(filePath, scanResults);
                MessageBox.Show("Results saved successfully!", "Save File", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving results: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

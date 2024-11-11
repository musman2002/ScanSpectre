using System;
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
        }

        public async void StartScan()
        {
            for (int port = startPort; port <= endPort; port++)
            {
                txtCurrentPort.Invoke((Action)(() => txtCurrentPort.Text = port.ToString()));

                bool isOpen = await ScanPortAsync(ipAddress, port, timeout);
                dataGridView.Invoke((Action)(() =>
                {
                    int rowIndex = dataGridView.Rows.Add();
                    dataGridView.Rows[rowIndex].Cells[0].Value = port;
                    dataGridView.Rows[rowIndex].Cells[1].Value = isOpen ? "Open" : "Closed";
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
    }
}

using System;
using System.Net.Sockets;
using System.Text;
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
                string banner = isOpen ? await GrabBannerAsync(ipAddress, port) : "Closed";

                dataGridView.Invoke((Action)(() =>
                {
                    int rowIndex = dataGridView.Rows.Add();
                    dataGridView.Rows[rowIndex].Cells[0].Value = port;
                    dataGridView.Rows[rowIndex].Cells[1].Value = isOpen ? "Open" : "Closed";
                    dataGridView.Rows[rowIndex].Cells[2].Value = banner;
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

        private async Task<string> GrabBannerAsync(string ipAddress, int port)
        {
            try
            {
                using (var client = new TcpClient())
                {
                    await client.ConnectAsync(ipAddress, port);
                    using (NetworkStream stream = client.GetStream())
                    {
                        stream.ReadTimeout = timeout;

                        // Send a basic request (for HTTP, use GET).
                        byte[] request = Encoding.ASCII.GetBytes("GET / HTTP/1.1\r\nHost: " + ipAddress + "\r\n\r\n");
                        await stream.WriteAsync(request, 0, request.Length);

                        // Read the response (banner).
                        byte[] buffer = new byte[1024];
                        int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);

                        string response = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                        string[] lines = response.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

                        // Simple check to categorize the service
                        if (response.Contains("HTTP"))
                            return "HTTP Server - " + lines[0];
                        if (response.ToUpper().Contains("FTP"))
                            return "FTP Server - Banner Detected";
                        if (response.Contains("SSH"))
                            return "SSH Server - Banner Detected";

                        return lines.Length > 0 ? lines[0] : "Unknown Service";
                    }
                }
            }
            catch
            {
                return "Banner Not Available";
            }
        }
    }
}

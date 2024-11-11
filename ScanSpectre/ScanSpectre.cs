using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Concurrent;

namespace ScanSpectre
{
    public partial class ScanSpectre : Form
    {
        public ScanSpectre()
        {
            InitializeComponent();
        }

        private void btnStartScan_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            btnStartScan.Enabled = false;

            AddressScanner scanner = new AddressScanner(
                txtIp.Text,
                int.Parse(txtStartPort.Text),
                int.Parse(txtEndPort.Text),
                int.Parse(txtTimeout.Text),
                dataGridView1,
                txtCurrentPort,
                this,
                btnStartScan);

            scanner.StartScan();
        }
    }
}

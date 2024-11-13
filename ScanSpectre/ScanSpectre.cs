using System;
using System.Windows.Forms;

namespace ScanSpectre
{
    public partial class ScanSpectre : Form
    {
        public ScanSpectre()
        {
            InitializeComponent();
            txtIp.GotFocus += RemoveText;
            txtIp.LostFocus += AddText;
        }

        private void RemoveText(object sender, EventArgs e)
        {
            if (txtIp.Text == "Enter IP/Domain")
            {
                txtIp.Text = "";
            }
        }

        private void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIp.Text))
            {
                txtIp.Text = "Enter IP/Domain";
            }
        }

        private void btnStartScan_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            btnStartScan.Enabled = false;

            AddressScanner scanner = new AddressScanner(
                txtIp.Text,
                (int)txtStartPort.Value,
                (int)txtEndPort.Value,
                (int)txtTimeout.Value,
                dataGridView1,
                txtCurrentPort,
                this,
                btnStartScan);

            scanner.StartScan();
        }
    }
}

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
        private AddressScanner scanner;

        public ScanSpectre()
        {
            InitializeComponent();
        }

        private void btnStartScan_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            btnStartScan.Enabled = false;

            scanner = new AddressScanner(
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

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            if (scanner == null)
            {
                MessageBox.Show("No scan results to save. Please run a scan first.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    scanner.SaveResultsToFile(saveFileDialog.FileName);
                }
            }
        }
    }
}

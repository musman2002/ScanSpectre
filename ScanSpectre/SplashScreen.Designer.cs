using System.Drawing;
using System.Windows.Forms;

namespace ScanSpectre
{
    partial class SplashScreen
    {
        private Guna.UI2.WinForms.Guna2PictureBox logo;
        private Guna.UI2.WinForms.Guna2ProgressBar progressBar;
        private Guna.UI2.WinForms.Guna2HtmlLabel loadingText;
        private Guna.UI2.WinForms.Guna2ShadowForm shadow;
        private Guna.UI2.WinForms.Guna2BorderlessForm borderlessForm;

        private void InitializeComponent()
        {
            this.logo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.progressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.loadingText = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.shadow = new Guna.UI2.WinForms.Guna2ShadowForm();
            this.borderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm();

            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();

            // borderlessForm
            this.borderlessForm.ContainerControl = this;
            this.borderlessForm.BorderRadius = 22;

            // shadow
            this.shadow.TargetForm = this;

            // SplashScreen
            this.BackColor = Color.FromArgb(20, 20, 25);
            this.ClientSize = new Size(420, 300);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.DoubleBuffered = true;
            this.Opacity = 0.05;

            // logo
            this.logo.SizeMode = PictureBoxSizeMode.Zoom;
            this.logo.Location = new Point(110, 40);
            this.logo.Size = new Size(200, 140);
            this.logo.BackColor = Color.Transparent;

            // progressBar
            this.progressBar.Location = new Point(60, 220);
            this.progressBar.Size = new Size(300, 12);
            this.progressBar.FillColor = Color.FromArgb(60, 60, 70);
            this.progressBar.ProgressColor = Color.DeepSkyBlue;
            this.progressBar.ProgressColor2 = Color.MediumSlateBlue;
            this.progressBar.BorderRadius = 6;

            // loadingText
            this.loadingText.Text = "Loading";
            this.loadingText.ForeColor = Color.White;
            this.loadingText.Font = new Font("Segoe UI Semibold", 12);
            this.loadingText.BackColor = Color.Transparent;
            this.loadingText.Location = new Point(175, 255);

            this.Controls.Add(this.logo);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.loadingText);

            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
        }
    }
}

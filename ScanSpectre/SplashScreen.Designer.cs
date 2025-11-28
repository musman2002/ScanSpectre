namespace ScanSpectre
{
    partial class SplashScreen
    {
        private Guna.UI2.WinForms.Guna2ProgressIndicator loader;
        private Guna.UI2.WinForms.Guna2HtmlLabel appTitle;

        private void InitializeComponent()
        {
            this.loader = new Guna.UI2.WinForms.Guna2ProgressIndicator();
            this.appTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();

            // loader
            this.loader.Location = new System.Drawing.Point(140, 120);
            this.loader.Name = "loader";
            this.loader.Size = new System.Drawing.Size(80, 80);
            this.loader.TabIndex = 0;
            this.loader.CircleSize = 1F;
            this.loader.ProgressColor = System.Drawing.Color.DeepSkyBlue;

            // appTitle
            this.appTitle.BackColor = System.Drawing.Color.Transparent;
            this.appTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.appTitle.ForeColor = System.Drawing.Color.White;
            this.appTitle.Location = new System.Drawing.Point(90, 50);
            this.appTitle.Name = "appTitle";
            this.appTitle.Size = new System.Drawing.Size(176, 34);
            this.appTitle.TabIndex = 1;
            this.appTitle.Text = "ScanSpectre";

            // SplashScreen
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 230);
            this.Controls.Add(this.appTitle);
            this.Controls.Add(this.loader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 35);
            this.Name = "SplashScreen";
            this.Opacity = 0.95;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

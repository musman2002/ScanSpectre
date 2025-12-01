using Guna.UI2.WinForms;
using System.Drawing;
using System.Windows.Forms;

namespace ScanSpectre
{
    public static class ThemeManager
    {
        public enum ThemeMode { Light, Dark }
        public static ThemeMode CurrentTheme { get; private set; } = ThemeMode.Light;

        public static void ApplyTheme(Control root)
        {
            if (CurrentTheme == ThemeMode.Light)
                ApplyLight(root);
            else
                ApplyDark(root);

            root.Refresh();
        }

        public static void ToggleTheme(Control root)
        {
            CurrentTheme = CurrentTheme == ThemeMode.Light ? ThemeMode.Dark : ThemeMode.Light;
            ApplyTheme(root);
        }

        private static void ApplyLight(Control root)
        {
            root.BackColor = Color.White;

            foreach (Control c in root.Controls)
            {
                if (c is Guna2Panel panel)
                    panel.FillColor = Color.White;

                if (c is Guna2TextBox tb)
                {
                    tb.FillColor = Color.White;
                    tb.ForeColor = Color.Black;
                }

                if (c is Guna2Button btn)
                {
                    btn.FillColor = Color.FromArgb(80, 140, 255);
                    btn.ForeColor = Color.White;
                }

                if (c is DataGridView dgv)
                {
                    dgv.BackgroundColor = Color.White;
                    dgv.DefaultCellStyle.BackColor = Color.White;
                    dgv.DefaultCellStyle.ForeColor = Color.Black;
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                }

                if (c is Label lbl)
                    lbl.ForeColor = Color.Black;

                if (c is Guna2HtmlLabel html)
                    html.ForeColor = Color.Black;

                ApplyLight(c);
            }
        }

        private static void ApplyDark(Control root)
        {
            root.BackColor = Color.FromArgb(28, 28, 30);

            foreach (Control c in root.Controls)
            {
                if (c is Guna2Panel panel)
                    panel.FillColor = Color.FromArgb(40, 40, 45);

                if (c is Guna2TextBox tb)
                {
                    tb.FillColor = Color.FromArgb(50, 50, 55);
                    tb.ForeColor = Color.White;
                }

                if (c is Guna2Button btn)
                {
                    btn.FillColor = Color.FromArgb(55, 105, 255);
                    btn.ForeColor = Color.White;
                }

                if (c is DataGridView dgv)
                {
                    dgv.BackgroundColor = Color.FromArgb(30, 30, 32);
                    dgv.DefaultCellStyle.BackColor = Color.FromArgb(50, 50, 55);
                    dgv.DefaultCellStyle.ForeColor = Color.White;
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(70, 70, 75);
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                }

                if (c is Label lbl)
                    lbl.ForeColor = Color.White;

                if (c is Guna2HtmlLabel html)
                    html.ForeColor = Color.White;

                ApplyDark(c);
            }
        }
    }
}

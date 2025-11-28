using Guna.UI2.WinForms;
using System.Drawing;
using System.Windows.Forms;

namespace ScanSpectre
{
    public static class ThemeManager
    {
        public enum AppTheme
        {
            Dark,
            Light,
            Hybrid,
            BlueModern
        }

        public static AppTheme CurrentTheme = AppTheme.Dark;

        public static void ApplyTheme(Control root)
        {
            switch (CurrentTheme)
            {
                case AppTheme.Dark:
                    ApplyDark(root);
                    break;
                case AppTheme.Light:
                    ApplyLight(root);
                    break;
                case AppTheme.Hybrid:
                    ApplyHybrid(root);
                    break;
                case AppTheme.BlueModern:
                    ApplyBlueModern(root);
                    break;
            }
        }

        private static void ApplyDark(Control root)
        {
            root.BackColor = Color.FromArgb(18, 18, 18);
            foreach (Control c in root.Controls)
                StyleControl(c, Color.FromArgb(18, 18, 18), Color.White);
        }

        private static void ApplyLight(Control root)
        {
            root.BackColor = Color.White;
            foreach (Control c in root.Controls)
                StyleControl(c, Color.White, Color.Black);
        }

        private static void ApplyHybrid(Control root)
        {
            root.BackColor = Color.White;
            foreach (Control c in root.Controls)
                StyleControl(c, Color.FromArgb(30, 30, 30), Color.White);
        }

        private static void ApplyBlueModern(Control root)
        {
            root.BackColor = Color.FromArgb(22, 105, 170);
            foreach (Control c in root.Controls)
                StyleControl(c, Color.FromArgb(22, 105, 170), Color.White);
        }

        private static void StyleControl(Control ctrl, Color back, Color fore)
        {
            ctrl.ForeColor = fore;
            if (ctrl is Guna2Button btn)
            {
                btn.FillColor = fore;
                btn.ForeColor = back;
            }
            else if (ctrl is Guna2TextBox tb)
            {
                tb.FillColor = Color.FromArgb(back.R + 10, back.G + 10, back.B + 10);
                tb.ForeColor = fore;
            }
            else if (ctrl is Guna2ComboBox cb)
            {
                cb.FillColor = back;
                cb.ForeColor = fore;
            }

            foreach (Control child in ctrl.Controls)
                StyleControl(child, back, fore);
        }
    }
}

using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ScanSpectre
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        protected override async void OnShown(EventArgs e)
        {
            base.OnShown(e);

            loader.Start();

            await FadeInAsync();
            await Task.Delay(1600); // splash display time
            await FadeOutAsync();

            this.Close();
        }

        private async Task FadeInAsync()
        {
            for (double op = 0; op <= 1.0; op += 0.05)
            {
                this.Opacity = op;
                await Task.Delay(20);
            }
        }

        private async Task FadeOutAsync()
        {
            for (double op = 1.0; op >= 0; op -= 0.05)
            {
                this.Opacity = op;
                await Task.Delay(20);
            }
        }
    }
}

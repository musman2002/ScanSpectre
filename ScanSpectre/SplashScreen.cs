using System;
using System.Drawing;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScanSpectre
{
    public partial class SplashScreen : Form
    {
        private float scale = 1f;
        private bool scaleUp = true;
        private int dotCount = 0;
        private readonly SoundPlayer? whoosh;

        public SplashScreen()
        {
            InitializeComponent();

            // Load logo and audio safely
            if (System.IO.File.Exists("assets/logo.png"))
                logo.Image = Image.FromFile("assets/logo.png");

            if (System.IO.File.Exists("assets/whoosh.wav"))
                whoosh = new SoundPlayer("assets/whoosh.wav");
        }

        protected override async void OnShown(EventArgs e)
        {
            base.OnShown(e);

            whoosh?.Play();

            await FadeInAsync();

            AnimateLogo();
            AnimateLoadingText();
            SimulateProgress();

            await Task.Delay(3000);
            await FadeOutAsync();

            this.Close();
        }

        private async Task FadeInAsync()
        {
            for (double op = 0.0; op <= 1.0; op += 0.04)
            {
                this.Opacity = op;
                await Task.Delay(15);
            }
        }

        private async Task FadeOutAsync()
        {
            for (double op = 1.0; op >= 0; op -= 0.04)
            {
                this.Opacity = op;
                await Task.Delay(15);
            }
        }

        private async void AnimateLogo()
        {
            while (this.Visible)
            {
                if (scaleUp)
                {
                    scale += 0.01f;
                    if (scale >= 1.08f) scaleUp = false;
                }
                else
                {
                    scale -= 0.01f;
                    if (scale <= 0.92f) scaleUp = true;
                }

                logo.Size = new Size(
                    (int)(200 * scale),
                    (int)(140 * scale)
                );

                logo.Location = new Point(
                    110 + (200 - logo.Width) / 2,
                    40 + (140 - logo.Height) / 2
                );

                await Task.Delay(20);
            }
        }

        private async void AnimateLoadingText()
        {
            string baseText = "Loading";

            while (this.Visible)
            {
                dotCount = (dotCount + 1) % 4;
                loadingText.Text = baseText + new string('.', dotCount);

                await Task.Delay(350);
            }
        }

        private async void SimulateProgress()
        {
            for (int i = 0; i <= 100; i++)
            {
                progressBar.Value = i;
                await Task.Delay(25);
            }
        }
    }
}

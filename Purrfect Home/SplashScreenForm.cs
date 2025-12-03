using Lagen;
using System;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;


namespace Purrfect_Home
{
    public partial class SplashScreenForm : Form
    {
        Timer fadeInTimer = new Timer();
        Timer fadeOutTimer = new Timer();
        Timer holdTimer = new Timer();

        public SplashScreenForm()
        {
            InitializeComponent();
            picSplash.SizeMode = PictureBoxSizeMode.StretchImage;
            // ---- Form Settings ----
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Opacity = 0; // start invisible
            this.TopMost = true;

            // OPTIONAL: if you have a splash image in resources:
            // this.BackgroundImage = Properties.Resources.splash;
            // this.BackgroundImageLayout = ImageLayout.Stretch;

            // ---- Timers ----
            fadeInTimer.Interval = 30;
            fadeOutTimer.Interval = 30;
            holdTimer.Interval = 5500; // wait 5.5 seconds before fading out

            fadeInTimer.Tick += FadeIn;
            fadeOutTimer.Tick += FadeOut;
            holdTimer.Tick += HoldDone;
        }

        private void SplashScreenForm_Load(object sender, EventArgs e)
        {
            fadeInTimer.Start();
        }

        private void FadeIn(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.05;
            }
            else
            {
                fadeInTimer.Stop();
                holdTimer.Start();
            }
        }

        private void HoldDone(object sender, EventArgs e)
        {
            holdTimer.Stop();
            fadeOutTimer.Start();
        }

        private void FadeOut(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.05;
            }
            else
            {
                fadeOutTimer.Stop();
                OpenMainMenu();
            }
        }

        private void OpenMainMenu()
        {
            this.Hide();
            Form home = new login();
            home.StartPosition = FormStartPosition.CenterScreen;
            home.Show();
        }

        private void picSplash_Click(object sender, EventArgs e)
        {

        }
    }
}

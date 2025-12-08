using System;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Purrfect_Home
{
    public partial class WinterAnimationForm : Form
    {
        private AdoptForm adoptForm;
        private Timer animationTimer;
        private GachaBanner selectedBanner;

        // ✅ updated constructor
        public WinterAnimationForm(AdoptForm adopt, GachaBanner banner)
        {
            InitializeComponent();
            adoptForm = adopt;
            selectedBanner = banner;

            animationTimer = new Timer();
            animationTimer.Interval = 7500;
            animationTimer.Tick += AnimationTimer_Tick;
            animationTimer.Start();
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            animationTimer.Stop();
            FinishAnimationAndShowResult();
        }

        private void FinishAnimationAndShowResult()
        {
            var result = GachaManager.Roll(selectedBanner);

            GachaReceivedForm received = new GachaReceivedForm(adoptForm, result);
            received.StartPosition = FormStartPosition.Manual;
            received.Location = this.Location;
            received.Show();

            this.Hide();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            animationTimer.Stop();
            FinishAnimationAndShowResult();
        }

        private void picGachaAnimation_Click(object sender, EventArgs e)
        {
        }
    }
}

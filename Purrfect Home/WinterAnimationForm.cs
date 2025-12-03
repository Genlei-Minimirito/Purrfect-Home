using System;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Purrfect_Home
{
    public partial class WinterAnimationForm : Form
    {
        private AdoptForm adoptForm;
        private Timer animationTimer;

        public WinterAnimationForm(AdoptForm adopt)
        {
            InitializeComponent();
            adoptForm = adopt;

            // CREATE and CONFIGURE the 7.5 sec timer
            animationTimer = new Timer();
            animationTimer.Interval = 7500; // 7.5 seconds
            animationTimer.Tick += AnimationTimer_Tick;
            animationTimer.Start(); // Start timer when form loads
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            animationTimer.Stop();     // Stop timer so event only fires once
            FinishAnimationAndShowResult();
        }

        // This runs after 7.5 seconds OR btnFinish_Click (optional)
        private void FinishAnimationAndShowResult()
        {
            var result = GachaManager.Roll();

            GachaReceivedForm received = new GachaReceivedForm(adoptForm, result);
            received.StartPosition = FormStartPosition.Manual;
            received.Location = this.Location;
            received.Show();

            this.Hide();
        }

        // Optional: A button to skip the animation early
        private void btnFinish_Click(object sender, EventArgs e)
        {
            animationTimer.Stop();
            FinishAnimationAndShowResult();
        }
    }
}

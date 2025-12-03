using System;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Purrfect_Home
{
    public partial class WinterAnimationForm : Form
    {
        private AdoptForm adoptForm;
        private Timer timer;

        public WinterAnimationForm(AdoptForm adopt)
        {
            InitializeComponent();
            adoptForm = adopt;

            timer = new Timer();
            timer.Interval = 7500;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();

            GachaResult result = GachaManager.Roll();

            GachaReceivedForm received = new GachaReceivedForm(adoptForm, result);
            received.StartPosition = FormStartPosition.Manual;
            received.Location = this.Location;

            received.Show();
            this.Close();
        }
    }

}

using System.Media;
using System;

namespace Purrfect_Home
{
    public partial class TitleScreenForm : Form
    {
        //SoundPlayer sound = new SoundPlayer(@"C:\Users\Lei\source\repos\Purrfect Home\Purrfect Home\Resources\SOUNDS\TITLEBGM.wav");
        public TitleScreenForm()
        {
            InitializeComponent();
           
            //sound.PlayLooping();
        }

        private void TitleScreenForm_Load(object sender, EventArgs e)
        {

        }
      
        private void picPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formSplash = new HomeForm();
            formSplash.StartPosition = FormStartPosition.Manual;
            formSplash.Location = this.Location;
            formSplash.ShowDialog();
        }

        private void picCred_Click(object sender, EventArgs e)
        {

        }

        private void picExt_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void picMode_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.NIGHT_MODE_TITLE_SCREEN;
            picMode.Hide();
            picModeLight.Show();
        }

        private void picModeLight_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.LIGHT_MODE_TITLE_SCREEN;
            picModeLight.Hide();
            picMode.Show();
        }

      
    }
}

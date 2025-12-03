using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Purrfect_Home
{
    public partial class AdoptForm : Form
    {
        public AdoptForm()
        {
            InitializeComponent();
            picWinterBanner.SizeMode = PictureBoxSizeMode.StretchImage;
            picRightWinter.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void picWinterBanner_Click(object sender, EventArgs e)
        {

        }

        private void picWinterAdopt_Click(object sender, EventArgs e)
        {
            WinterAnimationForm anim = new WinterAnimationForm(this);

            anim.StartPosition = FormStartPosition.Manual;
            anim.Location = this.Location;

            anim.Show();
            this.Hide();
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            Form formHome = new HomeForm();
            formHome.StartPosition = FormStartPosition.Manual;
            formHome.Location = this.Location;
            formHome.ShowDialog();

            this.Close();
        }
    }
}

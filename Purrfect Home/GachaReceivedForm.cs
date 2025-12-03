using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Purrfect_Home
{
    public partial class GachaReceivedForm : Form
    {
        private AdoptForm adoptForm;
        private GachaResult gacha;

        public GachaReceivedForm(AdoptForm adopt, GachaResult result)
        {
            InitializeComponent();
            adoptForm = adopt;
            gacha = result;

            DisplayGacha();
        }

        private void DisplayGacha()
        {
            picCat.Image = gacha.Image;
            picCat.SizeMode = PictureBoxSizeMode.StretchImage;

           /* lblName.Text = gacha.Name;
            lblStars.Text = new string('★', gacha.Stars);*/
        }

        private void picOkai_Click(object sender, EventArgs e)
        {
            adoptForm.StartPosition = FormStartPosition.Manual;
            adoptForm.Location = this.Location;

            adoptForm.Show();
            this.Close();
        }
    }


}

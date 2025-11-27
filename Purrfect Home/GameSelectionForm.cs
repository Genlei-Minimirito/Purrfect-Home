using catjack;
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
    public partial class GameSelectionForm : Form
    {
        public GameSelectionForm()
        {
            InitializeComponent();
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            Form formHome = new HomeForm();
            formHome.StartPosition = FormStartPosition.Manual;
            formHome.Location = this.Location;
            formHome.ShowDialog();
        }

        private void picNext_Click(object sender, EventArgs e)
        {
            picCatJack.Hide();
            picMemo.Hide();
            picInfixToPawsfix.Show();
            lblCatJack.Hide();
            lblMemo.Hide();
            lblInfixToPawsfix.Show();
            picNext.Hide();
            picNext2.Show();
            picBack.Show();

        }

        private void picNext2_Click(object sender, EventArgs e)
        {
            picInfixToPawsfix.Hide();
            picMemo.Show();
            lblInfixToPawsfix.Hide();
            lblMemo.Show();
            picNext2.Hide();
            picBack2.Show();


        }

        private void picBack_Click(object sender, EventArgs e)
        {
            picInfixToPawsfix.Hide();
            picMemo.Hide();
            picCatJack.Show();
            lblInfixToPawsfix.Hide();
            lblMemo.Hide();
            lblCatJack.Show();
            picBack.Hide();
            picNext.Show();

        }

        private void picBack2_Click(object sender, EventArgs e)
        {
            picCatJack.Hide();
            picMemo.Hide();
            lblCatJack.Hide();
            lblMemo.Hide();
            picInfixToPawsfix.Show();
            lblInfixToPawsfix.Show();
            picBack2.Hide();
            picBack.Show();
            picNext.Show();

        }

        private void picBack3_Click(object sender, EventArgs e)
        {

        }

        private void picNext3_Click(object sender, EventArgs e)
        {

        }

        private void GameSelectionForm_Load(object sender, EventArgs e)
        {

        }

        private void playCat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formCatJack = new CatjackDeck();
            formCatJack.StartPosition = FormStartPosition.Manual;
            formCatJack.Location = this.Location;
            formCatJack.ShowDialog();
        }
    }
}

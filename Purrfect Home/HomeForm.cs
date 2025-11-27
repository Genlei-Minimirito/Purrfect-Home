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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void picHome_Click(object sender, EventArgs e)
        {
          
        }

        private void picGames_Click(object sender, EventArgs e)
        {
            Form formGame = new GameSelectionForm();
            formGame.StartPosition = FormStartPosition.Manual;
            formGame.Location = this.Location;
            formGame.ShowDialog();
        }

        private void picInv_Click(object sender, EventArgs e)
        {
            Form formHome = new HomeForm();
            formHome.StartPosition = FormStartPosition.Manual;
            formHome.Location = this.Location;
            formHome.ShowDialog();
        }

        private void picAdopt_Click(object sender, EventArgs e)
        {
            Form formHome = new HomeForm();
            formHome.StartPosition = FormStartPosition.Manual;
            formHome.Location = this.Location;
            formHome.ShowDialog();
        }

        private void picSettings_Click(object sender, EventArgs e)
        {
            Form formHome = new HomeForm();
            formHome.StartPosition = FormStartPosition.Manual;
            formHome.Location = this.Location;
            formHome.ShowDialog();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

using Lagen;
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
        private string currentUserId;
        public HomeForm(string userId)
        {
            InitializeComponent();
            currentUserId = userId;
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void picHome_Click(object sender, EventArgs e)
        {
          
        }

        private void picGames_Click(object sender, EventArgs e)
        {
            Form formGame = new GameSelectionForm(currentUserId);
            formGame.StartPosition = FormStartPosition.Manual;
            formGame.Location = this.Location;
            formGame.ShowDialog();

            this.Close();
        }

        private void picInv_Click(object sender, EventArgs e)
        {
            Form formHome = new HomeForm(currentUserId);
            formHome.StartPosition = FormStartPosition.Manual;
            formHome.Location = this.Location;
            formHome.ShowDialog();

            this.Close();
        }

        private void picAdopt_Click(object sender, EventArgs e)
        {
            Form formAdopt = new AdoptForm(currentUserId);
            formAdopt.StartPosition = FormStartPosition.Manual;
            formAdopt.Location = this.Location;
            formAdopt.ShowDialog();

            this.Close();
        }

        private void picSettings_Click(object sender, EventArgs e)
        {
            Form formHome = new login();
            formHome.StartPosition = FormStartPosition.Manual;
            formHome.Location = this.Location;
            formHome.ShowDialog();

            this.Close();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

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
    public partial class MafiaBannerInfo : Form
    {
        public string currentUserId;
        public MafiaBannerInfo(string currentUserId)
        {
            InitializeComponent();
            this.currentUserId = currentUserId;
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            Form formAdopt = new AdoptForm(currentUserId);
            formAdopt.StartPosition = FormStartPosition.Manual;
            formAdopt.Location = this.Location;
            formAdopt.ShowDialog();
            this.Hide();
            this.Close();
        }
    }
}

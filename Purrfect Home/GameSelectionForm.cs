using catjack;
using InfixToPawstfixGame;
using Lagen;
using PurrMemory;
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
        string connectionString = "server=localhost;database=dbposagame;uid=root;pwd=;";
        public string currentUserId;
        public GameSelectionForm(string userId)
        {
            InitializeComponent();
            currentUserId = userId;
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            Form formHome = new landingPage(currentUserId);
            formHome.StartPosition = FormStartPosition.Manual;
            formHome.Location = this.Location;
            formHome.ShowDialog();

            this.Close();
        }

        private void picNext_Click(object sender, EventArgs e)
        {
            picCatJack.Hide();
            picCatchFood.Hide();
            picInfixToPawsfix.Show();
            lblCatJack.Hide();
            lblCatchFood.Hide();
            lblInfixToPawsfix.Show();
            picNext.Hide();
            picNext2.Show();
            picBack.Show();
            playCat.Hide();
            playCatchFood.Hide();
            playInfix.Show();

        }

        private void picNext2_Click(object sender, EventArgs e)
        {
            picInfixToPawsfix.Hide();
            picCatJack.Hide();
            picCatchFood.Show();
            lblCatJack.Hide();
            lblInfixToPawsfix.Hide();
            lblCatchFood.Show();
            picNext2.Hide();
            picBack2.Show();
            playCatchFood.Show();
            playInfix.Hide();
            playCat.Hide();



        }

        private void picBack_Click(object sender, EventArgs e)
        {
            picInfixToPawsfix.Hide();
            picCatchFood.Hide();
            picCatJack.Show();
            lblInfixToPawsfix.Hide();
            lblCatchFood.Hide();
            lblCatJack.Show();
            picBack.Hide();
            picNext.Show();
            playInfix.Hide();
            picNext2.Hide();
            playCat.Show();
            playCatchFood.Hide();

        }

        private void picBack2_Click(object sender, EventArgs e)
        {
            picCatJack.Hide();
            picCatchFood.Hide();
            lblCatJack.Hide();
            lblCatchFood.Hide();
            picInfixToPawsfix.Show();
            lblInfixToPawsfix.Show();
            picBack2.Hide();
            picBack.Show();
            picNext.Show();
            playCatchFood.Hide();
            playCat.Hide();
            playInfix.Show();


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
            Form formCatJack = new CatjackDeck(currentUserId);
            formCatJack.StartPosition = FormStartPosition.Manual;
            formCatJack.Location = this.Location;
            formCatJack.ShowDialog();
            this.Close();
        }

        private void playInfix_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formInfix = new InfixToPawstFixForm(currentUserId);
            formInfix.StartPosition = FormStartPosition.Manual;
            formInfix.Location = this.Location;
            formInfix.ShowDialog();
            this.Close();
        }

        private void picBoxCatchFood_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formCatchFood = new CatcbFoodForm(currentUserId);
            formCatchFood.StartPosition = FormStartPosition.Manual;
            formCatchFood.Location = this.Location;
            formCatchFood.ShowDialog();
            this.Close();
        }
    }
}

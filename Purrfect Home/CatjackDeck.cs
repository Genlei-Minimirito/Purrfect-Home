using Lagen;
using Purrfect_Home;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace catjack
{
    public partial class CatjackDeck : Form
    {
        private string currentUserId;
        int UserCardSum = 0;
        int ComputerCardSum = 0;

        public CatjackDeck(string userId)
        {
            InitializeComponent();
            currentUserId = userId;
        }

        public void UserCards_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picHit_Click(object sender, EventArgs e)
        {
            DrawCards draw = new DrawCards(UserCards);
            int cardNum = draw.DrawCard();

            UserCardSum += cardNum;

            Player_Score.Text = UserCardSum.ToString();

            if (UserCardSum >= 21)
            {
                picHit.Enabled = false;
                ComputerPlay();
                picStand.Enabled = false;
            }
        }

        private void picStand_Click(object sender, EventArgs e)
        {
            ComputerPlay();
            picStand.Enabled = false;
            picHit.Enabled = false;
        }

        // ------------------------------------------------------
        // ? ADD +1 CATNIP TO DATABASE WHEN PLAYER WINS ?
        // ------------------------------------------------------
        private void AddCatnip(string username)
        {
            string connectionString = "server=localhost;database=dbposagame;uid=root;pwd=;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "UPDATE tbaccountdetails SET coins = coins + 1 WHERE username=@u";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@u", username);

                cmd.ExecuteNonQuery();
            }
        }

        public void ComputerPlay()
        {
            while (ComputerCardSum < UserCardSum + 1)
            {
                DrawCards draw = new DrawCards(Computer_Panel);
                int cardNum = draw.DrawCard();
                ComputerCardSum += cardNum;

                if (ComputerCardSum >= 21)
                {
                    break;
                }
            }

            Computer_Score.Text = ComputerCardSum.ToString();

            lblWin.Visible = false;
            lblLose.Visible = false;
            lblTie.Visible = false;

            // ------------------------------------------------------
            // ? WIN / LOSE / TIE LOGIC (UNCHANGED)
            // ? COIN ADDED ONLY ON WIN
            // ------------------------------------------------------
            if (UserCardSum > 21)
            {
                lblLose.Visible = true;
            }
            else if (ComputerCardSum > 21)
            {
                lblWin.Visible = true;
                AddCatnip(currentUserId);   // GIVE COIN
            }
            else if (ComputerCardSum < UserCardSum)
            {
                lblWin.Visible = true;
                AddCatnip(currentUserId);   // GIVE COIN
            }
            else if (ComputerCardSum > UserCardSum)
            {
                lblLose.Visible = true;
            }
            else
            {
                lblTie.Visible = true;
            }
        }

        private void CatjackDeck_Load(object sender, EventArgs e)
        {

        }

        private void lblWin_Click(object sender, EventArgs e)
        {

        }

        private void picMenu_Click(object sender, EventArgs e)
        {
            Form formHome = new GameSelectionForm(currentUserId);
            formHome.StartPosition = FormStartPosition.Manual;
            formHome.Location = this.Location;
            formHome.ShowDialog();
            this.Hide();
            this.Close();
        }
    }
}

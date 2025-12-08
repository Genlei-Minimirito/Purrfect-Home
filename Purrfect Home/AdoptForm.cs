using Lagen;
using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Windows.Forms;

namespace Purrfect_Home
{
    public partial class AdoptForm : Form
    {
        private string connectionString = "server=localhost;database=dbposagame;uid=root;pwd=;";
        public string currentUserId;
        private GachaBanner currentBanner = GachaBanner.Winter; // default

        public AdoptForm(string userID)
        {
            InitializeComponent();
            currentUserId = userID;

            // hide mafia by default
            picMafia.Visible = false;
            picMafiaAdopt.Visible = false;
        }

        // -----------------------------------------
        // BANNER SELECT
        // -----------------------------------------
        private void picWinterBannerSelect_Click(object sender, EventArgs e)
        {
            currentBanner = GachaBanner.Winter;

            picMafia.Visible = false;
            picMafiaAdopt.Visible = false;
            this.BackgroundImage = Properties.Resources.WINTER_BANNER_ANIMATION;
            picWinterBanner.Visible = true;
            picWinterAdopt.Visible = true;
            picWinterBannerSelect.Visible = false;
            picMafiaBannerSelect.Visible = true;
        }

        private void picMafiaBannerSelect_Click(object sender, EventArgs e)
        {
            currentBanner = GachaBanner.Mafia;

            picWinterBanner.Visible = false;
            picWinterAdopt.Visible = false;
            this.BackgroundImage = Properties.Resources.MAFIA_BANNER_ANIMATION;
            picMafia.Visible = true;
            picMafiaAdopt.Visible = true;
            picWinterBannerSelect.Visible = true;
            picMafiaBannerSelect.Visible = false;
        }

        // -----------------------------------------
        // ADOPT BUTTON (WINTER + MAFIA)
        // -----------------------------------------
        private void picWinterAdopt_Click(object sender, EventArgs e)
        {
            TryAdopt();
        }



        private void TryAdopt()
        {
            if (UserHasFiveCats())
            {
                MessageBox.Show("You already have 5 cats.\nRelease one first!");
                return;
            }

            if (!UserHasEnoughCatnip())
            {
                MessageBox.Show("You need at least 5 Catnip to adopt!");
                return;
            }

            DeductCatnip(5);

            // start animation
            WinterAnimationForm anim = new WinterAnimationForm(this, currentBanner);
            anim.StartPosition = FormStartPosition.Manual;
            anim.Location = this.Location;
            anim.Show();
            this.Hide();
        }

        // -----------------------------------------
        // SAVE GACHA RESULT
        // -----------------------------------------
        public void SaveGachaResultToInventory(GachaResult result)
        {
            if (result == null) return;

            if (!File.Exists(result.FilePath))
            {
                MessageBox.Show("GIF not found:\n" + result.FilePath);
                return;
            }

            // check duplicate
            bool exists = false;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string q = "SELECT COUNT(*) FROM tbaccdetails WHERE username=@u AND catName=@n";
                using (MySqlCommand cmd = new MySqlCommand(q, conn))
                {
                    cmd.Parameters.AddWithValue("@u", currentUserId);
                    cmd.Parameters.AddWithValue("@n", result.Name);
                    exists = Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }

            if (exists)
            {
                int coins = result.Stars;
                AddCatnip(coins);
                MessageBox.Show($"Duplicate! +{coins} Catnip.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string insert = @"INSERT INTO tbaccdetails
                        (username, gifPic, rarity, catName, nickname, equip)
                        VALUES (@u, @gif, @r, @n, '', 'no')";

                using (MySqlCommand cmd = new MySqlCommand(insert, conn))
                {
                    cmd.Parameters.AddWithValue("@u", currentUserId);
                    cmd.Parameters.AddWithValue("@gif", result.FilePath);
                    cmd.Parameters.AddWithValue("@r", result.Stars);
                    cmd.Parameters.AddWithValue("@n", result.Name);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // -----------------------------------------
        // DB HELPERS
        // -----------------------------------------
        private bool UserHasFiveCats()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string q = "SELECT COUNT(*) FROM tbaccdetails WHERE username=@u";
                using (MySqlCommand cmd = new MySqlCommand(q, conn))
                {
                    cmd.Parameters.AddWithValue("@u", currentUserId);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count >= 5;
                }
            }
        }

        private bool UserHasEnoughCatnip()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string q = "SELECT coins FROM tbaccountdetails WHERE username=@u";
                using (MySqlCommand cmd = new MySqlCommand(q, conn))
                {
                    cmd.Parameters.AddWithValue("@u", currentUserId);
                    int coins = Convert.ToInt32(cmd.ExecuteScalar());
                    return coins >= 5;
                }
            }
        }

        private void DeductCatnip(int amount)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string q = "UPDATE tbaccountdetails SET coins = coins - @c WHERE username=@u";
                using (MySqlCommand cmd = new MySqlCommand(q, conn))
                {
                    cmd.Parameters.AddWithValue("@c", amount);
                    cmd.Parameters.AddWithValue("@u", currentUserId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void AddCatnip(int amount)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string q = "UPDATE tbaccountdetails SET coins = coins + @c WHERE username=@u";
                using (MySqlCommand cmd = new MySqlCommand(q, conn))
                {
                    cmd.Parameters.AddWithValue("@c", amount);
                    cmd.Parameters.AddWithValue("@u", currentUserId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // -----------------------------------------
        // BACK HOME
        // -----------------------------------------
        private void picHome_Click(object sender, EventArgs e)
        {
            var home = new landingPage(currentUserId);
            home.StartPosition = FormStartPosition.Manual;
            home.Location = this.Location;
            home.Show();
            this.Close();
        }

        private void picMafiaAdopt_Click(object sender, EventArgs e)
        {
            TryAdopt();
        }

      
    }
}

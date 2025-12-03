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
        public string CurrentUsername { get { return currentUserId; } }

        public AdoptForm(string userID)
        {
            InitializeComponent();
            currentUserId = userID;
        }

        /// <summary>
        /// Save a gacha result into inventory. If duplicate (same username + catName) give coins instead.
        /// </summary>
        public void SaveGachaResultToInventory(GachaResult result)
        {
            if (result == null) return;

            // Validate GIF exists
            if (!File.Exists(result.FilePath))
            {
                MessageBox.Show("GIF file missing: " + result.FilePath);
                return;
            }

            bool isDuplicate = false;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string checkSql = "SELECT COUNT(*) FROM tbaccdetails WHERE username=@u AND catName=@name";
                using (MySqlCommand cmd = new MySqlCommand(checkSql, conn))
                {
                    cmd.Parameters.AddWithValue("@u", currentUserId);
                    cmd.Parameters.AddWithValue("@name", result.Name);
                    isDuplicate = Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }

            if (isDuplicate)
            {
                int reward = result.Stars * 1;
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string update = "UPDATE tbaccountdetails SET coins = coins + @c WHERE username=@u";
                    using (MySqlCommand cmd = new MySqlCommand(update, conn))
                    {
                        cmd.Parameters.AddWithValue("@c", reward);
                        cmd.Parameters.AddWithValue("@u", currentUserId);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show($"Duplicate cat! +{reward} coins added.");
                return;
            }

            // Insert new cat (store path)
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string insert = @"INSERT INTO tbaccdetails (username, gifPic, rarity, catName, nickname, equip)
                                  VALUES (@u, @gif, @r, @name, '', 'no')";
                using (MySqlCommand cmd = new MySqlCommand(insert, conn))
                {
                    cmd.Parameters.AddWithValue("@u", currentUserId);
                    cmd.Parameters.AddWithValue("@gif", result.FilePath);
                    cmd.Parameters.AddWithValue("@r", result.Stars);
                    cmd.Parameters.AddWithValue("@name", result.Name);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("New cat added to inventory!");
        }

        private void picWinterAdopt_Click(object sender, EventArgs e)
        {
            if (UserHasFiveCats(currentUserId))
            {
                MessageBox.Show(
                    "You already have 5 cats.\nPlease release a cat first before adopting a new one.",
                    "Adoption Limit Reached",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;  // Stop here — do not pull
            }
            WinterAnimationForm anim = new WinterAnimationForm(this);

            anim.StartPosition = FormStartPosition.Manual;
            anim.Location = this.Location;

            anim.Show();
            this.Hide();
        }


        private void picHome_Click(object sender, EventArgs e)
        {
            Form formHome = new landingPage(currentUserId);
            formHome.StartPosition = FormStartPosition.Manual;
            formHome.Location = this.Location;
            formHome.ShowDialog();

            this.Close();
        }

        public bool UserHasFiveCats(string username)
        {
            string connectionString = "server=localhost;database=dbposagame;uid=root;pwd=;";
            int count = 0;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM tbaccdetails WHERE username = @u";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@u", username);

                count = Convert.ToInt32(cmd.ExecuteScalar());
            }

            return count >= 5;
        }

    }
}

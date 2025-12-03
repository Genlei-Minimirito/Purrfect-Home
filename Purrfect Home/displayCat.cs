using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Lagen
{
    public partial class displayCat : Form
    {
        string username;
        string path;                 // Unique image path (primary key substitute)
        string rarityValue;
        string originalNickname;

        string connectionString = "server=localhost;database=dbposagame;uid=root;pwd=;";

        public displayCat(string u, string p, int index)
        {
            InitializeComponent();

            username = u;
            path = p;

            this.DoubleBuffered = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer, true);
            UpdateStyles();

            LoadImage();
            LoadDetails();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // WS_EX_COMPOSITED = Removes flicker
                return cp;
            }
        }

        // -----------------------------
        // LOAD CAT IMAGE
        // -----------------------------
        private void LoadImage()
        {
            if (File.Exists(path))
            {
                pictureBox1.Image = Image.FromFile(path);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        // -----------------------------
        // LOAD CAT DETAILS (rarity, name, nickname)
        // -----------------------------
        private void LoadDetails()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT rarity, catName, nickname FROM tbaccdetails WHERE username=@u AND gifPic=@p LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", path);

                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        rarityValue = dr.GetString("rarity");
                        catName.Text = dr.GetString("catName");
                        nickname.Text = dr.GetString("nickname");
                        originalNickname = nickname.Text;

                        int r = 3;
                        int.TryParse(rarityValue, out r);

                        // Show stars as text if you have lblStars
                        if (this.Controls.Find("lblStars", true).FirstOrDefault() is Label lbl)
                        {
                            lbl.Text = new string('★', r);
                            if (r == 3) lbl.ForeColor = Color.Gray;
                            else if (r == 4) lbl.ForeColor = Color.DodgerBlue;
                            else if (r == 5) lbl.ForeColor = Color.Gold;
                        }

                        // Keep 5-star animated star gif if desired
                        if (r == 5 && File.Exists(@"C:\xampp\htdocs\assets\5star.gif"))
                        {
                            starPic.ImageLocation = @"C:\xampp\htdocs\assets\5star.gif";
                            starPic.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                        else
                        {
                            starPic.Image = null;
                        }
                    }
                }
            }
        }


        // -----------------------------
        // CLOSE BUTTON
        // -----------------------------
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // -----------------------------
        // SELL CAT (DELETE ONLY SELECTED)
        // -----------------------------
        private void btnSell_Click(object sender, EventArgs e)
        {
            int rarityInt = int.Parse(rarityValue);
            int sellPrice = rarityInt;

            int newCoins = 0;

            // Get current coins
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string getCoins = "SELECT coins FROM tbaccountdetails WHERE username=@u";
                MySqlCommand cmd = new MySqlCommand(getCoins, conn);
                cmd.Parameters.AddWithValue("@u", username);

                int coinsDB = Convert.ToInt32(cmd.ExecuteScalar());
                newCoins = coinsDB + sellPrice;
            }

            // Update coins
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string upd = "UPDATE tbaccountdetails SET coins=@c WHERE username=@u";
                MySqlCommand cmd = new MySqlCommand(upd, conn);
                cmd.Parameters.AddWithValue("@c", newCoins);
                cmd.Parameters.AddWithValue("@u", username);

                cmd.ExecuteNonQuery();
            }

            // Delete the selected cat using unique gifPic path
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string del = "DELETE FROM tbaccdetails WHERE username=@u AND gifPic=@p LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(del, conn);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", path);

                cmd.ExecuteNonQuery();
            }

            // Refresh inventory form if open
            foreach (Form f in Application.OpenForms)
                if (f is inventory inv)
                    inv.RefreshInventory();

            this.Close();
        }

        // -----------------------------
        // EQUIP CAT (ONLY THE SELECTED CAT)
        // -----------------------------
        private void btnEquip_Click(object sender, EventArgs e)
        {
            EquipSelectedCat();
        }

        private void EquipSelectedCat()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Remove equip from any other cat
                string clear = "UPDATE tbaccdetails SET equip='no' WHERE username=@u AND equip='E'";
                using (MySqlCommand cmd = new MySqlCommand(clear, conn))
                {
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.ExecuteNonQuery();
                }

                // Equip this specific cat using gifPic path
                string equip = "UPDATE tbaccdetails SET equip='E' WHERE username=@u AND gifPic=@p LIMIT 1";
                using (MySqlCommand cmd = new MySqlCommand(equip, conn))
                {
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@p", path);

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                        MessageBox.Show("Cat successfully equipped!", "Success");
                    else
                        MessageBox.Show("Error: Could not equip this cat.");
                }
            }
        }

        // -----------------------------
        // EDIT NICKNAME BUTTON
        // -----------------------------
        private void btnEditNickname_Click(object sender, EventArgs e)
        {
            nickname.Enabled = true;
            nickname.ReadOnly = false;

            btnEditNickname.Visible = false;
            editApply.Visible = true;
        }

        // -----------------------------
        // APPLY NICKNAME CHANGE
        // -----------------------------
        private void editApply_Click(object sender, EventArgs e)
        {
            nickname.Enabled = false;
            nickname.ReadOnly = true;

            btnEditNickname.Visible = true;
            editApply.Visible = false;

            UpdateNickname();
        }

        private void UpdateNickname()
        {
            string newNickname = nickname.Text.Trim();

            if (newNickname == originalNickname)
            {
                MessageBox.Show("No changes made.");
                return;
            }

            if (string.IsNullOrWhiteSpace(newNickname))
            {
                MessageBox.Show("Nickname cannot be empty.");
                nickname.Text = originalNickname;
                return;
            }

            // Check duplicate nickname for same user
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string check = @"SELECT COUNT(*) FROM tbaccdetails 
                                 WHERE username=@u AND nickname=@n AND gifPic<>@p";

                MySqlCommand cmd = new MySqlCommand(check, conn);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@n", newNickname);
                cmd.Parameters.AddWithValue("@p", path);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("You already have a cat with this nickname.");
                    nickname.Text = originalNickname;
                    return;
                }
            }

            // Update nickname
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string upd = @"UPDATE tbaccdetails SET nickname=@n 
                               WHERE username=@u AND gifPic=@p";

                MySqlCommand cmd = new MySqlCommand(upd, conn);
                cmd.Parameters.AddWithValue("@n", newNickname);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", path);

                cmd.ExecuteNonQuery();
            }

            originalNickname = newNickname;
            MessageBox.Show("Nickname updated!", "Success");
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lagen
{
    public partial class avatar : Form
    {
        public event Action OnAvatarUpdated;
        public string currentUserId;
        string selectedImagePath = "";
        string originalAvatarPath = "";
        string bio = "";
        string connectionString = "server=localhost;database=dbposagame;uid=root;pwd=;";
        public avatar(string username)
        {
            InitializeComponent();
            currentUserId = username;
            LoadAvatar();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadAvatar()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT username, user_id, coins, bio, avatar FROM tbaccountdetails WHERE username = @user";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", currentUserId);

                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        string usern = dr.GetString("username");
                        int userId = dr.GetInt32("user_id");
                        int coins = dr.GetInt32("coins");
                        string imgPath = dr.GetString("avatar");
                        string bio = dr.GetString("bio");

                        originalAvatarPath = imgPath;   

                        if (File.Exists(imgPath))
                        {
                            btnAvatar.Image = Image.FromFile(imgPath);
                        }
                        else
                        {
                            MessageBox.Show("Image file not found: " + imgPath);
                        }

                        txtuser.Text = usern;
                        txtid.Text = userId.ToString();
                        txtcoins.Text = coins.ToString();
                        txtBio.Text = bio;

                    }
                    else
                    {
                        MessageBox.Show("No user found.");
                    }

                }


            }
        }

        private void avatar_Load(object sender, EventArgs e)
        {

        }
        private void editAvatar_Click(object sender, EventArgs e)
        {
            btnAvatar.Enabled = true;
            txtBio.ReadOnly = false;
            txtBio.Enabled = true;
            btnApplychanges.Visible = true;
            editAvatar.Visible = false;

        }

        private void btnApplychanges_Click(object sender, EventArgs e)
        {

            btnApplychanges.Visible = false;
            editAvatar.Visible = true;
            btnAvatar.Enabled = false;
            txtBio.ReadOnly = true;
            txtBio.Enabled = false;

            string newBio = txtBio.Text.Trim();
            string newAvatarPath = originalAvatarPath; // default: unchanged

            bool bioChanged = newBio != bio;
            bool avatarChanged = !string.IsNullOrEmpty(selectedImagePath);


            if (!bioChanged && !avatarChanged)
            {
                btnAvatar.Enabled = false;
                return;
            }

            // --- If avatar changed ---
            if (avatarChanged)
            {
                string destinationFolder = @"C:\xampp\htdocs\Game_Avatars\";

                if (!Directory.Exists(destinationFolder))
                    Directory.CreateDirectory(destinationFolder);

                string fileName = Path.GetFileName(selectedImagePath);
                newAvatarPath = Path.Combine(destinationFolder, fileName);

                if (!string.IsNullOrEmpty(selectedImagePath) && File.Exists(selectedImagePath))
                {
                    File.Copy(selectedImagePath, newAvatarPath, true);
                }

            }

            // --- Update database ---
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query =
                    "UPDATE tbaccountdetails SET avatar=@p, bio=@bio WHERE username=@u";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@p", newAvatarPath);
                cmd.Parameters.AddWithValue("@bio", newBio);
                cmd.Parameters.AddWithValue("@u", currentUserId);

                cmd.ExecuteNonQuery();
            }

            OnAvatarUpdated?.Invoke();
            CleanUnusedAvatars();
            this.DialogResult = DialogResult.OK;
        }


        private void CleanUnusedAvatars()
        {
            string folderPath = @"C:\xampp\htdocs\Game_Avatars\";

            // 1. Load all avatar paths currently used in database
            List<string> usedAvatars = new List<string>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT avatar FROM tbaccountdetails WHERE avatar IS NOT NULL AND avatar != ''";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string path = dr["avatar"].ToString();
                    usedAvatars.Add(Path.GetFileName(path)); // store only filename
                }
            }

            // 2. Scan all files in the local avatar folder
            if (!Directory.Exists(folderPath))
                return;

            string[] allFiles = Directory.GetFiles(folderPath);

            foreach (string file in allFiles)
            {
                string fileName = Path.GetFileName(file);

                // If this file is NOT used by anyone → delete it
                if (!usedAvatars.Contains(fileName))
                {
                    try
                    {
                        File.Delete(file);
                    }
                    catch (Exception ex)
                    {
                        // Avoid crash if file is in use
                        Console.WriteLine("Unable to delete file: " + ex.Message);
                    }
                }
            }
        }


        private void btnAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = ofd.FileName;
                btnAvatar.Image = Image.FromFile(selectedImagePath);
            }
        }
    }
}

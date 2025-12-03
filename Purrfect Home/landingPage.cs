using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Purrfect_Home;

namespace Lagen
{
    public partial class landingPage : Form
    {
        string connectionString = "server=localhost;database=dbposagame;uid=root;pwd=;";
        private string currentUserId;
        List<PictureBox> catBoxes;
        public landingPage(string userId)
        {
            InitializeComponent();

            currentUserId = userId;

            this.DoubleBuffered = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer, true);
            UpdateStyles();

            // Add all 5 picture boxes here
            catBoxes = new List<PictureBox>()
        {
            cat1,
            cat2,
            cat3,
            cat4,
            cat5
        };

            LoadUserGifs();
            LoadUserData();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // WS_EX_COMPOSITED
                return cp;
            }
        }

        public void LoadUserData()
        {
            // Ensure table name and columns are correct
            string tableName = "tbaccountdetails"; // <-- check your actual table name
            string query = "SELECT username, user_id, coins, avatar FROM " + tableName + " WHERE username=@u";

            try
            {
                using (MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=;database=dbposagame;"))
                {
                    con.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@u", currentUserId);

                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                lblusername.Text = dr["username"].ToString();
                                lbluniqueid.Text = dr["user_id"].ToString();
                                lblcoins.Text = dr["coins"].ToString();

                                string imgPath = dr["avatar"].ToString();

                                if (!string.IsNullOrEmpty(imgPath) && File.Exists(imgPath))
                                {
                                    avatar.Image = Image.FromFile(imgPath);
                                }
                                else
                                {
                                    avatar.Image = null; // clear image if not found
                                    MessageBox.Show("Image not found or path is empty: " + imgPath);
                                }
                            }
                            else
                            {
                                MessageBox.Show("No data found for user: " + currentUserId);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user data: " + ex.Message);
            }
        }

        private void LoadUserGifs()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT gifPic FROM tbaccdetails WHERE username = @id AND equip = 'E' LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", currentUserId);

                object result = cmd.ExecuteScalar();

                foreach (PictureBox pb in catBoxes)
                {
                    pb.Image = null;
                }

                if (result == null)
                    return;

                string gifPath = result.ToString();

                if (!File.Exists(gifPath))
                    return;

                Random rand = new Random();
                int randomIndex = rand.Next(catBoxes.Count);
                catBoxes[randomIndex].Image = Image.FromFile(gifPath);
            }
        }


        private void landingPage_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string userPrimaryKey = currentUserId;
            inventory inven = new inventory(userPrimaryKey);
            inven.Show();
            this.Hide();
        }

        private void avatar_Click(object sender, EventArgs e)
        {
            string userPrimaryKey = currentUserId;
            avatar ava = new avatar(userPrimaryKey);

            // 🔥 When avatar updates, refresh landingPage immediately
            ava.OnAvatarUpdated += () =>
            {
                LoadUserData();   // refresh avatar image
                LoadUserGifs();   // refresh equipped gif
            };

            ava.Show();   // 🔥 Not ShowDialog() (so both forms stay open)
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Do you want to exit the application?",
                "Confirm Exit",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.Cancel)
            {
                // Go back to login form
                this.Close();
                login lag = new login();
                lag.Show();
            }
        }

        private void picGames_Click(object sender, EventArgs e)
        {
            Form formGame = new GameSelectionForm(currentUserId);
            formGame.StartPosition = FormStartPosition.Manual;
            formGame.Location = this.Location;
            formGame.ShowDialog();

            this.Close();
        }



        private void picSettings_Click(object sender, EventArgs e)
        {

        }

        private void picAdopt_Click_1(object sender, EventArgs e)
        {
            Form formAdopt = new AdoptForm(currentUserId);
            formAdopt.StartPosition = FormStartPosition.Manual;
            formAdopt.Location = this.Location;
            formAdopt.ShowDialog();

            this.Close();
        }

        private void picHome_Click(object sender, EventArgs e)
        {

        }
    }
}

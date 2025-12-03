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

namespace Lagen
{
    public partial class inventory : Form
    {
        string connectionString = "server=localhost;database=dbposagame;uid=root;pwd=;";
        public string currentUserId;
        private List<string> imagePaths = new List<string>();



        public inventory(string user)
        {
            InitializeComponent();
            currentUserId = user;
            LoadUserImages(user);

            this.DoubleBuffered = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer, true);
            UpdateStyles();


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

        public void RefreshInventory()
        {
            LoadUserImages(currentUserId);
        }
        public void LoadUserImages(string username)
        {
            List<PictureBox> pictureBoxes = new List<PictureBox>()
    {
        invent1,
        invent2,
        invent3,
        invent4,
        invent5
    };

            foreach (var pb in pictureBoxes)
            {
                pb.Image = null;
                pb.Click -= invent1_Click;
                pb.Click += invent1_Click;
                pb.Tag = null;
                pb.BorderStyle = BorderStyle.None;
            }

            imagePaths.Clear();
            var rarityList = new List<int>();
            int index = 0;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT gifPic, rarity, catName FROM tbaccdetails WHERE username=@u LIMIT 5";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@u", username);
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read() && index < 5)
                    {
                        string path = dr.GetString("gifPic");
                        int rarity = 3;
                        if (!dr.IsDBNull(dr.GetOrdinal("rarity")))
                            int.TryParse(dr.GetString("rarity"), out rarity);
                        string catName = dr.IsDBNull(dr.GetOrdinal("catName")) ? "" : dr.GetString("catName");

                        imagePaths.Add(path);
                        rarityList.Add(rarity);

                        // Display GIF by path (animated)
                        if (File.Exists(path))
                        {
                            // Use ImageLocation to let PictureBox animate
                            pictureBoxes[index].ImageLocation = path;
                            pictureBoxes[index].SizeMode = PictureBoxSizeMode.StretchImage;
                        }

                        // Set border color based on rarity
                        if (rarity == 3) pictureBoxes[index].BackColor = Color.Transparent;
                        else if (rarity == 4) pictureBoxes[index].BackColor = Color.Transparent;
                        else if (rarity == 5) pictureBoxes[index].BackColor = Color.Transparent;

                        // store metadata in Tag (helps click handlers)
                        pictureBoxes[index].Tag = new { Path = path, Rarity = rarity, Name = catName };

                        // set tooltip (optional)
                        ToolTip tt = new ToolTip();
                        tt.SetToolTip(pictureBoxes[index], $"{catName} ({new string('★', rarity)})");

                        index++;
                    }
                }
            }
        }


        private void invent1_Click(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;

            if (pb.Image == null)
            {
                MessageBox.Show("No image here.");
                return;
            }

            int index = -1;
            if (pb == invent1) index = 0;
            else if (pb == invent2) index = 1;
            else if (pb == invent3) index = 2;
            else if (pb == invent4) index = 3;
            else if (pb == invent5) index = 4;

            if (index >= 0)
            {
                string selectedPath = imagePaths[index];
                displayCat dc = new displayCat(currentUserId, selectedPath, index);
                dc.ShowDialog();
            }

        }

        private void picBack_Click(object sender, EventArgs e)
        {
            landingPage main = new landingPage(currentUserId);
            main.Show();
            this.Close();
        }

        private void invent4_Click(object sender, EventArgs e)
        {

        }
    }
}

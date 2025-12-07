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
    public partial class signUp : Form
    {
        string connectionString = "server=localhost;user=root;password=;database=dbposagame;";
        string username;
        string password;
        string confirmPassword;
        public signUp()
        {
            InitializeComponent();
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

        private string GenerateAndInsertCode()
        {
            Random r = new Random();
            string code = "";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                while (true)
                {
                    // 1. Generate 6-digit number
                    code = r.Next(100000, 999999).ToString();

                    // 2. Check if code already exists
                    MySqlCommand check = new MySqlCommand(
                        "SELECT COUNT(*) FROM tbaccountdetails WHERE user_id =@c", conn);
                    check.Parameters.AddWithValue("@c", code);

                    long count = (long)check.ExecuteScalar();

                    if (count == 0)  // If unique → stop loop
                        break;
                }

                // 3. INSERT into database
                string defAvatar = "C:\\ACADS\\BSCS 2B\\DEFAULT PROFILE.jpg";
                int coins = 0;

                MySqlCommand insert = new MySqlCommand(
                    "INSERT INTO tbaccountdetails (username, user_id, coins, avatar) VALUES (@username, @id,  @coins,  @avatar)", conn);

                insert.Parameters.AddWithValue("@id", code);
                insert.Parameters.AddWithValue("@avatar", defAvatar);
                insert.Parameters.AddWithValue("@username", username);
                insert.Parameters.AddWithValue("@coins", coins);

                insert.ExecuteNonQuery();
            }

            return code; // return the new unique code
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            username = txtusername.Text.Trim();
            password = txtpassword.Text.Trim();
            confirmPassword = txtconfirm.Text.Trim();

            if (username == "" || password == "" || confirmPassword == "")
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // --- CHECK IF USERNAME ALREADY EXISTS ---
                    string checkQuery = "SELECT COUNT(*) FROM tbaccount WHERE username = @username";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@username", username);

                    int userExists = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (userExists > 0)
                    {
                        MessageBox.Show("Username already exists! Choose another one.");
                        return;
                    }

                    string query = "INSERT INTO tbaccount (username, password) VALUES (@username, @password)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password); 

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Account created successfully!");
                        login lg = new login();
                        this.Hide();
                        lg.Show();
                    }
                    else
                    {
                        MessageBox.Show("Failed to create account.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            GenerateAndInsertCode();
        }

        private void BtnloginHere_Click(object sender, EventArgs e)
        {
            login lg = new login();
            this.Close();
            lg.Show();
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

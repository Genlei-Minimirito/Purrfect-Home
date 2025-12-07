using Purrfect_Home;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Purrfect_Home
{
    public partial class CatcbFoodForm : Form
    {
        private string currentUserId;
        private List<Catfood> fruitList = new List<Catfood>();
        private Random random = new Random();
        private int score = 0;

        private int BasketSpeed = 60;

        private int maxFruits = 8;
        private int baseFallSpeed = 2;
        private int speedLevel = 0;

        private bool isPaused = false;

        // ❤️ LIVES
        private int lives = 3;

        // 🧺 Basket image handling
        private Image normalBasket;

        // ✅ DB
        private string connectionString = "server=localhost;database=dbposagame;uid=root;pwd=;";

        // ✅ Reward tracking
        private int lastRewardCheckpoint = 0;
        private int catnipEarned = 0;

        public CatcbFoodForm(string currentUserId)
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.KeyPreview = true;

            PicBoxBasket.Hide();

            normalBasket = PicBoxBasket.Image;

            lblGameOver.Hide();
            lblRetry.Hide();
            lblGameSelection.Hide();
            lblPause.Hide();
            lblContinue.Hide();
            lblCatnip.Hide();   // ✅ hide reward label at start

            this.currentUserId = currentUserId;
        }

        private void CatchFoodForm_Load(object sender, EventArgs e) { }

        // ✅ START GAME
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        // ✅ KEYBOARD MOVE
        private void CatcbFoodForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (isPaused) return;

            if (e.KeyCode == Keys.Left) BoxMove(-BasketSpeed);
            if (e.KeyCode == Keys.Right) BoxMove(BasketSpeed);
        }

        // ✅ MOVE BASKET
        private void BoxMove(int move)
        {
            int newX = PicBoxBasket.Left + move;

            if (newX < 0) newX = 0;
            if (newX + PicBoxBasket.Width > this.ClientSize.Width)
                newX = this.ClientSize.Width - PicBoxBasket.Width;

            PicBoxBasket.Left = newX;
            PicBoxBasket.Top = this.ClientSize.Height - PicBoxBasket.Height - 10;
        }

        // ✅ SPAWN FOOD
        private void SpawnTimer_Tick(object sender, EventArgs e)
        {
            if (isPaused) return;
            if (fruitList.Count >= maxFruits) return;

            int roll = random.Next(100);
            Catfood fruit;

            if (roll < 75) fruit = new Salmon(this);
            else if (roll < 93) fruit = new Dryfood(this);
            else fruit = new Wetfood(this);

            fruit.Spawn(random);
            fruit.FallSpeed = baseFallSpeed + speedLevel;
            fruitList.Add(fruit);
        }

        // ✅ FALL + COLLISIONS
        private void FallTimer_Tick(object sender, EventArgs e)
        {
            if (isPaused) return;

            speedLevel = score / 30;

            for (int i = fruitList.Count - 1; i >= 0; i--)
            {
                Catfood fruit = fruitList[i];
                fruit.Fall();

                if (fruit.FruitPicture.Bottom >= this.ClientSize.Height)
                {
                    this.Controls.Remove(fruit.FruitPicture);
                    fruitList.Remove(fruit);

                    lives--;
                    UpdateLives();

                    if (lives <= 0)
                    {
                        GameOver();
                    }
                    continue;
                }

                if (fruit.CheckCollision(PicBoxBasket))
                {
                    score += fruit.GetPoints();

                    this.Controls.Remove(fruit.FruitPicture);
                    fruitList.Remove(fruit);

                    LbPoints.Text = score.ToString();

                    HandleReward();
                    continue;
                }

                if (fruit.FruitPicture.Top > this.ClientSize.Height)
                {
                    this.Controls.Remove(fruit.FruitPicture);
                    fruitList.Remove(fruit);
                }
            }
        }

        // ✅ TRACK REWARDS SILENTLY
        private void HandleReward()
        {
            if (score / 50 > lastRewardCheckpoint)
            {
                int newCoins = (score / 50) - lastRewardCheckpoint;
                lastRewardCheckpoint += newCoins;
                catnipEarned += newCoins;

                AddCoinsToDatabase(newCoins);
            }
        }

        // ✅ SAVE TO DATABASE
        private void AddCoinsToDatabase(int coins)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "UPDATE tbaccountdetails SET coins = coins + @coins WHERE username = @user";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@coins", coins);
                        cmd.Parameters.AddWithValue("@user", currentUserId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch { }
        }

        // ✅ GAME OVER
        private void GameOver()
        {
            SpawnTimer.Stop();
            FallTimer.Stop();

            PicBoxBasket.Image = Properties.Resources.BANANA_CAT_CRYING;

            lblGameOver.Show();
            lblRetry.Show();
            lblGameSelection.Show();

            // ✅ SHOW CATNIP REWARD
            lblCatnip.Text = $"+{catnipEarned} Catnip Earned!";
            lblCatnip.Show();

            PicBoxBasket.Show();
        }

        // ✅ RETRY
        private void lblRetry_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        // ✅ EXIT
        private void lblGameSelection_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formCatchFood = new GameSelectionForm(currentUserId);
            formCatchFood.StartPosition = FormStartPosition.Manual;
            formCatchFood.Location = this.Location;
            formCatchFood.ShowDialog();
            this.Close();
        }

        // ✅ RESET GAME
        private void StartGame()
        {
            score = 0;
            lives = 3;
            speedLevel = 0;
            lastRewardCheckpoint = 0;
            catnipEarned = 0;

            LbPoints.Text = "0";

            foreach (var f in fruitList)
                this.Controls.Remove(f.FruitPicture);

            fruitList.Clear();

            PicBoxBasket.Image = normalBasket;

            PicBoxBasket.Show();
            PicBoxStart.Hide();

            lblPause.Hide();
            lblContinue.Hide();
            lblGameOver.Hide();
            lblRetry.Hide();
            lblGameSelection.Hide();
            lblCatnip.Hide();

            UpdateLives();

            isPaused = false;
            SpawnTimer.Start();
            FallTimer.Start();
        }

        // ❤️ HEART UPDATE
        private void UpdateLives()
        {
            picHeart1.Visible = lives >= 1;
            picHeart2.Visible = lives >= 2;
            picHeart3.Visible = lives >= 3;
        }

        // ✅ PAUSE
        private void picMenu_Click(object sender, EventArgs e)
        {
            isPaused = true;

            SpawnTimer.Stop();
            FallTimer.Stop();

            lblPause.Show();
            lblContinue.Show();
            lblGameSelection.Show();
        }

        private void lblContinue_Click(object sender, EventArgs e)
        {
            isPaused = false;

            lblPause.Hide();
            lblContinue.Hide();
            lblGameSelection.Hide();

            SpawnTimer.Start();
            FallTimer.Start();
        }
    }
}

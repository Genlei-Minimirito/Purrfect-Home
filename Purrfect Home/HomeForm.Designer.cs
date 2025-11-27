namespace Purrfect_Home
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picHome = new PictureBox();
            picGames = new PictureBox();
            picInv = new PictureBox();
            picAdopt = new PictureBox();
            picSettings = new PictureBox();
            picExit = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            lblName = new Label();
            lblCoins = new Label();
            ((System.ComponentModel.ISupportInitialize)picHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picGames).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picInv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAdopt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSettings).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // picHome
            // 
            picHome.BackColor = Color.Transparent;
            picHome.Location = new Point(361, 671);
            picHome.Name = "picHome";
            picHome.Size = new Size(97, 79);
            picHome.TabIndex = 0;
            picHome.TabStop = false;
            picHome.Click += picHome_Click;
            // 
            // picGames
            // 
            picGames.BackColor = Color.Transparent;
            picGames.Location = new Point(464, 671);
            picGames.Name = "picGames";
            picGames.Size = new Size(89, 79);
            picGames.TabIndex = 1;
            picGames.TabStop = false;
            picGames.Click += picGames_Click;
            // 
            // picInv
            // 
            picInv.BackColor = Color.Transparent;
            picInv.Location = new Point(559, 671);
            picInv.Name = "picInv";
            picInv.Size = new Size(95, 79);
            picInv.TabIndex = 2;
            picInv.TabStop = false;
            picInv.Click += picInv_Click;
            // 
            // picAdopt
            // 
            picAdopt.BackColor = Color.Transparent;
            picAdopt.Location = new Point(660, 671);
            picAdopt.Name = "picAdopt";
            picAdopt.Size = new Size(90, 79);
            picAdopt.TabIndex = 3;
            picAdopt.TabStop = false;
            picAdopt.Click += picAdopt_Click;
            // 
            // picSettings
            // 
            picSettings.BackColor = Color.Transparent;
            picSettings.Location = new Point(756, 671);
            picSettings.Name = "picSettings";
            picSettings.Size = new Size(95, 79);
            picSettings.TabIndex = 4;
            picSettings.TabStop = false;
            picSettings.Click += picSettings_Click;
            // 
            // picExit
            // 
            picExit.BackColor = Color.Transparent;
            picExit.Location = new Point(857, 671);
            picExit.Name = "picExit";
            picExit.Size = new Size(88, 79);
            picExit.TabIndex = 5;
            picExit.TabStop = false;
            picExit.Click += picExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.BATCAT;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(621, 256);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 96);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.POSA_NA_TIGER;
            pictureBox2.Location = new Point(1051, 223);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(107, 96);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.POSANG_PASKO;
            pictureBox3.Location = new Point(512, 528);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(107, 96);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.POSA_MASAMA;
            pictureBox4.Location = new Point(283, 485);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(107, 96);
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // lblName
            // 
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("MS Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(106, 31);
            lblName.Name = "lblName";
            lblName.Size = new Size(185, 19);
            lblName.TabIndex = 10;
            lblName.Text = "Guest";
            // 
            // lblCoins
            // 
            lblCoins.BackColor = Color.Transparent;
            lblCoins.Font = new Font("MS Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCoins.Location = new Point(134, 70);
            lblCoins.Name = "lblCoins";
            lblCoins.Size = new Size(108, 17);
            lblCoins.TabIndex = 11;
            lblCoins.Text = "999999999999";
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.HOME_UI;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1359, 750);
            Controls.Add(lblCoins);
            Controls.Add(lblName);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(picExit);
            Controls.Add(picSettings);
            Controls.Add(picAdopt);
            Controls.Add(picInv);
            Controls.Add(picGames);
            Controls.Add(picHome);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomeForm";
            Text = "Home";
            Load += HomeForm_Load;
            ((System.ComponentModel.ISupportInitialize)picHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)picGames).EndInit();
            ((System.ComponentModel.ISupportInitialize)picInv).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAdopt).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSettings).EndInit();
            ((System.ComponentModel.ISupportInitialize)picExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picHome;
        private PictureBox picGames;
        private PictureBox picInv;
        private PictureBox picAdopt;
        private PictureBox picSettings;
        private PictureBox picExit;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label lblName;
        private Label lblCoins;
    }
}
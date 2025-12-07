namespace Purrfect_Home
{
    partial class CatcbFoodForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatcbFoodForm));
            PicBoxStart = new PictureBox();
            PicBoxBasket = new PictureBox();
            SpawnTimer = new System.Windows.Forms.Timer(components);
            FallTimer = new System.Windows.Forms.Timer(components);
            LbPoints = new Label();
            picMenu = new PictureBox();
            lblPause = new Label();
            lblContinue = new Label();
            lblGameSelection = new Label();
            LblLives = new Label();
            picHeart1 = new PictureBox();
            picHeart2 = new PictureBox();
            picHeart3 = new PictureBox();
            lblRetry = new Label();
            lblGameOver = new Label();
            lblCatnip = new Label();
            ((System.ComponentModel.ISupportInitialize)PicBoxStart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxBasket).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHeart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHeart2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHeart3).BeginInit();
            SuspendLayout();
            // 
            // PicBoxStart
            // 
            PicBoxStart.BackColor = Color.Transparent;
            PicBoxStart.Image = (Image)resources.GetObject("PicBoxStart.Image");
            PicBoxStart.Location = new Point(614, 257);
            PicBoxStart.Margin = new Padding(3, 4, 3, 4);
            PicBoxStart.Name = "PicBoxStart";
            PicBoxStart.Size = new Size(157, 179);
            PicBoxStart.SizeMode = PictureBoxSizeMode.Zoom;
            PicBoxStart.TabIndex = 0;
            PicBoxStart.TabStop = false;
            PicBoxStart.Click += pictureBox1_Click;
            // 
            // PicBoxBasket
            // 
            PicBoxBasket.BackColor = Color.Transparent;
            PicBoxBasket.Image = (Image)resources.GetObject("PicBoxBasket.Image");
            PicBoxBasket.Location = new Point(592, 593);
            PicBoxBasket.Margin = new Padding(3, 4, 3, 4);
            PicBoxBasket.Name = "PicBoxBasket";
            PicBoxBasket.Size = new Size(179, 166);
            PicBoxBasket.SizeMode = PictureBoxSizeMode.StretchImage;
            PicBoxBasket.TabIndex = 1;
            PicBoxBasket.TabStop = false;
            // 
            // SpawnTimer
            // 
            SpawnTimer.Interval = 2000;
            SpawnTimer.Tick += SpawnTimer_Tick;
            // 
            // FallTimer
            // 
            FallTimer.Tick += FallTimer_Tick;
            // 
            // LbPoints
            // 
            LbPoints.BackColor = Color.Transparent;
            LbPoints.Font = new Font("Showcard Gothic", 16.2F);
            LbPoints.ForeColor = SystemColors.ButtonFace;
            LbPoints.Location = new Point(174, 9);
            LbPoints.Name = "LbPoints";
            LbPoints.Size = new Size(102, 38);
            LbPoints.TabIndex = 2;
            LbPoints.Text = "0";
            // 
            // picMenu
            // 
            picMenu.BackColor = Color.Transparent;
            picMenu.Location = new Point(1290, 9);
            picMenu.Name = "picMenu";
            picMenu.Size = new Size(57, 47);
            picMenu.TabIndex = 3;
            picMenu.TabStop = false;
            picMenu.Click += picMenu_Click;
            // 
            // lblPause
            // 
            lblPause.BackColor = Color.Transparent;
            lblPause.Font = new Font("Showcard Gothic", 16.2F);
            lblPause.ForeColor = SystemColors.ButtonFace;
            lblPause.Location = new Point(592, 311);
            lblPause.Name = "lblPause";
            lblPause.Size = new Size(212, 64);
            lblPause.TabIndex = 4;
            lblPause.Text = "PAUSE";
            lblPause.TextAlign = ContentAlignment.MiddleCenter;
            lblPause.Visible = false;
            // 
            // lblContinue
            // 
            lblContinue.BackColor = Color.Transparent;
            lblContinue.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContinue.ForeColor = SystemColors.ButtonFace;
            lblContinue.Location = new Point(733, 359);
            lblContinue.Name = "lblContinue";
            lblContinue.Size = new Size(140, 64);
            lblContinue.TabIndex = 5;
            lblContinue.Text = "Continue";
            lblContinue.TextAlign = ContentAlignment.MiddleCenter;
            lblContinue.Visible = false;
            lblContinue.Click += lblContinue_Click;
            // 
            // lblGameSelection
            // 
            lblGameSelection.BackColor = Color.Transparent;
            lblGameSelection.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGameSelection.ForeColor = SystemColors.ButtonFace;
            lblGameSelection.Location = new Point(487, 359);
            lblGameSelection.Name = "lblGameSelection";
            lblGameSelection.Size = new Size(220, 64);
            lblGameSelection.TabIndex = 6;
            lblGameSelection.Text = "BACK TO GAME SELECTION";
            lblGameSelection.TextAlign = ContentAlignment.MiddleCenter;
            lblGameSelection.Visible = false;
            lblGameSelection.Click += lblGameSelection_Click;
            // 
            // LblLives
            // 
            LblLives.AutoSize = true;
            LblLives.BackColor = Color.Transparent;
            LblLives.Font = new Font("Showcard Gothic", 16.2F);
            LblLives.ForeColor = SystemColors.ButtonFace;
            LblLives.Location = new Point(3, 51);
            LblLives.Name = "LblLives";
            LblLives.Size = new Size(100, 35);
            LblLives.TabIndex = 7;
            LblLives.Text = "Lives:";
            // 
            // picHeart1
            // 
            picHeart1.BackColor = Color.Transparent;
            picHeart1.Image = (Image)resources.GetObject("picHeart1.Image");
            picHeart1.Location = new Point(100, 51);
            picHeart1.Name = "picHeart1";
            picHeart1.Size = new Size(50, 46);
            picHeart1.SizeMode = PictureBoxSizeMode.StretchImage;
            picHeart1.TabIndex = 8;
            picHeart1.TabStop = false;
            // 
            // picHeart2
            // 
            picHeart2.BackColor = Color.Transparent;
            picHeart2.Image = (Image)resources.GetObject("picHeart2.Image");
            picHeart2.Location = new Point(156, 51);
            picHeart2.Name = "picHeart2";
            picHeart2.Size = new Size(50, 46);
            picHeart2.SizeMode = PictureBoxSizeMode.StretchImage;
            picHeart2.TabIndex = 9;
            picHeart2.TabStop = false;
            // 
            // picHeart3
            // 
            picHeart3.BackColor = Color.Transparent;
            picHeart3.Image = (Image)resources.GetObject("picHeart3.Image");
            picHeart3.Location = new Point(212, 51);
            picHeart3.Name = "picHeart3";
            picHeart3.Size = new Size(50, 46);
            picHeart3.SizeMode = PictureBoxSizeMode.StretchImage;
            picHeart3.TabIndex = 10;
            picHeart3.TabStop = false;
            // 
            // lblRetry
            // 
            lblRetry.BackColor = Color.Transparent;
            lblRetry.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRetry.ForeColor = SystemColors.ButtonFace;
            lblRetry.Location = new Point(724, 359);
            lblRetry.Name = "lblRetry";
            lblRetry.Size = new Size(140, 64);
            lblRetry.TabIndex = 11;
            lblRetry.Text = "Retry";
            lblRetry.TextAlign = ContentAlignment.MiddleCenter;
            lblRetry.Visible = false;
            lblRetry.Click += lblRetry_Click;
            // 
            // lblGameOver
            // 
            lblGameOver.BackColor = Color.Transparent;
            lblGameOver.Font = new Font("Showcard Gothic", 16.2F);
            lblGameOver.ForeColor = SystemColors.ButtonFace;
            lblGameOver.Location = new Point(592, 247);
            lblGameOver.Name = "lblGameOver";
            lblGameOver.Size = new Size(212, 64);
            lblGameOver.TabIndex = 12;
            lblGameOver.Text = "GAME OVER";
            lblGameOver.TextAlign = ContentAlignment.MiddleCenter;
            lblGameOver.Visible = false;
            // 
            // lblCatnip
            // 
            lblCatnip.BackColor = Color.Transparent;
            lblCatnip.Font = new Font("Showcard Gothic", 16.2F);
            lblCatnip.ForeColor = SystemColors.ButtonFace;
            lblCatnip.Location = new Point(592, 311);
            lblCatnip.Name = "lblCatnip";
            lblCatnip.Size = new Size(212, 64);
            lblCatnip.TabIndex = 13;
            lblCatnip.TextAlign = ContentAlignment.MiddleCenter;
            lblCatnip.Visible = false;
            // 
            // CatcbFoodForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1359, 750);
            Controls.Add(lblCatnip);
            Controls.Add(lblGameOver);
            Controls.Add(lblRetry);
            Controls.Add(picHeart3);
            Controls.Add(picHeart2);
            Controls.Add(picHeart1);
            Controls.Add(LblLives);
            Controls.Add(lblGameSelection);
            Controls.Add(lblContinue);
            Controls.Add(lblPause);
            Controls.Add(picMenu);
            Controls.Add(LbPoints);
            Controls.Add(PicBoxBasket);
            Controls.Add(PicBoxStart);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CatcbFoodForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CatchFood";
            Load += CatchFoodForm_Load;
            KeyDown += CatcbFoodForm_KeyDown;
            ((System.ComponentModel.ISupportInitialize)PicBoxStart).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxBasket).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHeart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHeart2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHeart3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PicBoxStart;
        private PictureBox PicBoxBasket;
        private System.Windows.Forms.Timer SpawnTimer;
        private System.Windows.Forms.Timer FallTimer;
        private Label LbPoints;
        private PictureBox picMenu;
        private Label lblPause;
        private Label lblContinue;
        private Label lblGameSelection;
        private Label LblLives;
        private PictureBox picHeart1;
        private PictureBox picHeart2;
        private PictureBox picHeart3;
        private Label lblRetry;
        private Label lblGameOver;
        private Label lblCatnip;
    }
}

namespace catjack
{
    partial class CatjackDeck
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
            UserCards = new Panel();
            Computer_Panel = new Panel();
            lblWin = new Label();
            lblTie = new Label();
            lblLose = new Label();
            picMenu = new PictureBox();
            Computer_Score = new Label();
            Player_Score = new Label();
            picHit = new PictureBox();
            picStand = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStand).BeginInit();
            SuspendLayout();
            // 
            // UserCards
            // 
            UserCards.AutoScroll = true;
            UserCards.BackColor = Color.Transparent;
            UserCards.Location = new Point(289, 500);
            UserCards.Margin = new Padding(3, 4, 3, 4);
            UserCards.Name = "UserCards";
            UserCards.Size = new Size(1045, 251);
            UserCards.TabIndex = 0;
            UserCards.Paint += UserCards_Paint;
            // 
            // Computer_Panel
            // 
            Computer_Panel.AutoScroll = true;
            Computer_Panel.BackColor = Color.Transparent;
            Computer_Panel.Location = new Point(289, 1);
            Computer_Panel.Margin = new Padding(3, 4, 3, 4);
            Computer_Panel.Name = "Computer_Panel";
            Computer_Panel.Size = new Size(1045, 220);
            Computer_Panel.TabIndex = 1;
            // 
            // lblWin
            // 
            lblWin.AutoSize = true;
            lblWin.BackColor = Color.Transparent;
            lblWin.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWin.ForeColor = Color.PeachPuff;
            lblWin.Location = new Point(637, 309);
            lblWin.Name = "lblWin";
            lblWin.Size = new Size(356, 70);
            lblWin.TabIndex = 5;
            lblWin.Text = "You Win!\r\nYOU OBTAINED 1 CATNIP!";
            lblWin.TextAlign = ContentAlignment.MiddleCenter;
            lblWin.Visible = false;
            // 
            // lblTie
            // 
            lblTie.AutoSize = true;
            lblTie.BackColor = Color.Transparent;
            lblTie.Font = new Font("Showcard Gothic", 16.2F);
            lblTie.ForeColor = Color.PeachPuff;
            lblTie.Location = new Point(781, 309);
            lblTie.Name = "lblTie";
            lblTie.Size = new Size(59, 35);
            lblTie.TabIndex = 6;
            lblTie.Text = "Tie";
            lblTie.Visible = false;
            // 
            // lblLose
            // 
            lblLose.AutoSize = true;
            lblLose.BackColor = Color.Transparent;
            lblLose.Font = new Font("Showcard Gothic", 16.2F);
            lblLose.ForeColor = Color.PeachPuff;
            lblLose.Location = new Point(732, 309);
            lblLose.Name = "lblLose";
            lblLose.Size = new Size(157, 35);
            lblLose.TabIndex = 7;
            lblLose.Text = "You Lose!";
            lblLose.Visible = false;
            // 
            // picMenu
            // 
            picMenu.BackColor = Color.Transparent;
            picMenu.Location = new Point(75, 290);
            picMenu.Name = "picMenu";
            picMenu.Size = new Size(83, 68);
            picMenu.TabIndex = 8;
            picMenu.TabStop = false;
            picMenu.Click += picMenu_Click;
            // 
            // Computer_Score
            // 
            Computer_Score.BackColor = Color.Transparent;
            Computer_Score.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Computer_Score.ForeColor = Color.PeachPuff;
            Computer_Score.Location = new Point(30, 236);
            Computer_Score.Name = "Computer_Score";
            Computer_Score.Size = new Size(170, 30);
            Computer_Score.TabIndex = 9;
            Computer_Score.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Player_Score
            // 
            Player_Score.BackColor = Color.Transparent;
            Player_Score.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            Player_Score.ForeColor = Color.PeachPuff;
            Player_Score.Location = new Point(30, 404);
            Player_Score.Name = "Player_Score";
            Player_Score.Size = new Size(170, 30);
            Player_Score.TabIndex = 10;
            Player_Score.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picHit
            // 
            picHit.BackColor = Color.Transparent;
            picHit.Location = new Point(30, 532);
            picHit.Name = "picHit";
            picHit.Size = new Size(170, 194);
            picHit.TabIndex = 11;
            picHit.TabStop = false;
            picHit.Click += picHit_Click;
            // 
            // picStand
            // 
            picStand.BackColor = Color.Transparent;
            picStand.Location = new Point(30, 453);
            picStand.Name = "picStand";
            picStand.Size = new Size(192, 55);
            picStand.TabIndex = 12;
            picStand.TabStop = false;
            picStand.Click += picStand_Click;
            // 
            // CatjackDeck
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            BackgroundImage = Purrfect_Home.Properties.Resources.CATJACK_UI;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1359, 750);
            Controls.Add(picStand);
            Controls.Add(picHit);
            Controls.Add(lblTie);
            Controls.Add(Player_Score);
            Controls.Add(lblLose);
            Controls.Add(Computer_Score);
            Controls.Add(picMenu);
            Controls.Add(lblWin);
            Controls.Add(Computer_Panel);
            Controls.Add(UserCards);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CatjackDeck";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CatJackForm";
            Load += CatjackDeck_Load;
            ((System.ComponentModel.ISupportInitialize)picMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHit).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStand).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel Computer_Panel;
        public Panel UserCards;
        private Label lblWin;
        private Label lblTie;
        private Label lblLose;
        private PictureBox picMenu;
        private Label Computer_Score;
        private Label Player_Score;
        private PictureBox picHit;
        private PictureBox picStand;
    }
}

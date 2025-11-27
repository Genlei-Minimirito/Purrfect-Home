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
            Hit_button = new Button();
            Stand_Button = new Button();
            Computer_Panel = new Panel();
            Computer_Score = new TextBox();
            Player_Score = new TextBox();
            lblWin = new Label();
            lblTie = new Label();
            lblLose = new Label();
            SuspendLayout();
            // 
            // UserCards
            // 
            UserCards.AutoScroll = true;
            UserCards.BackColor = Color.OliveDrab;
            UserCards.Location = new Point(301, 340);
            UserCards.Margin = new Padding(3, 4, 3, 4);
            UserCards.Name = "UserCards";
            UserCards.Size = new Size(320, 211);
            UserCards.TabIndex = 0;
            UserCards.Paint += UserCards_Paint;
            // 
            // Hit_button
            // 
            Hit_button.BackColor = Color.Chocolate;
            Hit_button.Location = new Point(682, 417);
            Hit_button.Margin = new Padding(3, 4, 3, 4);
            Hit_button.Name = "Hit_button";
            Hit_button.Size = new Size(135, 56);
            Hit_button.TabIndex = 1;
            Hit_button.Text = "HIT";
            Hit_button.UseVisualStyleBackColor = false;
            Hit_button.Click += Hit_button_Click;
            // 
            // Stand_Button
            // 
            Stand_Button.BackColor = Color.Chocolate;
            Stand_Button.Location = new Point(682, 495);
            Stand_Button.Margin = new Padding(3, 4, 3, 4);
            Stand_Button.Name = "Stand_Button";
            Stand_Button.Size = new Size(135, 56);
            Stand_Button.TabIndex = 2;
            Stand_Button.Text = "STAND";
            Stand_Button.UseVisualStyleBackColor = false;
            Stand_Button.Click += Stand_Button_Click;
            // 
            // Computer_Panel
            // 
            Computer_Panel.AutoScroll = true;
            Computer_Panel.BackColor = Color.OliveDrab;
            Computer_Panel.Location = new Point(301, 16);
            Computer_Panel.Margin = new Padding(3, 4, 3, 4);
            Computer_Panel.Name = "Computer_Panel";
            Computer_Panel.Size = new Size(320, 211);
            Computer_Panel.TabIndex = 1;
            // 
            // Computer_Score
            // 
            Computer_Score.Location = new Point(168, 100);
            Computer_Score.Margin = new Padding(3, 4, 3, 4);
            Computer_Score.Name = "Computer_Score";
            Computer_Score.Size = new Size(114, 27);
            Computer_Score.TabIndex = 3;
            // 
            // Player_Score
            // 
            Player_Score.Location = new Point(168, 443);
            Player_Score.Margin = new Padding(3, 4, 3, 4);
            Player_Score.Name = "Player_Score";
            Player_Score.Size = new Size(114, 27);
            Player_Score.TabIndex = 4;
            // 
            // lblWin
            // 
            lblWin.AutoSize = true;
            lblWin.Location = new Point(423, 272);
            lblWin.Name = "lblWin";
            lblWin.Size = new Size(67, 20);
            lblWin.TabIndex = 5;
            lblWin.Text = "You Win!";
            lblWin.Visible = false;
            // 
            // lblTie
            // 
            lblTie.AutoSize = true;
            lblTie.Location = new Point(450, 272);
            lblTie.Name = "lblTie";
            lblTie.Size = new Size(29, 20);
            lblTie.TabIndex = 6;
            lblTie.Text = "Tie";
            lblTie.Visible = false;
            // 
            // lblLose
            // 
            lblLose.AutoSize = true;
            lblLose.Location = new Point(423, 272);
            lblLose.Name = "lblLose";
            lblLose.Size = new Size(71, 20);
            lblLose.TabIndex = 7;
            lblLose.Text = "You Lose!";
            lblLose.Visible = false;
            // 
            // CatjackDeck
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(914, 600);
            Controls.Add(lblLose);
            Controls.Add(lblTie);
            Controls.Add(lblWin);
            Controls.Add(Player_Score);
            Controls.Add(Computer_Score);
            Controls.Add(Computer_Panel);
            Controls.Add(Stand_Button);
            Controls.Add(Hit_button);
            Controls.Add(UserCards);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CatjackDeck";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += CatjackDeck_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Hit_button;
        private Button Stand_Button;
        private Panel Computer_Panel;
        private TextBox Computer_Score;
        private TextBox Player_Score;
        public Panel UserCards;
        private Label lblWin;
        private Label lblTie;
        private Label lblLose;
    }
}

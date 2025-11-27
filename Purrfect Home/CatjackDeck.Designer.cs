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
            SuspendLayout();
            // 
            // UserCards
            // 
            UserCards.AutoScroll = true;
            UserCards.BackColor = Color.OliveDrab;
            UserCards.Location = new Point(263, 255);
            UserCards.Name = "UserCards";
            UserCards.Size = new Size(280, 158);
            UserCards.TabIndex = 0;
            UserCards.Paint += UserCards_Paint;
            // 
            // Hit_button
            // 
            Hit_button.BackColor = Color.Chocolate;
            Hit_button.Location = new Point(597, 313);
            Hit_button.Name = "Hit_button";
            Hit_button.Size = new Size(118, 42);
            Hit_button.TabIndex = 1;
            Hit_button.Text = "HIT";
            Hit_button.UseVisualStyleBackColor = false;
            Hit_button.Click += Hit_button_Click;
            // 
            // Stand_Button
            // 
            Stand_Button.BackColor = Color.Chocolate;
            Stand_Button.Location = new Point(597, 371);
            Stand_Button.Name = "Stand_Button";
            Stand_Button.Size = new Size(118, 42);
            Stand_Button.TabIndex = 2;
            Stand_Button.Text = "STAND";
            Stand_Button.UseVisualStyleBackColor = false;
            Stand_Button.Click += Stand_Button_Click;
            // 
            // Computer_Panel
            // 
            Computer_Panel.AutoScroll = true;
            Computer_Panel.BackColor = Color.OliveDrab;
            Computer_Panel.Location = new Point(263, 12);
            Computer_Panel.Name = "Computer_Panel";
            Computer_Panel.Size = new Size(280, 158);
            Computer_Panel.TabIndex = 1;
            // 
            // Computer_Score
            // 
            Computer_Score.Location = new Point(147, 75);
            Computer_Score.Name = "Computer_Score";
            Computer_Score.Size = new Size(100, 23);
            Computer_Score.TabIndex = 3;
            // 
            // Player_Score
            // 
            Player_Score.Location = new Point(147, 332);
            Player_Score.Name = "Player_Score";
            Player_Score.Size = new Size(100, 23);
            Player_Score.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(800, 450);
            Controls.Add(Player_Score);
            Controls.Add(Computer_Score);
            Controls.Add(Computer_Panel);
            Controls.Add(Stand_Button);
            Controls.Add(Hit_button);
            Controls.Add(UserCards);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
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
    }
}

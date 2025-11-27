namespace catjack
{
    public partial class CatjackDeck : Form
    {
        
        int UserCardSum = 0;
        int ComputerCardSum = 0;

        public CatjackDeck()
        {
            InitializeComponent();
            Player_Score.ReadOnly = true;
            Computer_Score.ReadOnly = true;
        }

        private void Hit_button_Click(object sender, EventArgs e)
        {

            DrawCards draw = new DrawCards(UserCards);
            int cardNum = draw.DrawCard();
            
            UserCardSum = UserCardSum + cardNum;
            int pscore = UserCardSum;
            Player_Score.Text = pscore.ToString();
            if (UserCardSum >= 21)
            {
                Hit_button.Enabled = false;
                ComputerPlay();
                Stand_Button.Enabled = false;
                

            }



        }

        public void UserCards_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Stand_Button_Click(object sender, EventArgs e)
        {
            ComputerPlay();
            Stand_Button.Enabled = false;
            Hit_button.Enabled = false;
            
        }
        public void ComputerPlay()
        {
            
            while (ComputerCardSum < UserCardSum + 1)
            {
                DrawCards draw = new DrawCards(Computer_Panel);
                int cardNum = draw.DrawCard();
                ComputerCardSum = ComputerCardSum + cardNum;
                
                

                if (ComputerCardSum >= 21)
                {
                    
                    break;
                }
            }
            
            Computer_Score.Text = ComputerCardSum.ToString();
            if (UserCardSum > 21) 
            {
                TextBox lose = new TextBox();
                lose.Location = new System.Drawing.Point(380, 200);
                lose.Size = new System.Drawing.Size(50, 300);
                lose.TextAlign = HorizontalAlignment.Center;
                lose.Text = "You Lost";
                lose.ReadOnly = true;
                this.Controls.Add(lose);
            }
            else if (ComputerCardSum > 21)
            {
                TextBox win = new TextBox();
                win.Location = new System.Drawing.Point(380, 200);
                win.Size = new System.Drawing.Size(70, 300);
                win.Text = "You Win";
                win.TextAlign = HorizontalAlignment.Center;
                win.ReadOnly = true;
                this.Controls.Add(win);
            }
            else if (ComputerCardSum < UserCardSum)
            {
                TextBox win = new TextBox();
                win.Location = new System.Drawing.Point(380, 200);
                win.Size = new System.Drawing.Size(70, 300);
                win.Text = "You Win";
                win.TextAlign = HorizontalAlignment.Center;
                win.ReadOnly = true;
                this.Controls.Add(win);

            }
            else if (ComputerCardSum > UserCardSum)
            {
                TextBox lose = new TextBox();
                lose.Location = new System.Drawing.Point(380, 200);
                lose.Size = new System.Drawing.Size(50, 300);
                lose.TextAlign = HorizontalAlignment.Center;
                lose.Text = "You Lost";
                lose.ReadOnly = true;
                this.Controls.Add(lose);
            }
            else
            {
                TextBox tie = new TextBox();
                tie.Location = new System.Drawing.Point(380, 200);
                tie.Size = new System.Drawing.Size(50, 300);
                tie.TextAlign = HorizontalAlignment.Center;
                tie.Text = "It's a tie";
                tie.ReadOnly = true;
                this.Controls.Add(tie);
            }
        }
    }
}

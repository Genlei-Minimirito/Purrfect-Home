using Purrfect_Home;

namespace catjack
{
    public partial class CatjackDeck : Form
    {

        int UserCardSum = 0;
        int ComputerCardSum = 0;

        public CatjackDeck()
        {
            InitializeComponent();

        }

        public void UserCards_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picHit_Click(object sender, EventArgs e)
        {
            DrawCards draw = new DrawCards(UserCards);
            int cardNum = draw.DrawCard();

            UserCardSum += cardNum;

            // Works for Label
            Player_Score.Text = UserCardSum.ToString();

            if (UserCardSum >= 21)
            {
                picHit.Enabled = false;
                ComputerPlay();
                picStand.Enabled = false;
            }
        }

        private void picStand_Click(object sender, EventArgs e)
        {
            ComputerPlay();
            picStand.Enabled = false;
            picHit.Enabled = false;
        }
       

        public void ComputerPlay()
        {
            while (ComputerCardSum < UserCardSum + 1)
            {
                DrawCards draw = new DrawCards(Computer_Panel);
                int cardNum = draw.DrawCard();
                ComputerCardSum += cardNum;

                if (ComputerCardSum >= 21)
                {
                    break;
                }
            }

            // Works for Label
            Computer_Score.Text = ComputerCardSum.ToString();

            // Hide all labels first
            lblWin.Visible = false;
            lblLose.Visible = false;
            lblTie.Visible = false;

            if (UserCardSum > 21)
            {
                lblLose.Visible = true;
            }
            else if (ComputerCardSum > 21)
            {
                lblWin.Visible = true;
            }
            else if (ComputerCardSum < UserCardSum)
            {
                lblWin.Visible = true;
            }
            else if (ComputerCardSum > UserCardSum)
            {
                lblLose.Visible = true;
            }
            else
            {
                lblTie.Visible = true;
            }
        }

        private void CatjackDeck_Load(object sender, EventArgs e)
        {

        }

        private void lblWin_Click(object sender, EventArgs e)
        {

        }

        private void picMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formMenu = new HomeForm();
            formMenu.StartPosition = FormStartPosition.Manual;
            formMenu.Location = this.Location;
            formMenu.ShowDialog();
        }

       
    }
}

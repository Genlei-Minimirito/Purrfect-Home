using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace catjack
{
    internal class DrawCards
    {
        private Panel UserCard;
        int offset = 100;
        private static Random r = new Random();

        public DrawCards(Panel PlayerPanel)
        {
            UserCard = PlayerPanel;
        }   
        public int DrawCard()
        {
            
            int cardNum = r.Next(1, 11);
            
            Image img = (Image)catjack.Resources.ResourceManager.GetObject(cardNum.ToString());

            PictureBox card = new PictureBox();
            card.Width = 80;
            card.Height = 120;
            card.SizeMode = PictureBoxSizeMode.StretchImage;
            card.Image = img;

            
            int count = UserCard.Controls.Count;
            card.Left = count * offset;
            card.Top = 0;
            UserCard.Controls.Add(card);
            
            return cardNum;
        }
    }
}

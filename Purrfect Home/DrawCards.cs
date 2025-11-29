using System;
using System.Drawing;
using System.Windows.Forms;

namespace Purrfect_Home
{
    internal class DrawCards
    {
        private Panel UserCard;
        private static Random r = new Random();

        // Adjust this to change spacing
        private int spacing = 15;

        public DrawCards(Panel PlayerPanel)
        {
            UserCard = PlayerPanel;
        }

        public int DrawCard()
        {
            int cardNum = r.Next(1, 11);

            string resourceKey = $"_{cardNum}";

            if (Purrfect_Home.Properties.Resources.ResourceManager.GetObject(resourceKey) is not Image img)
                throw new Exception($"Resource not found: {resourceKey}");

            PictureBox card = new PictureBox();
            card.Height = UserCard.Height;      // match panel height
            card.Width = 140;                    // card width
            card.SizeMode = PictureBoxSizeMode.StretchImage;
            card.Image = img;

            // this card's index
            int index = UserCard.Controls.Count;

            // place each card left → right
            card.Left = index * (card.Width + spacing);
            card.Top = 0;

            UserCard.Controls.Add(card);

            return cardNum;
        }
    }
}

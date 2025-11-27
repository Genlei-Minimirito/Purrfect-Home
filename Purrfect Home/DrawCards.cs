using System;
using System.Drawing;
using System.Windows.Forms;

namespace Purrfect_Home
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

            // Your resource names: _1, _2, _3, ... _10
            string resourceKey = $"_{cardNum}";

            // Safely load resource
            if (Purrfect_Home.Properties.Resources.ResourceManager.GetObject(resourceKey) is not Image img)
                throw new Exception($"Resource not found: {resourceKey}");

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

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Purrfect_Home
{
    public abstract class Catfood
    {
        public PictureBox FruitPicture { get; set; }
        public int FallSpeed { get; set; } = 2;

        protected Form gameForm;

        private int tickOffset = 0;
        private int tickCounter = 0;

        public Catfood(Form form)
        {
            gameForm = form;

            FruitPicture = new PictureBox();
            FruitPicture.Width = 70;
            FruitPicture.Height = 70;
            FruitPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            FruitPicture.BackColor = Color.Transparent;

            Random r = new Random(Guid.NewGuid().GetHashCode());
            tickOffset = r.Next(0, 3);
        }

        public virtual void Spawn(Random random)
        {
            FruitPicture.Left = random.Next(0, gameForm.ClientSize.Width - FruitPicture.Width);
            FruitPicture.Top = -FruitPicture.Height;

            gameForm.Controls.Add(FruitPicture);
        }

        public void Fall()
        {
            tickCounter++;

            if (tickCounter >= tickOffset)
            {
                FruitPicture.Top += FallSpeed;
                tickCounter = 0;
            }
        }

        public bool CheckCollision(PictureBox basket)
        {
            return FruitPicture.Bounds.IntersectsWith(basket.Bounds);
        }

        public abstract int GetPoints();
    }
}

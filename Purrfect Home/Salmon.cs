using System.Drawing;
using System.Windows.Forms;

namespace Purrfect_Home
{
    public class Salmon : Catfood
    {
        public Salmon(Form form) : base(form)
        {
            FruitPicture.Image = Properties.Resources.SALMON;
        }

        public override int GetPoints()
        {
            return 1;
        }
    }
}

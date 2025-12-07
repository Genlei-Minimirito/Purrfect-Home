using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purrfect_Home
{
    public class Dryfood : Catfood
    {
        public Dryfood(Form form) : base(form)
        {
            FruitPicture.Image = Properties.Resources.DRY_FOOD;
        }

        public override int GetPoints()
        {
            return 2; 
        }
    }
}

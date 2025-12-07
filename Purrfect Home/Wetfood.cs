using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purrfect_Home
{
    public class Wetfood : Catfood
    {
        public Wetfood(Form form) : base(form)
        {
            FruitPicture.Image = Properties.Resources.WET_FOOD;
        }

        public override int GetPoints()
        {
            return 3;
        }
    }
}

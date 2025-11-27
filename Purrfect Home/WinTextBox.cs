using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace catjack
{
    internal class WinTextBox
    {
        
        public void WinText()
        {
            TextBox win = new TextBox();
            win.Location = new System.Drawing.Point(380, 200);
            win.Size = new System.Drawing.Size(70, 300);
            win.Text = "You Win";
            win.TextAlign = HorizontalAlignment.Center;
            win.ReadOnly = true;
            //this.Controls.Add(win);
        }
    }
}

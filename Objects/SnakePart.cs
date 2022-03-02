using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Snake_Game.Objects
{
    //Part of body
    internal class SnakePart : PictureBox
    {
        public SnakePart()
        {
            Image = Properties.Resources.SnakePart;
            BackColor = Color.Aquamarine;
            Size = new Size(30, 30);
            SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}

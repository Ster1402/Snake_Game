using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snake_Game.Objects
{
    internal class Board
    {
        public int distanceToLeft { get; set; }
        public int distanceToRight { get; set; }
        public int distanceToTop { get; set; }
        public int distanceToBottom { get; set; }

        public int Location { get; set; }

        public int width { get; private set; }
        public int height { get; private set; }

        public Board(int L, int T, int R, int B, Size size)
        {
            distanceToLeft = L;
            distanceToTop = T;
            distanceToRight = R;
            distanceToBottom = B;

            width = size.Width;
            height = size.Height;
        }
    }
}

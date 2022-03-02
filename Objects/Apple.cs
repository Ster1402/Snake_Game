using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;

namespace Snake_Game.Objects
{
    internal class Apple : PictureBox
    {
        public GameWindows parent { get; set; }
        public Apple(GameWindows parent)
        {
            this.parent = parent;

            Image = Properties.Resources.apple;
            BackColor = Color.Aquamarine;
            Size = new Size(30, 30);
            SizeMode = PictureBoxSizeMode.StretchImage;

            Top = Height * 7;
            Left = Width * 7;

            draw();
        }

        public void draw()
        {
            parent.getGameBoard().Controls.Add(this);
        }

        public void choosePostion(Snake snake)
        {
            bool positionFinded;

            int maxResearchNumber = 800;

            int endLeft = (parent.getGameBoard().Width - Width) / Width;

            int endTop = (parent.getGameBoard().Height - Height) / Height;

            int tempLeft, tempTop;
            Random randLeft = new Random();
            Random randTop = new Random();

            do
            {
                positionFinded = true;

                tempLeft = randLeft.Next(endLeft + 1);
                tempTop = randTop.Next(endTop + 1);

                //On vérifie que la position n'est pas occupé
                foreach(SnakePart part in snake.body)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " : Apple test Left : " + (tempLeft * Width) + " Snake part Left : " + part.Left);
                    Console.WriteLine(Thread.CurrentThread.Name + " : Apple test Top : " + (tempTop * Width) + " Snake part Top : " + part.Top);
                    if ( ( (tempLeft * Width) == part.Left ) && ( (tempTop * Height) == part.Top) )
                        positionFinded = false;
                }

                maxResearchNumber--;

            } while (!positionFinded && maxResearchNumber > 0);

            if (positionFinded)
            {
                Left = tempLeft * Width;
                Top = tempTop * Height;
            }
            else
            {
                parent.getGameBoard().Controls.Remove(this);
            }
        }
    }
}

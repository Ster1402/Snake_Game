using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;

namespace Snake_Game.Objects
{
    enum Directions
    {
        Left, Right, Up, Down
    }

    internal class Snake
    {

        public Directions goTo { get; set; }
        private GameWindows parent;

        //Board limits
        public Board board { get; set; }

        //Body parts
        private SnakePart queue;
        private SnakePart firstBodyPart;
        private SnakePart head;
        public List<SnakePart> body { get; set; }
        public int movingSpeed; //Temps qui sera utiliser dans le thread de déplacement
        public int numberOfPixelToMove;

        //Thread de déplacement
        public Thread snakeMovingThread { get; set; }
        public delegate void DelegateChangeDirectionType(Directions direction);
        public DelegateChangeDirectionType delegateMouvement;
        public bool couldMove { get; set; }

        //Thread de collision
        public Thread snakeCollisionThread { get; set; }
        private bool couldCheckForCollision;

        public Snake(GameWindows parent)
        {
            this.parent = parent;
            PictureBox b = parent.getGameBoard();

            board = new Board(b.Left, b.Top, b.Right - b.Width, b.Bottom - b.Height, b.Size);
            
            initBodyPart();

            initThread();
        }

        private void initBodyPart()
        {
            //
            //Initialisation du corps
            //
            body = new List<SnakePart>();

            //Initialisation de la tête
            head = new SnakePart
            {
                Image = Properties.Resources.snake_head_down, //Par défaut le serpent se dirige vers le bas
                Name = "snakeHead",
            };
            //Initialisation de la queue
            queue = new SnakePart
            {
                Image = Properties.Resources.SnakePart_Queue,
                Name = "SnakeQueue",
            };

            //Initialisation d'une partie du corps
            firstBodyPart = new SnakePart();

            head.Top = head.Height * 6;
            head.Left = head.Width * 4;

            firstBodyPart.Top = head.Top - firstBodyPart.Height;
            firstBodyPart.Left = head.Left;

            queue.Top = firstBodyPart.Top - queue.Height;
            queue.Left = firstBodyPart.Left;

            body.Add(head);
            body.Add(firstBodyPart);
            body.Add(queue);

        }
        private void initThread()
        {
            //Initialisation du thread de déplacement
            snakeMovingThread = new Thread(movingThread);
            //Chargé d'exécuter le déplacement dans le thread principal
            delegateMouvement = new DelegateChangeDirectionType(moveTo); 
            movingSpeed = 250; //Reduire pour augmenter la vitesse
            goTo = Directions.Down; //Au départ

            numberOfPixelToMove = head.Width; //On de déplace de toute la largeur du corps

            //Thread de collision
            snakeCollisionThread = new Thread(handleCollisionThread);
            couldCheckForCollision = false;
        }
        public void initialDraw()
        {
            parent.getGameBoard().Controls.Add(head);
            parent.getGameBoard().Controls.Add(firstBodyPart);
            parent.getGameBoard().Controls.Add(queue);

            //Lancement des threads après qu'on est mis le serpent
            snakeMovingThread.Start();
            snakeCollisionThread.Start();
        }
        public void removeSnake()
        {
            try
            {
                snakeMovingThread.Abort();
                snakeCollisionThread.Abort();

            }
            catch (Exception) { }

            foreach (SnakePart snakePart in body)
            {
                parent.getGameBoard().Controls.Remove(snakePart);
            }
        }

        public void changeDirection(Directions direction)
        {
            if (couldMove)
            {
                try
                {

                    Thread.Sleep(20);

                    Console.Write(Thread.CurrentThread.Name + " : Change direction....\n");

                    if (goTo == Directions.Left && direction == Directions.Right) return;
                    if (goTo == Directions.Up && direction == Directions.Down) return;
                    if (direction == Directions.Left && goTo == Directions.Right) return;
                    if (direction == Directions.Up && goTo == Directions.Down) return;

                    goTo = direction;

                    Console.Write(Thread.CurrentThread.Name + " : Change direction end !\n");

                }
                catch (Exception) { }
            }

        }
        private void moveTo(Directions direction)
        {
            if (!couldCheckForCollision)
            {
                couldMove = false;

                Point tempPosition_1 = body[0].Location;

                switch (direction)
                {
                    case Directions.Left:
                        body[0].Location = new Point(body[0].Location.X - numberOfPixelToMove, body[0].Location.Y);
                        body[0].Image = Properties.Resources.snake_head_left;
                        break;
                    case Directions.Up:
                        body[0].Location = new Point(body[0].Location.X, body[0].Location.Y - numberOfPixelToMove);
                        body[0].Image = Properties.Resources.snake_head_up;
                        break;
                    case Directions.Right:
                        body[0].Location = new Point(body[0].Location.X + numberOfPixelToMove, body[0].Location.Y);
                        body[0].Image = Properties.Resources.snake_head_right;
                        break;
                    case Directions.Down:
                        body[0].Location = new Point(body[0].Location.X, body[0].Location.Y + numberOfPixelToMove);
                        body[0].Image = Properties.Resources.snake_head_down;
                        break;
                }

                for (int i = 1; i < body.Count; i++)
                {
                    Point positionTemp = body[i].Location;
                    body[i].Location = tempPosition_1;
                    tempPosition_1 = positionTemp;

                }

                couldMove = true;
                couldCheckForCollision = true;
            }

        }

        //Thread déplacement
        private void movingThread()
        {
            Thread.CurrentThread.Name = "MovingSnakeThread";

            //Début dans 2s
            Thread.Sleep(1000);
            couldMove = true;

            while (Thread.CurrentThread.IsAlive && !shouldGameOver())
            {
                try
                {
                    
                    if (couldMove)
                    {
                        Console.Write(Thread.CurrentThread.Name + " : Moving....\n");
                        parent.Invoke(delegateMouvement, goTo);
                    }
                }
                catch (Exception e) {
                    Console.WriteLine("Error from moving thread : " + e.Message);                
                }

                Console.Write(Thread.CurrentThread.Name + " : Moving end !\n");
                Thread.Sleep(movingSpeed);

            }
        }


        //Check for collision
        public bool shouldGameOver()
        {
            try
            {
                //Find collision with the board
                SnakePart head = body[0];
                
                /*Console.WriteLine(Thread.CurrentThread.Name + " : Head Location = " + head.Location.ToString());
                Console.WriteLine(Thread.CurrentThread.Name + " : Head Top = " + head.Top + " Board height : " + board.height);
                */

                if (head.Left < 0 || head.Top >= board.height || head.Left >= board.width || head.Top < 0)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " : Collision detected...");
                    return true;
                }

                //Collision with his body
                for (int i = 1; i < body.Count; i++)
                {
                    if (head.Location == body[i].Location)
                    {
                        Console.WriteLine(Thread.CurrentThread.Name + " : Collision detected...");
                        return true;
                    }
                }

                //Console.WriteLine(Thread.CurrentThread.Name + " : No collision detected...");

                return false;

            }catch (Exception)
            {
                return false;
            }

        }

        //Thread qui surveille les collisions
        public void handleCollisionThread()
        {
            Thread.CurrentThread.Name = "SnakeCollisionThread";

            while (Thread.CurrentThread.IsAlive)
            {
          
                if (couldCheckForCollision)
                {
                    Console.Write(Thread.CurrentThread.Name + " : Checking for collision....\n");
                    if (shouldGameOver())
                    {
                        parent.gameOver = true;

                        try
                        {
                            Thread.CurrentThread.Abort();
                        }catch(Exception)
                        {
                            Console.Write(Thread.CurrentThread.Name + " : Error Abort....\n");

                        }
                    }

                    //Eat ?
                    eat();

                    couldCheckForCollision = false;
                }

                Console.Write(Thread.CurrentThread.Name + " : Checking for collision end !\n");
                Thread.Sleep(movingSpeed);
            }
        }

        //Eat
        public bool hasEat(Apple apple) => apple.Location == body[0].Location;
        public void eat()
        {
            if (hasEat(parent.apple))
            {
                Console.WriteLine("Eating...");
                parent.playSoundGame("eat.wav");
                
                try
                {
                    //Update score
                    parent.Invoke(parent.delegateUpdateScore);
                }
                catch (Exception) { }

                Console.WriteLine("Done eating...");
            }
        }

        //Snake grow
        public void grow()
        {
            Console.WriteLine("Grow start !");
            couldMove = false;

            SnakePart tempHead;
            SnakePart part = new SnakePart();

            part.Location = body[0].Location; //L'ancienne localisation

            switch (goTo)
            {
                case Directions.Left:
                    body[0].Location = new Point(body[0].Location.X - numberOfPixelToMove, body[0].Location.Y);
                    body[0].Image = Properties.Resources.snake_head_left;
                    break;
                case Directions.Up:
                    body[0].Location = new Point(body[0].Location.X, body[0].Location.Y - numberOfPixelToMove);
                    body[0].Image = Properties.Resources.snake_head_up;
                    break;
                case Directions.Right:
                    body[0].Location = new Point(body[0].Location.X + numberOfPixelToMove, body[0].Location.Y);
                    body[0].Image = Properties.Resources.snake_head_right;
                    break;
                case Directions.Down:
                    body[0].Location = new Point(body[0].Location.X, body[0].Location.Y + numberOfPixelToMove);
                    body[0].Image = Properties.Resources.snake_head_down;
                    break;
            }
            tempHead = body[0];

            body.RemoveAt(0);
            body.Insert(0, tempHead);
            body.Insert(1, part);

            Console.WriteLine(Thread.CurrentThread.Name + " : Head Location : " + body[0].Location.ToString() + " New part Location : " + part.Location.ToString());

            parent.getGameBoard().Controls.Add(part);

            couldMove = true;

            Console.WriteLine("Grow end !");
        }
    }
}

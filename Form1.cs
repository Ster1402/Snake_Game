using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Snake_Game.Objects;


namespace Snake_Game
{
    public partial class GameWindows : Form
    {
        private bool gameStarted;
        private bool mainMenuIsActive;
        public bool gameOver { get; set; }
        private bool gameMenuIsActive;
        private bool buttonStartIsFocused = true;
        private bool buttonSettingsIsFocused;
        private bool buttonExitIsFocused;

        //Game Menu
        private bool buttonRestartIsFocus = true;
        private bool buttonMenuIsFocused = false;
        private bool buttonResumeIsFocused = false;

        private Snake snake;
        internal Apple apple { get; set; }

        public int score { get; set; }

        //Control du jeu
        public Thread gameThread;
        public delegate void DelegateUpdateScoreType();
        public DelegateUpdateScoreType delegateUpdateScore;

        public delegate void DelegateShowMenuType();
        public DelegateShowMenuType delegateShowMenu { get; set; }

        public GameWindows()
        {
            InitializeComponent();

            GamePages.Controls.Remove(gamePage);
            GamePages.TabPages.Remove(gamePage);

            gameStarted = false;
            mainMenuIsActive = true;
            gameOver = false;
            gameMenuIsActive = false;
        }


        //Button menu clicked
        private void handleSettingsClicked(object sender, EventArgs e)
        {

        }

        private void handleStartClicked(object sender, EventArgs e)
        {
            startGame();
        }

        private void handleExitClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Mouse Enter and Leave
        private void handleHoverButtonMenu(object sender, EventArgs e)
        {

            buttonMenuHover(sender);

        }
        private void handleLeaveHoverButtonMenu(object sender, EventArgs e)
        {
            buttonMenuLeave(sender);
        }

        //Musiques
        private void playBackgroundSound(string url)
        {
            soundBackground.URL = "Resources/sounds/" + url;
            soundBackground.settings.setMode("loop", true);
            soundBackground.Ctlcontrols.play();
        }
        private void playSoundMenu(string url)
        {
            soundMenuButton.URL = "Resources/sounds/" + url;
            soundMenuButton.Ctlcontrols.play();
        }

        public void playSoundGame(string url)
        {
            soundMenuButton.URL = "Resources/sounds/" + url;
            soundMenuButton.Ctlcontrols.play();
        }


        //Chargement du jeu
        private void Game_Load(object sender, EventArgs e)
        {
            //Lorsque le jeu commence on lance la musique du menu
            playBackgroundSound("menu.mkv");

        }

        //Keys pressed
        private void handleKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (gameStarted) snake.changeDirection(Directions.Up);
                    Up_Is_Pressed();
                    break;
                case Keys.Down:
                    if (gameStarted) snake.changeDirection(Directions.Down);
                    Down_Is_Pressed();
                    break;
                case Keys.Left:
                    if (gameStarted) snake.changeDirection(Directions.Left);
                    Left_Is_Pressed();
                    break;
                case Keys.Right:
                    if (gameStarted) snake.changeDirection(Directions.Right);
                    Right_Is_Pressed();
                    break;
                case Keys.Enter:
                    Enter_Is_Pressed();
                    break;
                case Keys.Escape:
                    if (gameStarted)
                        Escape_Is_Pressed();
                    break;
            }
        }
        private void handleKeyUp(object sender, KeyEventArgs e)
        {

        }

        //Lancement du jeu
        private void startGame()
        {
            //On passe à la page de jeu : gamePage et on lance la musique de fond
            playBackgroundSound("game.wav");

            if (!gameStarted)
            {
                GamePages.TabPages.Remove(menuPage);
                GamePages.Controls.Remove(menuPage);

                GamePages.TabPages.Add(gamePage);
                //GamePages.Controls.Add(menuPage);

            }

            gameStarted = true;
            score = 0;
            gameOver = false;
            mainMenuIsActive = false;
            gameMenuIsActive = false;

            //On charge notre serpent
            snake = new Snake(this);
            snake.initialDraw();

            apple = new Apple(this);
            gameBoard.Controls.Add(apple);

            gameThread = new Thread(mainThread);
            gameThread.Start();
            delegateUpdateScore = new DelegateUpdateScoreType(updateScore);
            delegateShowMenu = new DelegateShowMenuType(showMenu);
        }
        
        //Sub Menu Event
        private void addSubMenuEvent() {
            //Click event
            buttonRestart.Click += new EventHandler(handleRestartClicked);
            buttonMenu.Click += new EventHandler(handleMenuClicked);

            //Mouse enter event
            buttonRestart.MouseEnter += new EventHandler(handleHoverGameMenu);
            buttonMenu.MouseEnter += new EventHandler(handleHoverGameMenu);

            //Mous Leave event
            buttonRestart.MouseLeave += new EventHandler(handleLeaveHoverGameMenu);
            buttonMenu.MouseLeave += new EventHandler(handleLeaveHoverGameMenu);
        }
        private void removeSubMenuEvent() {
            //Click event
            buttonRestart.Click -= handleRestartClicked;
            buttonMenu.Click -= handleMenuClicked;

            //Mouse enter event
            buttonRestart.MouseEnter -= (handleHoverGameMenu);
            buttonMenu.MouseEnter -= (handleHoverGameMenu);

            //Mous Leave event
            buttonRestart.MouseLeave -= (handleLeaveHoverGameMenu);
            buttonMenu.MouseLeave -= (handleLeaveHoverGameMenu);

        }
        private void handleRestartClicked(object sender, EventArgs e) {
            if (gameOver)
                restartGame();
            else if (buttonResumeIsFocused)
            {
                resumeGame();   
            }
        }
        private void handleMenuClicked(object sender, EventArgs e) {
            hideMenu();
            showMainMenu();
        }
        private void handleHoverGameMenu(object sender, EventArgs e) {
            buttonGameMenuHover((Label)sender);
        }
        private void handleLeaveHoverGameMenu(object sender, EventArgs e) {
            buttonGameMenuLeave((Label)sender);
        }
   
        //Game menu
        public void showMenu()
        {
            if (gameStarted)
            {
                gameMenuIsActive = true;

                soundBackground.Ctlcontrols.pause();

                try
                {
                    if (gameOver)
                    {
                        snake.snakeMovingThread.Abort();
                        snake.snakeCollisionThread.Abort();
                        gameThread.Abort();
                    }
                    
                }
                catch (Exception) { }

                foreach (Control gameMenu in gamePage.Controls)
                {
                    if (gameMenu.Tag == "gameMenu")
                    {
                        if (gameMenu.Name == "gameMenuTitle" && !gameOver)
                            gameMenu.Text = "Continue ?";
                        else if (gameMenu.Name == "gameMenuTitle" && !gameOver )
                            gameMenu.Text = "Restart ?";

                        gameMenu.Visible = true;
                    }
                }

                addSubMenuEvent();
            }

        }
        //Hide menud
        public void hideMenu()
        {
            if (gameStarted)
            {
                soundBackground.Ctlcontrols.play();

                gameMenuIsActive = false;
                
                foreach (Control gameMenu in gamePage.Controls)
                {
                    if (gameMenu.Tag == "gameMenu")
                    {
                        if (gameMenu.Name == "gameMenuTitle")
                            gameMenu.Text = "Try Again";

                        gameMenu.Visible = false;
                    }
                }

                removeSubMenuEvent();

            }
        }
        //Restart
        public void restartGame()
        {
            hideMenu();
            snake.removeSnake();
            gameBoard.Controls.Remove(apple);

            try
            {
                snake.snakeMovingThread.Abort();
                snake.snakeCollisionThread.Abort();
                gameThread.Abort();
            }
            catch (Exception) { }

            startGame();
        }
        //Resume
        public void resumeGame()
        {
            hideMenu();

            Thread.Sleep(500);

            snake.snakeMovingThread.Resume();
            snake.snakeCollisionThread.Resume();
            gameThread.Resume();

        }

        //Show Main Menu
        public void cleanGameBoard()
        {
            snake.removeSnake();
            gameBoard.Controls.Remove(apple);

            try
            {
                snake.snakeMovingThread.Abort();
                snake.snakeCollisionThread.Abort();
                gameThread.Abort();
            }
            catch (Exception) { }
        }
        public void showMainMenu()
        {
            //On passe à la page de jeu : gamePage et on lance la musique de fond
            playBackgroundSound("menu.mkv");

            if (gameStarted)
            {
                hideMenu();
                cleanGameBoard();

                GamePages.TabPages.Remove(gamePage);
                GamePages.Controls.Remove(gamePage);

                GamePages.TabPages.Add(menuPage);
                //GamePages.Controls.Add(menuPage);

            }

            gameStarted = false;
            mainMenuIsActive = true;
            gameMenuIsActive = false;

        }

        public PictureBox getGameBoard() { return gameBoard; }

        private void buttonMenuHover(object sender)
        {
            playSoundMenu("button_hover.wav");

            ((Label)sender).ForeColor = Color.Gold;

            if (((Label)sender).Name == "buttonExit")
                ((Label)sender).ForeColor = Color.Maroon;

            if (((Label)sender).Name == "buttonStart")
            {
                buttonStartIsFocused = true;
                buttonSettingsIsFocused = false;
                buttonExitIsFocused = false;

                buttonMenuLeave(buttonSettings);
                buttonMenuLeave(buttonExit);
            }
            else if (((Label)sender).Name == "buttonSettings")
            {
                buttonStartIsFocused = false;
                buttonSettingsIsFocused = true;
                buttonExitIsFocused = false;

                buttonMenuLeave(buttonStart);
                buttonMenuLeave(buttonExit);
            }
            else if (((Label)sender).Name == "buttonExit")
            {
                buttonStartIsFocused = false;
                buttonSettingsIsFocused = false;
                buttonExitIsFocused = true;

                buttonMenuLeave(buttonSettings);
                buttonMenuLeave(buttonStart);
            }
        }
        private void buttonMenuLeave(object sender)
        {
            ((Label)sender).ForeColor = Color.Ivory;
            switch (((Label)sender).Name)
            {
                case "buttonStart":
                    buttonStartIsFocused = false;
                    break;
                case "buttonSettings":
                    buttonSettingsIsFocused = false;
                    break;
                case "buttonExit":
                    buttonExitIsFocused = false;
                    break;
            }
        }
        private void buttonGameMenuHover(Label button)
        {
            playSoundMenu("button_hover.wav");

            button.ForeColor = Color.Gold;

            if (button.Name == "buttonRestart")
            {
                buttonRestartIsFocus = true;
                buttonMenuIsFocused = false;
                
                buttonGameMenuLeave(buttonMenu);

                if (buttonResumeIsFocused)
                {
                    buttonRestartIsFocus = false;
                    buttonMenuIsFocused = false;
                    buttonGameMenuLeave(buttonMenu);
                }
            }
            else if (button.Name == "buttonMenu")
            {
                buttonRestartIsFocus = false;
                buttonMenuIsFocused = true;

                buttonGameMenuLeave(buttonRestart);
                
            }
        }
        private void buttonGameMenuLeave(Label button)
        {
            button.ForeColor = Color.Ivory;
            switch (button.Name)
            {
                case "buttonRestart":
                    if (buttonResumeIsFocused)
                        buttonResumeIsFocused = false;
                    else
                        buttonRestartIsFocus = false;

                    break;
                case "buttonMenu":
                    buttonMenuIsFocused = false;
                    break;
            }
        }

        //Up, Down, Left, Right and Enter
        private void Up_Is_Pressed()
        {
            if (!gameStarted)
            {
                if (mainMenuIsActive)
                {
                    if (buttonSettingsIsFocused)
                    {
                        buttonMenuHover(buttonStart);
                        buttonStartIsFocused = true;

                    }else if (buttonExitIsFocused)
                    {
                        buttonMenuHover(buttonSettings);
                    }
                    else
                    {
                        buttonMenuHover(buttonStart);
                    }

                }
            }
            else if (gameMenuIsActive)
            {
                buttonGameMenuHover(buttonRestart);
            }
        }
        private void Down_Is_Pressed()
        {
            if (!gameStarted)
            {
                if (mainMenuIsActive)
                {
                    if (buttonSettingsIsFocused)
                    {
                        buttonMenuHover(buttonExit);
                    }
                    else if (buttonStartIsFocused)
                    {
                        buttonMenuHover(buttonSettings);
                    }
                    else
                    {
                        buttonMenuHover(buttonStart);
                    }
                }
            }
            else if (gameMenuIsActive)
            {
                buttonRestartIsFocus = false;
                buttonResumeIsFocused = false;
                buttonGameMenuHover(buttonMenu);
            }
        }
        private void Enter_Is_Pressed()
        {
            if (!gameStarted)
            {
                if (mainMenuIsActive)
                {
                    if (buttonExitIsFocused)
                    {
                        Application.Exit();
                    }else if (buttonStartIsFocused)
                    {
                        startGame();
                    }
                }
            }
            else if (gameMenuIsActive)
            {
                if (buttonRestartIsFocus)
                {
                    if (gameOver)
                        restartGame();
                    else
                    {
                        hideMenu();
                        showMainMenu();
                    }
                        
                }
                else if(buttonMenuIsFocused)
                {
                    hideMenu();
                    showMainMenu();
                }
                else if (buttonResumeIsFocused)
                {
                    resumeGame();
                }
            }

        }
        private void Left_Is_Pressed() {
            
        }
        private void Right_Is_Pressed() {
            
        }
        
        public void pause()
        {
            snake.snakeMovingThread.Suspend();
            snake.snakeCollisionThread.Suspend();
            gameThread.Suspend();
        }
        public void resume() {
            try
            {
                snake.snakeMovingThread.Resume();
                snake.snakeCollisionThread.Resume();
                gameThread.Resume();
            }
            catch (Exception) { }
        }
        private void Escape_Is_Pressed()
        {
            if (!gameOver && !mainMenuIsActive && !gameMenuIsActive)
            {
                buttonRestartIsFocus = false;
                buttonResumeIsFocused = true;
                buttonRestart.Text = "Continue";

                showMenu();
                pause();

            }
        }

        //Threads
        public void mainThread()
        {
            Thread.CurrentThread.Name = "mainThread";
            Thread.Sleep(1000);

            while (Thread.CurrentThread.IsAlive)
            {
                if (gameOver)
                {
                    try
                    {
                        snake.snakeMovingThread.Abort();
                        snake.snakeCollisionThread.Abort();
                        Console.WriteLine("--Game Over--");
                        Invoke(delegateShowMenu);
                        Thread.CurrentThread.Abort();
                    }
                    catch (Exception) { }
                }

                Thread.Sleep(snake.movingSpeed);
            
            }
        }

        //Update
        public void updateScore()
        {
            //Change Apple position
            snake.grow();
            apple.choosePostion(snake);

            score++;

            if (score < 10)
                scoreLabel.Text = "Score: 00" + score;
            else if (score < 100)
                scoreLabel.Text = "Score: 0" + score;
            else
                scoreLabel.Text = "Score: " + score;
            
        }
    }
}

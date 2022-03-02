namespace Snake_Game
{
    partial class GameWindows
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindows));
            this.title = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Label();
            this.buttonSettings = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Label();
            this.GamePages = new System.Windows.Forms.TabControl();
            this.menuPage = new System.Windows.Forms.TabPage();
            this.snake_totem_left = new System.Windows.Forms.PictureBox();
            this.snakeIcon = new System.Windows.Forms.PictureBox();
            this.snake_totem_right = new System.Windows.Forms.PictureBox();
            this.gamePage = new System.Windows.Forms.TabPage();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.buttonMenu = new System.Windows.Forms.Label();
            this.buttonRestart = new System.Windows.Forms.Label();
            this.gameMenuTitle = new System.Windows.Forms.Label();
            this.gameMenuBox = new System.Windows.Forms.PictureBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.snakeTitleBoard = new System.Windows.Forms.Label();
            this.snakeIconScore = new System.Windows.Forms.PictureBox();
            this.gameBoard = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.soundMenuButton = new AxWMPLib.AxWindowsMediaPlayer();
            this.soundBackground = new AxWMPLib.AxWindowsMediaPlayer();
            this.GamePages.SuspendLayout();
            this.menuPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.snake_totem_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snakeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snake_totem_right)).BeginInit();
            this.gamePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameMenuBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snakeIconScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundMenuButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Monotype Corsiva", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.title.Location = new System.Drawing.Point(258, 27);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(258, 117);
            this.title.TabIndex = 0;
            this.title.Tag = "menu";
            this.title.Text = "Snake";
            // 
            // buttonStart
            // 
            this.buttonStart.AutoSize = true;
            this.buttonStart.BackColor = System.Drawing.Color.Transparent;
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.Font = new System.Drawing.Font("Curlz MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.Color.Ivory;
            this.buttonStart.Location = new System.Drawing.Point(411, 184);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(118, 63);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Tag = "menu";
            this.buttonStart.Text = "Start";
            this.buttonStart.Click += new System.EventHandler(this.handleStartClicked);
            this.buttonStart.MouseEnter += new System.EventHandler(this.handleHoverButtonMenu);
            this.buttonStart.MouseLeave += new System.EventHandler(this.handleLeaveHoverButtonMenu);
            // 
            // buttonSettings
            // 
            this.buttonSettings.AutoSize = true;
            this.buttonSettings.BackColor = System.Drawing.Color.Transparent;
            this.buttonSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSettings.Font = new System.Drawing.Font("Curlz MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.ForeColor = System.Drawing.Color.Ivory;
            this.buttonSettings.Location = new System.Drawing.Point(376, 268);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(177, 63);
            this.buttonSettings.TabIndex = 2;
            this.buttonSettings.Tag = "menu";
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.Click += new System.EventHandler(this.handleSettingsClicked);
            this.buttonSettings.MouseEnter += new System.EventHandler(this.handleHoverButtonMenu);
            this.buttonSettings.MouseLeave += new System.EventHandler(this.handleLeaveHoverButtonMenu);
            // 
            // buttonExit
            // 
            this.buttonExit.AutoSize = true;
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.Font = new System.Drawing.Font("Curlz MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.Ivory;
            this.buttonExit.Location = new System.Drawing.Point(414, 340);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(102, 63);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Tag = "menu";
            this.buttonExit.Text = "Exit";
            this.buttonExit.Click += new System.EventHandler(this.handleExitClicked);
            this.buttonExit.MouseEnter += new System.EventHandler(this.handleHoverButtonMenu);
            this.buttonExit.MouseLeave += new System.EventHandler(this.handleLeaveHoverButtonMenu);
            // 
            // GamePages
            // 
            this.GamePages.Controls.Add(this.menuPage);
            this.GamePages.Controls.Add(this.gamePage);
            this.GamePages.Location = new System.Drawing.Point(-12, -26);
            this.GamePages.Name = "GamePages";
            this.GamePages.SelectedIndex = 0;
            this.GamePages.Size = new System.Drawing.Size(948, 558);
            this.GamePages.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.GamePages.TabIndex = 8;
            this.GamePages.TabStop = false;
            this.GamePages.Tag = "GamePages";
            this.GamePages.KeyDown += new System.Windows.Forms.KeyEventHandler(this.handleKeyDown);
            this.GamePages.KeyUp += new System.Windows.Forms.KeyEventHandler(this.handleKeyUp);
            // 
            // menuPage
            // 
            this.menuPage.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuPage.Controls.Add(this.snake_totem_left);
            this.menuPage.Controls.Add(this.title);
            this.menuPage.Controls.Add(this.snakeIcon);
            this.menuPage.Controls.Add(this.snake_totem_right);
            this.menuPage.Controls.Add(this.buttonExit);
            this.menuPage.Controls.Add(this.buttonStart);
            this.menuPage.Controls.Add(this.buttonSettings);
            this.menuPage.Location = new System.Drawing.Point(4, 22);
            this.menuPage.Name = "menuPage";
            this.menuPage.Padding = new System.Windows.Forms.Padding(3);
            this.menuPage.Size = new System.Drawing.Size(940, 507);
            this.menuPage.TabIndex = 0;
            this.menuPage.Tag = "page";
            this.menuPage.Text = "menuPage";
            // 
            // snake_totem_left
            // 
            this.snake_totem_left.Image = global::Snake_Game.Properties.Resources.snake_totem_left;
            this.snake_totem_left.Location = new System.Drawing.Point(117, 184);
            this.snake_totem_left.Name = "snake_totem_left";
            this.snake_totem_left.Size = new System.Drawing.Size(208, 245);
            this.snake_totem_left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.snake_totem_left.TabIndex = 4;
            this.snake_totem_left.TabStop = false;
            this.snake_totem_left.Tag = "menu";
            // 
            // snakeIcon
            // 
            this.snakeIcon.BackColor = System.Drawing.Color.Transparent;
            this.snakeIcon.Image = global::Snake_Game.Properties.Resources.snake_icon;
            this.snakeIcon.Location = new System.Drawing.Point(537, 38);
            this.snakeIcon.Name = "snakeIcon";
            this.snakeIcon.Size = new System.Drawing.Size(93, 92);
            this.snakeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.snakeIcon.TabIndex = 1;
            this.snakeIcon.TabStop = false;
            this.snakeIcon.Tag = "menu";
            // 
            // snake_totem_right
            // 
            this.snake_totem_right.Image = global::Snake_Game.Properties.Resources.snake_totem_right;
            this.snake_totem_right.Location = new System.Drawing.Point(606, 184);
            this.snake_totem_right.Name = "snake_totem_right";
            this.snake_totem_right.Size = new System.Drawing.Size(208, 245);
            this.snake_totem_right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.snake_totem_right.TabIndex = 5;
            this.snake_totem_right.TabStop = false;
            this.snake_totem_right.Tag = "menu";
            // 
            // gamePage
            // 
            this.gamePage.BackColor = System.Drawing.Color.Teal;
            this.gamePage.Controls.Add(this.pictureBox7);
            this.gamePage.Controls.Add(this.pictureBox6);
            this.gamePage.Controls.Add(this.pictureBox5);
            this.gamePage.Controls.Add(this.pictureBox4);
            this.gamePage.Controls.Add(this.pictureBox3);
            this.gamePage.Controls.Add(this.buttonMenu);
            this.gamePage.Controls.Add(this.buttonRestart);
            this.gamePage.Controls.Add(this.gameMenuTitle);
            this.gamePage.Controls.Add(this.gameMenuBox);
            this.gamePage.Controls.Add(this.scoreLabel);
            this.gamePage.Controls.Add(this.snakeTitleBoard);
            this.gamePage.Controls.Add(this.snakeIconScore);
            this.gamePage.Controls.Add(this.gameBoard);
            this.gamePage.Controls.Add(this.pictureBox2);
            this.gamePage.Controls.Add(this.pictureBox1);
            this.gamePage.Location = new System.Drawing.Point(4, 22);
            this.gamePage.Name = "gamePage";
            this.gamePage.Padding = new System.Windows.Forms.Padding(3);
            this.gamePage.Size = new System.Drawing.Size(940, 532);
            this.gamePage.TabIndex = 2;
            this.gamePage.Text = "gamePage";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Silver;
            this.pictureBox7.Image = global::Snake_Game.Properties.Resources.snake_totem;
            this.pictureBox7.Location = new System.Drawing.Point(367, 238);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(52, 71);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 19;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "gameMenu";
            this.pictureBox7.Visible = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Silver;
            this.pictureBox6.Image = global::Snake_Game.Properties.Resources.apple;
            this.pictureBox6.Location = new System.Drawing.Point(314, 339);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 30);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "gameMenu";
            this.pictureBox6.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Silver;
            this.pictureBox5.Image = global::Snake_Game.Properties.Resources.apple;
            this.pictureBox5.Location = new System.Drawing.Point(591, 339);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "gameMenu";
            this.pictureBox5.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Silver;
            this.pictureBox4.Image = global::Snake_Game.Properties.Resources.apple;
            this.pictureBox4.Location = new System.Drawing.Point(591, 165);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "gameMenu";
            this.pictureBox4.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Silver;
            this.pictureBox3.Image = global::Snake_Game.Properties.Resources.apple;
            this.pictureBox3.Location = new System.Drawing.Point(314, 165);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "gameMenu";
            this.pictureBox3.Visible = false;
            // 
            // buttonMenu
            // 
            this.buttonMenu.AutoSize = true;
            this.buttonMenu.BackColor = System.Drawing.Color.Silver;
            this.buttonMenu.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.ForeColor = System.Drawing.Color.Ivory;
            this.buttonMenu.Location = new System.Drawing.Point(425, 282);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(137, 27);
            this.buttonMenu.TabIndex = 14;
            this.buttonMenu.Tag = "gameMenu";
            this.buttonMenu.Text = "Main menu";
            this.buttonMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonMenu.Visible = false;
            // 
            // buttonRestart
            // 
            this.buttonRestart.AutoSize = true;
            this.buttonRestart.BackColor = System.Drawing.Color.Silver;
            this.buttonRestart.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestart.ForeColor = System.Drawing.Color.Ivory;
            this.buttonRestart.Location = new System.Drawing.Point(425, 238);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(107, 27);
            this.buttonRestart.TabIndex = 13;
            this.buttonRestart.Tag = "gameMenu";
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonRestart.Visible = false;
            // 
            // gameMenuTitle
            // 
            this.gameMenuTitle.AutoSize = true;
            this.gameMenuTitle.BackColor = System.Drawing.Color.Ivory;
            this.gameMenuTitle.Font = new System.Drawing.Font("Snap ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameMenuTitle.ForeColor = System.Drawing.Color.Maroon;
            this.gameMenuTitle.Location = new System.Drawing.Point(387, 165);
            this.gameMenuTitle.Name = "gameMenuTitle";
            this.gameMenuTitle.Padding = new System.Windows.Forms.Padding(5);
            this.gameMenuTitle.Size = new System.Drawing.Size(172, 45);
            this.gameMenuTitle.TabIndex = 12;
            this.gameMenuTitle.Tag = "gameMenu";
            this.gameMenuTitle.Text = "Try again";
            this.gameMenuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameMenuTitle.Visible = false;
            // 
            // gameMenuBox
            // 
            this.gameMenuBox.BackColor = System.Drawing.Color.Silver;
            this.gameMenuBox.Location = new System.Drawing.Point(305, 156);
            this.gameMenuBox.Name = "gameMenuBox";
            this.gameMenuBox.Size = new System.Drawing.Size(326, 225);
            this.gameMenuBox.TabIndex = 11;
            this.gameMenuBox.TabStop = false;
            this.gameMenuBox.Tag = "gameMenu";
            this.gameMenuBox.Visible = false;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.Aquamarine;
            this.scoreLabel.Location = new System.Drawing.Point(675, 18);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(127, 27);
            this.scoreLabel.TabIndex = 10;
            this.scoreLabel.Tag = "gameItem";
            this.scoreLabel.Text = "Score : 000";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // snakeTitleBoard
            // 
            this.snakeTitleBoard.AutoSize = true;
            this.snakeTitleBoard.BackColor = System.Drawing.Color.Transparent;
            this.snakeTitleBoard.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snakeTitleBoard.ForeColor = System.Drawing.Color.Gold;
            this.snakeTitleBoard.Location = new System.Drawing.Point(297, 3);
            this.snakeTitleBoard.Name = "snakeTitleBoard";
            this.snakeTitleBoard.Size = new System.Drawing.Size(334, 45);
            this.snakeTitleBoard.TabIndex = 8;
            this.snakeTitleBoard.Tag = "gameItem";
            this.snakeTitleBoard.Text = "\" Eat Until You Die! \"";
            // 
            // snakeIconScore
            // 
            this.snakeIconScore.BackColor = System.Drawing.Color.Transparent;
            this.snakeIconScore.Image = global::Snake_Game.Properties.Resources.apple;
            this.snakeIconScore.Location = new System.Drawing.Point(800, 14);
            this.snakeIconScore.Name = "snakeIconScore";
            this.snakeIconScore.Size = new System.Drawing.Size(30, 30);
            this.snakeIconScore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.snakeIconScore.TabIndex = 9;
            this.snakeIconScore.TabStop = false;
            this.snakeIconScore.Tag = "gameItem";
            // 
            // gameBoard
            // 
            this.gameBoard.BackColor = System.Drawing.Color.Aquamarine;
            this.gameBoard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gameBoard.Location = new System.Drawing.Point(79, 48);
            this.gameBoard.Name = "gameBoard";
            this.gameBoard.Size = new System.Drawing.Size(750, 450);
            this.gameBoard.TabIndex = 7;
            this.gameBoard.TabStop = false;
            this.gameBoard.Tag = "gameItem";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Snake_Game.Properties.Resources.snake_totem_right;
            this.pictureBox2.Location = new System.Drawing.Point(745, 120);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 300);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "gameItem";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Snake_Game.Properties.Resources.snake_totem_left;
            this.pictureBox1.Location = new System.Drawing.Point(20, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "gameItem";
            // 
            // soundMenuButton
            // 
            this.soundMenuButton.Enabled = true;
            this.soundMenuButton.Location = new System.Drawing.Point(359, 316);
            this.soundMenuButton.Name = "soundMenuButton";
            this.soundMenuButton.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("soundMenuButton.OcxState")));
            this.soundMenuButton.Size = new System.Drawing.Size(0, 0);
            this.soundMenuButton.TabIndex = 7;
            this.soundMenuButton.Tag = "menu_sound";
            this.soundMenuButton.Visible = false;
            // 
            // soundBackground
            // 
            this.soundBackground.Enabled = true;
            this.soundBackground.Location = new System.Drawing.Point(12, 12);
            this.soundBackground.Name = "soundBackground";
            this.soundBackground.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("soundBackground.OcxState")));
            this.soundBackground.Size = new System.Drawing.Size(0, 0);
            this.soundBackground.TabIndex = 6;
            this.soundBackground.Tag = "background_music";
            this.soundBackground.Visible = false;
            // 
            // GameWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(914, 509);
            this.Controls.Add(this.GamePages);
            this.Controls.Add(this.soundMenuButton);
            this.Controls.Add(this.soundBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GameWindows";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake Game - SterDevs";
            this.Load += new System.EventHandler(this.Game_Load);
            this.GamePages.ResumeLayout(false);
            this.menuPage.ResumeLayout(false);
            this.menuPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.snake_totem_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snakeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snake_totem_right)).EndInit();
            this.gamePage.ResumeLayout(false);
            this.gamePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameMenuBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snakeIconScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundMenuButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox snakeIcon;
        private System.Windows.Forms.Label buttonStart;
        private System.Windows.Forms.Label buttonSettings;
        private System.Windows.Forms.Label buttonExit;
        private System.Windows.Forms.PictureBox snake_totem_left;
        private System.Windows.Forms.PictureBox snake_totem_right;
        private AxWMPLib.AxWindowsMediaPlayer soundBackground;
        private AxWMPLib.AxWindowsMediaPlayer soundMenuButton;
        private System.Windows.Forms.TabControl GamePages;
        private System.Windows.Forms.TabPage menuPage;
        private System.Windows.Forms.TabPage gamePage;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label snakeTitleBoard;
        private System.Windows.Forms.PictureBox snakeIconScore;
        private System.Windows.Forms.PictureBox gameBoard;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label buttonMenu;
        private System.Windows.Forms.Label buttonRestart;
        private System.Windows.Forms.Label gameMenuTitle;
        private System.Windows.Forms.PictureBox gameMenuBox;
    }
}


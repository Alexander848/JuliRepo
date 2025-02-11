namespace SnakeGame
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnStartGame = new Button();
            btnSettings = new Button();
            btnExitGame = new Button();
            SuspendLayout();
            // 
            // btnStartGame
            // 
            btnStartGame.Location = new Point(GUIData.WindowSize.Width / 40, GUIData.WindowSize.Height / 40);
            btnStartGame.Name = "btnStartGame";
            btnStartGame.Size = new Size(GUIData.WindowSize.Width - (GUIData.WindowSize.Width / 20), GUIData.WindowSize.Height * 12 / 40);
            btnStartGame.TabIndex = 0;
            btnStartGame.Text = "Start Game";
            btnStartGame.Font = new Font(btnStartGame.Font.FontFamily, GUIData.WindowSize.Height / 27, FontStyle.Bold);
            btnStartGame.UseVisualStyleBackColor = true;
            btnStartGame.Click += btnStartGame_Click;
            // 
            // btnSettings
            // 
            btnSettings.Location = new Point(GUIData.WindowSize.Width / 40, GUIData.WindowSize.Height * 14 / 40);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(GUIData.WindowSize.Width - (GUIData.WindowSize.Width / 20), GUIData.WindowSize.Height * 12 / 40);
            btnSettings.TabIndex = 1;
            btnSettings.Text = "Settings";
            btnSettings.Font = new Font(btnSettings.Font.FontFamily, GUIData.WindowSize.Height / 27, FontStyle.Bold);
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // btn_exit_game
            // 
            btnExitGame.Location = new Point(GUIData.WindowSize.Width / 40, GUIData.WindowSize.Height * 27 / 40);
            btnExitGame.Name = "btnExitGame";
            btnExitGame.Size = new Size(GUIData.WindowSize.Width - (GUIData.WindowSize.Width / 20), GUIData.WindowSize.Height * 12 / 40);
            btnExitGame.TabIndex = 2;
            btnExitGame.Text = "Exit Game";
            btnExitGame.Font = new Font(btnExitGame.Font.FontFamily, GUIData.WindowSize.Height/27, FontStyle.Bold);
            btnExitGame.UseVisualStyleBackColor = true;
            btnExitGame.Click += btn_exit_game_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 536);
            Controls.Add(btnExitGame);
            Controls.Add(btnSettings);
            Controls.Add(btnStartGame);
            Name = "MainMenu";
            Text = "Snake";
            Activated += MainMenu_Activated;
            ResumeLayout(false);
        }

        #endregion

        private Button btnStartGame;
        private Button btnSettings;
        private Button btnExitGame;
    }
}
namespace SnakeGame
{
    partial class GameOverForm
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
            btnMainMenu = new Button();
            btnNewGame = new Button();
            lblGameOver = new Label();
            SuspendLayout();
            // 
            // lblGameOver
            // 
            lblGameOver.AutoSize = false;
            lblGameOver.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGameOver.Location = new Point(GUIData.WindowSize.Width / 40, GUIData.WindowSize.Height / 40);
            lblGameOver.Name = "lblGameOver";
            lblGameOver.Size = new Size(GUIData.WindowSize.Width - (GUIData.WindowSize.Width / 20), GUIData.WindowSize.Height * 12 / 40);
            lblGameOver.TabIndex = 3;
            lblGameOver.Text = "Game Over";
            lblGameOver.Font = new Font(lblGameOver.Font.FontFamily, GUIData.WindowSize.Height / 18, FontStyle.Bold);
            lblGameOver.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNewGame
            // 
            btnNewGame.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewGame.Location = new Point(GUIData.WindowSize.Width / 40, GUIData.WindowSize.Height * 14 / 40);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(GUIData.WindowSize.Width - (GUIData.WindowSize.Width / 20), GUIData.WindowSize.Height * 12 / 40);
            btnNewGame.TabIndex = 4;
            btnNewGame.Text = "New Game";
            btnNewGame.Font = new Font(btnNewGame.Font.FontFamily, GUIData.WindowSize.Height / 27, FontStyle.Bold);
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // btnMainMenu
            // 
            btnMainMenu.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMainMenu.Location = new Point(GUIData.WindowSize.Width / 40, GUIData.WindowSize.Height * 27 / 40);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(GUIData.WindowSize.Width - (GUIData.WindowSize.Width / 20), GUIData.WindowSize.Height * 12 / 40);
            btnMainMenu.TabIndex = 5;
            btnMainMenu.Text = "Main Menu";
            btnMainMenu.Font = new Font(btnMainMenu.Font.FontFamily, GUIData.WindowSize.Height / 27, FontStyle.Bold);
            btnMainMenu.UseVisualStyleBackColor = true;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // GameOverForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = GUIData.WindowSize;
            Controls.Add(btnMainMenu);
            Controls.Add(btnNewGame);
            Controls.Add(lblGameOver);
            Name = "GameOverForm";
            Text = "Game Over";
            Load += GameOverForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMainMenu;
        private Button btnNewGame;
        private Label lblGameOver;
    }
}
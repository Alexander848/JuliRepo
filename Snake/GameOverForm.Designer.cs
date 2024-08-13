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
            // btnMainMenu
            // 
            btnMainMenu.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMainMenu.Location = new Point(158, 163);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(169, 65);
            btnMainMenu.TabIndex = 5;
            btnMainMenu.Text = "Main Menu";
            btnMainMenu.UseVisualStyleBackColor = true;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // btnNewGame
            // 
            btnNewGame.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewGame.Location = new Point(158, 92);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(169, 65);
            btnNewGame.TabIndex = 4;
            btnNewGame.Text = "New Game";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // lblGameOver
            // 
            lblGameOver.AutoSize = true;
            lblGameOver.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGameOver.Location = new Point(148, 21);
            lblGameOver.Name = "lblGameOver";
            lblGameOver.Size = new Size(186, 45);
            lblGameOver.TabIndex = 3;
            lblGameOver.Text = "Game Over";
            // 
            // GameOverForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(guiData.GetPauseFormFrameWidth(), guiData.GetPauseFormFrameHeight());
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
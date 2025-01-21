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
            label1 = new Label();
            SuspendLayout();
            // 
            // btnStartGame
            // 
            btnStartGame.Location = new Point(220, 80);
            btnStartGame.Name = "btnStartGame";
            btnStartGame.Size = new Size(250, 150);
            btnStartGame.TabIndex = 0;
            btnStartGame.Text = "Start Game";
            btnStartGame.UseVisualStyleBackColor = true;
            btnStartGame.Click += btnStartGame_Click;
            // 
            // btnSettings
            // 
            btnSettings.Location = new Point(220, 250);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(250, 150);
            btnSettings.TabIndex = 1;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(495, 192);
            label1.Name = "label1";
            label1.Size = new Size(337, 15);
            label1.TabIndex = 2;
            label1.Text = "TODO Implement Fullscreen everywhere, implement game size";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 536);
            Controls.Add(label1);
            Controls.Add(btnSettings);
            Controls.Add(btnStartGame);
            Name = "MainMenu";
            Text = "Snake";
            Activated += MainMenu_Activated;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStartGame;
        private Button btnSettings;
        private Label label1;
    }
}
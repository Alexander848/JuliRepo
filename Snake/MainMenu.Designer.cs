﻿namespace SnakeGame
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
            SuspendLayout();
            // 
            // btnStartGame
            // 
            btnStartGame.Location = new Point(217, 84);
            btnStartGame.Name = "btnStartGame";
            btnStartGame.Size = new Size(350, 187);
            btnStartGame.TabIndex = 0;
            btnStartGame.Text = "Start Game";
            btnStartGame.UseVisualStyleBackColor = true;
            btnStartGame.Click += btnStartGame_Click;
            // 
            // btnSettings
            // 
            btnSettings.Location = new Point(217, 293);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(347, 128);
            btnSettings.TabIndex = 1;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSettings);
            Controls.Add(btnStartGame);
            Name = "MainMenu";
            Text = "Snake";
            Load += MainMenu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnStartGame;
        private Button btnSettings;
    }
}
namespace SnakeGame
{
    partial class PauseForm
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
            lblGamePaused = new Label();
            btnContinue = new Button();
            btnMainMenu = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            lblGamePaused.AutoSize = false;
            lblGamePaused.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGamePaused.Location = new Point(guiData.GetPauseFormFrameWidth() / 40, guiData.GetPauseFormFrameHeight() / 40);
            lblGamePaused.Name = "label1";
            lblGamePaused.Size = new Size(guiData.GetPauseFormFrameWidth() - (guiData.GetPauseFormFrameWidth() / 20), guiData.GetPauseFormFrameHeight() * 12 / 40);
            lblGamePaused.TabIndex = 0;
            lblGamePaused.Text = "Game Paused";
            lblGamePaused.Font = new Font(lblGamePaused.Font.FontFamily, guiData.GetPauseFormFrameHeight() / 18, FontStyle.Bold);
            lblGamePaused.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnContinue
            // 
            btnContinue.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnContinue.Location = new Point(guiData.GetPauseFormFrameWidth() / 40, guiData.GetPauseFormFrameHeight() * 14 / 40);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(guiData.GetPauseFormFrameWidth() - (guiData.GetPauseFormFrameWidth() / 20), guiData.GetPauseFormFrameHeight() * 12 / 40);
            btnContinue.TabIndex = 1;
            btnContinue.Text = "Continue";
            btnContinue.Font = new Font(btnContinue.Font.FontFamily, guiData.GetPauseFormFrameHeight() / 27, FontStyle.Bold);
            btnContinue.UseVisualStyleBackColor = true;
            btnContinue.Click += btnContinue_Click;
            // 
            // btnMainMenu
            // 
            btnMainMenu.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMainMenu.Location = new Point(guiData.GetPauseFormFrameWidth() / 40, guiData.GetPauseFormFrameHeight() * 27 / 40);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(guiData.GetPauseFormFrameWidth() - (guiData.GetPauseFormFrameWidth() / 20), guiData.GetPauseFormFrameHeight() * 12 / 40);
            btnMainMenu.TabIndex = 2;
            btnMainMenu.Text = "Main Menu";
            btnMainMenu.Font = new Font(btnMainMenu.Font.FontFamily, guiData.GetPauseFormFrameHeight() / 27, FontStyle.Bold);
            btnMainMenu.UseVisualStyleBackColor = true;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // PauseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(guiData.GetPauseFormFrameWidth(), guiData.GetPauseFormFrameHeight());
            Controls.Add(btnMainMenu);
            Controls.Add(btnContinue);
            Controls.Add(lblGamePaused);
            Name = "PauseForm";
            Text = "Pause";
            Load += PauseForm_Load;
            Activated += PauseForm_Activated;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGamePaused;
        private Button btnContinue;
        private Button btnMainMenu;
    }
}
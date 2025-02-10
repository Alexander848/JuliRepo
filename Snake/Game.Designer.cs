namespace SnakeGame
{
    partial class Game
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
            lblScoreName = new Label();
            lblScoreValue = new Label();
            btnPause = new Button();
            SuspendLayout();
            // 
            // lblScoreName
            // 
            lblScoreName.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScoreName.Size = new Size(guiData.GameFrameSize.Width / 5, (GUIData.WindowSize.Height / 23) * 2);
            lblScoreName.Location = new Point(guiData.GameFrameSize.Width / 10, (GUIData.WindowSize.Height/46) * 41);
            lblScoreName.Name = "lblScoreName";
            lblScoreName.TabIndex = 0;
            lblScoreName.Text = "Score";
            lblScoreName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblScoreValue
            // 
            lblScoreValue.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScoreValue.Size = new Size(guiData.GameFrameSize.Width / 10, (GUIData.WindowSize.Height / 23) * 2);
            lblScoreValue.Location = new Point(3*(guiData.GameFrameSize.Width / 10), (GUIData.WindowSize.Height / 46) * 41);
            lblScoreValue.Name = "lblScoreValue";
            lblScoreValue.TabIndex = 1;
            lblScoreValue.Text = "0";
            lblScoreValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnPause
            // 
            btnPause.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPause.Size = new Size(guiData.GameFrameSize.Width / 5, (GUIData.WindowSize.Height/23) * 2);
            btnPause.Location = new Point(7*(guiData.GameFrameSize.Width / 10), (GUIData.WindowSize.Height / 46) * 41);
            btnPause.Name = "btnPause";
            btnPause.TabIndex = 2;
            btnPause.Text = "Pause";
            btnPause.TextImageRelation = TextImageRelation.TextAboveImage;
            btnPause.UseVisualStyleBackColor = true;
            btnPause.Click += btnPause_Click;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 261);
            Controls.Add(btnPause);
            Controls.Add(lblScoreValue);
            Controls.Add(lblScoreName);
            BackColor = Color.White;
            KeyPreview = true;
            Name = "Game";
            Text = "Snake";
            Load += Game_Load;
            Shown += Game_Shown;
            KeyDown += Game_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblScoreName;
        private Label lblScoreValue;
        private Button btnPause;
    }
}
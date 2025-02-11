namespace SnakeGame
{
    partial class DifficultyForm
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
            lblSelectDiff = new Label();
            btnDiffEasy = new Button();
            btnDiffMedium = new Button();
            btnDiffHard = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblSelectDiff
            // 
            lblSelectDiff.AutoSize = false;
            lblSelectDiff.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectDiff.Location = new Point(GUIData.WindowSize.Width / 40, GUIData.WindowSize.Height / 40);
            lblSelectDiff.Name = "lblSelectDiff";
            lblSelectDiff.Size = new Size(GUIData.WindowSize.Width - (GUIData.WindowSize.Width / 20), GUIData.WindowSize.Height * 9 / 40);
            lblSelectDiff.TabIndex = 0;
            lblSelectDiff.Text = "Select a Difficulty";
            lblSelectDiff.Font = new Font(lblSelectDiff.Font.FontFamily, GUIData.WindowSize.Height / 18, FontStyle.Bold);
            lblSelectDiff.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDiffEasy
            // 
            btnDiffEasy.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDiffEasy.Location = new Point(GUIData.WindowSize.Width / 40, GUIData.WindowSize.Height * 22 / 80);
            btnDiffEasy.Name = "btnDiffEasy";
            btnDiffEasy.Size = new Size(GUIData.WindowSize.Width - (GUIData.WindowSize.Width / 20), GUIData.WindowSize.Height * 6 / 40);
            btnDiffEasy.TabIndex = 1;
            btnDiffEasy.Text = "Easy";
            btnDiffEasy.Font = new Font(btnDiffEasy.Font.FontFamily, GUIData.WindowSize.Height / 27, FontStyle.Bold);
            btnDiffEasy.UseVisualStyleBackColor = true;
            btnDiffEasy.Click += btnDiffEasy_Click;
            // 
            // btnDiffMedium
            // 
            btnDiffMedium.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDiffMedium.Location = new Point(GUIData.WindowSize.Width / 40, GUIData.WindowSize.Height * 36 / 80);
            btnDiffMedium.Name = "btnDiffMedium";
            btnDiffMedium.Size = new Size(GUIData.WindowSize.Width - (GUIData.WindowSize.Width / 20), GUIData.WindowSize.Height * 6 / 40);
            btnDiffMedium.TabIndex = 2;
            btnDiffMedium.Text = "Medium";
            btnDiffMedium.Font = new Font(btnDiffMedium.Font.FontFamily, GUIData.WindowSize.Height / 27, FontStyle.Bold);
            btnDiffMedium.UseVisualStyleBackColor = true;
            btnDiffMedium.Click += btnDiffMedium_Click;
            // 
            // btnDiffHard
            // 
            btnDiffHard.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDiffHard.Location = new Point(GUIData.WindowSize.Width / 40, GUIData.WindowSize.Height * 50 / 80);
            btnDiffHard.Name = "btnDiffHard";
            btnDiffHard.Size = new Size(GUIData.WindowSize.Width - (GUIData.WindowSize.Width / 20), GUIData.WindowSize.Height * 6 / 40);
            btnDiffHard.TabIndex = 3;
            btnDiffHard.Text = "Hard";
            btnDiffHard.Font = new Font(btnDiffHard.Font.FontFamily, GUIData.WindowSize.Height / 27, FontStyle.Bold);
            btnDiffHard.UseVisualStyleBackColor = true;
            btnDiffHard.Click += btnDiffHard_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(GUIData.WindowSize.Width / 40, GUIData.WindowSize.Height * 64 / 80);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(GUIData.WindowSize.Width - (GUIData.WindowSize.Width / 20), GUIData.WindowSize.Height * 6 / 40);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.Font = new Font(btnBack.Font.FontFamily, GUIData.WindowSize.Height / 27, FontStyle.Bold);
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // DifficultyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnBack);
            Controls.Add(btnDiffHard);
            Controls.Add(btnDiffMedium);
            Controls.Add(btnDiffEasy);
            Controls.Add(lblSelectDiff);
            Name = "DifficultyForm";
            Text = "DifficultyForm";
            Activated += DifficultyForm_Activated;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSelectDiff;
        private Button btnDiffEasy;
        private Button btnDiffMedium;
        private Button btnDiffHard;
        private Button btnBack;
    }
}
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
            SuspendLayout();
            // 
            // lblSelectDiff
            // 
            lblSelectDiff.AutoSize = true;
            lblSelectDiff.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectDiff.Location = new Point(52, 19);
            lblSelectDiff.Name = "lblSelectDiff";
            lblSelectDiff.Size = new Size(185, 30);
            lblSelectDiff.TabIndex = 0;
            lblSelectDiff.Text = "Select a Difficulty";
            lblSelectDiff.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDiffEasy
            // 
            btnDiffEasy.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDiffEasy.Location = new Point(74, 69);
            btnDiffEasy.Name = "btnDiffEasy";
            btnDiffEasy.Size = new Size(135, 39);
            btnDiffEasy.TabIndex = 1;
            btnDiffEasy.Text = "Easy";
            btnDiffEasy.UseVisualStyleBackColor = true;
            btnDiffEasy.Click += btnDiffEasy_Click;
            // 
            // btnDiffMedium
            // 
            btnDiffMedium.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDiffMedium.Location = new Point(74, 124);
            btnDiffMedium.Name = "btnDiffMedium";
            btnDiffMedium.Size = new Size(135, 39);
            btnDiffMedium.TabIndex = 2;
            btnDiffMedium.Text = "Medium";
            btnDiffMedium.UseVisualStyleBackColor = true;
            btnDiffMedium.Click += btnDiffMedium_Click;
            // 
            // btnDiffHard
            // 
            btnDiffHard.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDiffHard.Location = new Point(74, 178);
            btnDiffHard.Name = "btnDiffHard";
            btnDiffHard.Size = new Size(135, 39);
            btnDiffHard.TabIndex = 3;
            btnDiffHard.Text = "Hard";
            btnDiffHard.UseVisualStyleBackColor = true;
            btnDiffHard.Click += btnDiffHard_Click;
            // 
            // DifficultyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 261);
            Controls.Add(btnDiffHard);
            Controls.Add(btnDiffMedium);
            Controls.Add(btnDiffEasy);
            Controls.Add(lblSelectDiff);
            Name = "DifficultyForm";
            Text = "DifficultyForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSelectDiff;
        private Button btnDiffEasy;
        private Button btnDiffMedium;
        private Button btnDiffHard;
    }
}
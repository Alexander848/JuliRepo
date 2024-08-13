namespace SnakeGame
{
    partial class Settings
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
            lblResolution = new Label();
            SuspendLayout();
            // 
            // lblResolution
            // 
            lblResolution.AutoSize = true;
            lblResolution.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResolution.Location = new Point(313, 105);
            lblResolution.Name = "lblResolution";
            lblResolution.Size = new Size(161, 32);
            lblResolution.TabIndex = 1;
            lblResolution.Text = "Window Size";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResolution);
            Name = "Settings";
            Text = "Settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblResolution;
    }
}
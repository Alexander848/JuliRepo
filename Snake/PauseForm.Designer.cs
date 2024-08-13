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
            label1 = new Label();
            btnContinue = new Button();
            btnMainMenu = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(125, 25);
            label1.Name = "label1";
            label1.Size = new Size(221, 45);
            label1.TabIndex = 0;
            label1.Text = "Game Paused";
            // 
            // btnContinue
            // 
            btnContinue.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnContinue.Location = new Point(153, 84);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(169, 65);
            btnContinue.TabIndex = 1;
            btnContinue.Text = "Continue";
            btnContinue.UseVisualStyleBackColor = true;
            btnContinue.Click += btnContinue_Click;
            // 
            // btnMainMenu
            // 
            btnMainMenu.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMainMenu.Location = new Point(153, 155);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(169, 65);
            btnMainMenu.TabIndex = 2;
            btnMainMenu.Text = "Main Menu";
            btnMainMenu.UseVisualStyleBackColor = true;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // PauseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 283);
            Controls.Add(btnMainMenu);
            Controls.Add(btnContinue);
            Controls.Add(label1);
            Name = "PauseForm";
            Text = "PauseForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnContinue;
        private Button btnMainMenu;
    }
}
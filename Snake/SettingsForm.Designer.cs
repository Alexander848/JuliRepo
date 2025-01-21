namespace SnakeGame
{
    partial class SettingsForm
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
            cBoxScreenSize = new ComboBox();
            lblScreenSize = new Label();
            btnBack = new Button();
            btnSave = new Button();
            radioWindowed = new RadioButton();
            radioFullscreen = new RadioButton();
            groupBoxWindow = new GroupBox();
            groupBoxWindow.SuspendLayout();
            SuspendLayout();
            // 
            // cBoxScreenSize
            // 
            cBoxScreenSize.FormattingEnabled = true;
            cBoxScreenSize.Items.AddRange(new object[] { "800 x 460", "1200 x 690", "1600 x 920" });
            cBoxScreenSize.Location = new Point(251, 102);
            cBoxScreenSize.Name = "cBoxScreenSize";
            cBoxScreenSize.Size = new Size(232, 23);
            cBoxScreenSize.TabIndex = 0;
            cBoxScreenSize.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // lblScreenSize
            // 
            lblScreenSize.AutoSize = true;
            lblScreenSize.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScreenSize.Location = new Point(251, 62);
            lblScreenSize.Name = "lblScreenSize";
            lblScreenSize.Size = new Size(112, 25);
            lblScreenSize.TabIndex = 1;
            lblScreenSize.Text = "Screen Size";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(71, 381);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(106, 68);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.TextImageRelation = TextImageRelation.ImageAboveText;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(558, 270);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(114, 80);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.UseWaitCursor = true;
            btnSave.Click += btnSave_Click;
            // 
            // radioWindowed
            // 
            radioWindowed.AutoSize = true;
            radioWindowed.Location = new Point(18, 47);
            radioWindowed.Name = "radioWindowed";
            radioWindowed.Size = new Size(82, 19);
            radioWindowed.TabIndex = 1;
            radioWindowed.TabStop = true;
            radioWindowed.Text = "Windowed";
            radioWindowed.UseVisualStyleBackColor = true;
            radioWindowed.Checked = true;
            // 
            // radioFullscreen
            // 
            radioFullscreen.AutoSize = true;
            radioFullscreen.Location = new Point(18, 22);
            radioFullscreen.Name = "radioFullscreen";
            radioFullscreen.Size = new Size(78, 19);
            radioFullscreen.TabIndex = 0;
            radioFullscreen.TabStop = true;
            radioFullscreen.Text = "Fullscreen";
            radioFullscreen.UseVisualStyleBackColor = true;
            // 
            // groupBoxWindow
            // 
            groupBoxWindow.Controls.Add(radioFullscreen);
            groupBoxWindow.Controls.Add(radioWindowed);
            groupBoxWindow.Location = new Point(88, 62);
            groupBoxWindow.Name = "groupBoxWindow";
            groupBoxWindow.Size = new Size(124, 78);
            groupBoxWindow.TabIndex = 4;
            groupBoxWindow.TabStop = false;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 452);
            Controls.Add(groupBoxWindow);
            Controls.Add(btnSave);
            Controls.Add(btnBack);
            Controls.Add(lblScreenSize);
            Controls.Add(cBoxScreenSize);
            Name = "SettingsForm";
            Text = "Settings";
            Activated += SettingsForm_Activate;
            groupBoxWindow.ResumeLayout(false);
            groupBoxWindow.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cBoxScreenSize;
        private Label lblScreenSize;
        private Button btnBack;
        private Button btnSave;
        private RadioButton radioWindowed;
        private RadioButton radioFullscreen;
        private GroupBox groupBoxWindow;
    }
}
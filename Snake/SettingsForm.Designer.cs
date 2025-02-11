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
            cBoxScreenSize.Location = new Point(GUIData.WindowSize.Width * 21 / 80, GUIData.WindowSize.Height * 3 / 80);
            cBoxScreenSize.Name = "cBoxScreenSize";
            cBoxScreenSize.Size = new Size(GUIData.WindowSize.Width * 17 / 80, GUIData.WindowSize.Height * 5 / 40);
            cBoxScreenSize.TabIndex = 0;
            cBoxScreenSize.Font = new Font(cBoxScreenSize.Font.FontFamily, GUIData.WindowSize.Height / 24, FontStyle.Bold);
            cBoxScreenSize.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(GUIData.WindowSize.Width / 40, GUIData.WindowSize.Height * 14 / 40);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(GUIData.WindowSize.Width - (GUIData.WindowSize.Width / 20), GUIData.WindowSize.Height * 12 / 40);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.Font = new Font(btnBack.Font.FontFamily, GUIData.WindowSize.Height / 27, FontStyle.Bold);
            btnBack.TextImageRelation = TextImageRelation.ImageAboveText;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(GUIData.WindowSize.Width / 40, GUIData.WindowSize.Height * 27 / 40);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(GUIData.WindowSize.Width - (GUIData.WindowSize.Width / 20), GUIData.WindowSize.Height * 12 / 40);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.Font = new Font(btnSave.Font.FontFamily, GUIData.WindowSize.Height / 27, FontStyle.Bold);
            btnSave.UseVisualStyleBackColor = true;
            btnSave.UseWaitCursor = true;
            btnSave.Click += btnSave_Click;
            // 
            // radioWindowed
            // 
            radioWindowed.AutoSize = true;
            radioWindowed.Location = new Point(GUIData.WindowSize.Width / 80, GUIData.WindowSize.Height / 80);
            radioWindowed.Name = "radioWindowed";
            radioWindowed.Size = new Size(GUIData.WindowSize.Width * 17 / 80, GUIData.WindowSize.Height * 5 / 40);
            radioWindowed.TabIndex = 1;
            radioWindowed.TabStop = true;
            radioWindowed.Text = "Windowed";
            radioWindowed.Font = new Font(radioWindowed.Font.FontFamily, GUIData.WindowSize.Height / 27, FontStyle.Bold);
            radioWindowed.UseVisualStyleBackColor = true;
            radioWindowed.Checked = true;
            // 
            // radioFullscreen
            // 
            radioFullscreen.AutoSize = true;
            radioFullscreen.Location = new Point(GUIData.WindowSize.Width / 80, GUIData.WindowSize.Height * 6 / 40);
            radioFullscreen.Name = "radioFullscreen";
            radioFullscreen.Size = new Size(GUIData.WindowSize.Width * 17 / 80, GUIData.WindowSize.Height * 5 / 40);
            radioFullscreen.TabIndex = 0;
            radioFullscreen.TabStop = true;
            radioFullscreen.Text = "Fullscreen";
            radioFullscreen.Font = new Font(radioFullscreen.Font.FontFamily, GUIData.WindowSize.Height / 27, FontStyle.Bold);
            radioFullscreen.UseVisualStyleBackColor = true;
            // 
            // groupBoxWindow
            // 
            groupBoxWindow.Controls.Add(radioFullscreen);
            groupBoxWindow.Controls.Add(radioWindowed);
            groupBoxWindow.Location = new Point(GUIData.WindowSize.Width / 40, GUIData.WindowSize.Height / 40);
            groupBoxWindow.Name = "groupBoxWindow";
            groupBoxWindow.Size = new Size(GUIData.WindowSize.Width * 9 / 40, GUIData.WindowSize.Height * 12 / 40);
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
        private Button btnBack;
        private Button btnSave;
        private RadioButton radioWindowed;
        private RadioButton radioFullscreen;
        private GroupBox groupBoxWindow;
    }
}
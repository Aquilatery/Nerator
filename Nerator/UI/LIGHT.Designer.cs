
namespace Nerator.UI
{
    partial class LIGHT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LIGHT));
            labelEdit1 = new ReaLTaiizor.Controls.LabelEdit();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            PWDTB = new ReaLTaiizor.Controls.BigTextBox();
            poisonProgressBar1 = new ReaLTaiizor.Controls.PoisonProgressBar();
            foreverStatusBar1 = new ReaLTaiizor.Controls.ForeverStatusBar();
            CEB = new ReaLTaiizor.Controls.MaterialButton();
            CYB = new ReaLTaiizor.Controls.MaterialButton();
            materialTabControl1 = new ReaLTaiizor.Controls.MaterialTabControl();
            History = new System.Windows.Forms.TabPage();
            Generate = new System.Windows.Forms.TabPage();
            materialTabSelector1 = new ReaLTaiizor.Controls.MaterialTabSelector();
            Setting = new System.Windows.Forms.TabPage();
            HYS = new ReaLTaiizor.Controls.MaterialSwitch();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            materialTabControl1.SuspendLayout();
            Generate.SuspendLayout();
            SuspendLayout();
            // 
            // labelEdit1
            // 
            labelEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            labelEdit1.BackColor = System.Drawing.Color.Transparent;
            labelEdit1.Enabled = false;
            labelEdit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            labelEdit1.ForeColor = System.Drawing.Color.White;
            labelEdit1.Location = new System.Drawing.Point(0, 0);
            labelEdit1.Name = "labelEdit1";
            labelEdit1.Size = new System.Drawing.Size(359, 25);
            labelEdit1.TabIndex = 1;
            labelEdit1.Text = "Nerator";
            labelEdit1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Enabled = false;
            pictureBox1.Image = global::Nerator.Properties.Resources.ShowPassword;
            pictureBox1.Location = new System.Drawing.Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(25, 24);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // PWDTB
            // 
            PWDTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            PWDTB.BackColor = System.Drawing.Color.Transparent;
            PWDTB.Font = new System.Drawing.Font("Tahoma", 11F);
            PWDTB.ForeColor = System.Drawing.Color.DimGray;
            PWDTB.Image = global::Nerator.Properties.Resources.Key1;
            PWDTB.Location = new System.Drawing.Point(6, 6);
            PWDTB.MaxLength = 50;
            PWDTB.Multiline = false;
            PWDTB.Name = "PWDTB";
            PWDTB.ReadOnly = false;
            PWDTB.Size = new System.Drawing.Size(315, 41);
            PWDTB.TabIndex = 6;
            PWDTB.Text = "Nerator";
            PWDTB.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            PWDTB.UseSystemPasswordChar = false;
            // 
            // poisonProgressBar1
            // 
            poisonProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            poisonProgressBar1.Location = new System.Drawing.Point(10, 46);
            poisonProgressBar1.Name = "poisonProgressBar1";
            poisonProgressBar1.Size = new System.Drawing.Size(307, 5);
            poisonProgressBar1.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Green;
            poisonProgressBar1.TabIndex = 12;
            poisonProgressBar1.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            // 
            // foreverStatusBar1
            // 
            foreverStatusBar1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            foreverStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            foreverStatusBar1.Font = new System.Drawing.Font("Segoe UI", 8F);
            foreverStatusBar1.ForeColor = System.Drawing.Color.White;
            foreverStatusBar1.Location = new System.Drawing.Point(0, 359);
            foreverStatusBar1.Name = "foreverStatusBar1";
            foreverStatusBar1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            foreverStatusBar1.ShowTimeDate = true;
            foreverStatusBar1.Size = new System.Drawing.Size(359, 22);
            foreverStatusBar1.TabIndex = 13;
            foreverStatusBar1.Text = "foreverStatusBar1";
            foreverStatusBar1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            foreverStatusBar1.TimeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            foreverStatusBar1.TimeFormat = "HH:mm:ss";
            // 
            // CEB
            // 
            CEB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            CEB.Cursor = System.Windows.Forms.Cursors.Hand;
            CEB.Depth = 0;
            CEB.DrawShadows = true;
            CEB.HighEmphasis = true;
            CEB.Icon = global::Nerator.Properties.Resources.QuillInk;
            CEB.Location = new System.Drawing.Point(6, 56);
            CEB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            CEB.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            CEB.Name = "CEB";
            CEB.Size = new System.Drawing.Size(104, 36);
            CEB.TabIndex = 14;
            CEB.Text = "CREATE";
            CEB.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            CEB.UseAccentColor = false;
            CEB.UseVisualStyleBackColor = true;
            CEB.Click += new System.EventHandler(CEB_Click);
            // 
            // CYB
            // 
            CYB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            CYB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            CYB.Cursor = System.Windows.Forms.Cursors.Hand;
            CYB.Depth = 0;
            CYB.DrawShadows = true;
            CYB.HighEmphasis = true;
            CYB.Icon = global::Nerator.Properties.Resources.CopyClipboard;
            CYB.Location = new System.Drawing.Point(234, 56);
            CYB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            CYB.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            CYB.Name = "CYB";
            CYB.Size = new System.Drawing.Size(87, 36);
            CYB.TabIndex = 15;
            CYB.Text = "COPY";
            CYB.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            CYB.UseAccentColor = false;
            CYB.UseVisualStyleBackColor = true;
            CYB.Click += new System.EventHandler(CYB_Click);
            // 
            // materialTabControl1
            // 
            materialTabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            materialTabControl1.Controls.Add(Generate);
            materialTabControl1.Controls.Add(History);
            materialTabControl1.Controls.Add(Setting);
            materialTabControl1.Depth = 0;
            materialTabControl1.Location = new System.Drawing.Point(12, 99);
            materialTabControl1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            materialTabControl1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.Padding = new System.Drawing.Point(0, 0);
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new System.Drawing.Size(335, 227);
            materialTabControl1.TabIndex = 16;
            // 
            // History
            // 
            History.BackColor = System.Drawing.SystemColors.Control;
            History.Location = new System.Drawing.Point(4, 4);
            History.Name = "History";
            History.Padding = new System.Windows.Forms.Padding(3);
            History.Size = new System.Drawing.Size(327, 201);
            History.TabIndex = 0;
            History.Text = "History";
            // 
            // Generate
            // 
            Generate.BackColor = System.Drawing.SystemColors.Control;
            Generate.Controls.Add(HYS);
            Generate.Controls.Add(CEB);
            Generate.Controls.Add(CYB);
            Generate.Controls.Add(PWDTB);
            Generate.Controls.Add(poisonProgressBar1);
            Generate.Location = new System.Drawing.Point(4, 4);
            Generate.Name = "Generate";
            Generate.Padding = new System.Windows.Forms.Padding(3);
            Generate.Size = new System.Drawing.Size(327, 201);
            Generate.TabIndex = 1;
            Generate.Text = "Generate";
            // 
            // materialTabSelector1
            // 
            materialTabSelector1.BaseTabControl = materialTabControl1;
            materialTabSelector1.Depth = 0;
            materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialTabSelector1.HeadAlignment = ReaLTaiizor.Controls.MaterialTabSelector.Alignment.Center;
            materialTabSelector1.Location = new System.Drawing.Point(12, 76);
            materialTabSelector1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            materialTabSelector1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialTabSelector1.Name = "materialTabSelector1";
            materialTabSelector1.Size = new System.Drawing.Size(335, 23);
            materialTabSelector1.TabIndex = 17;
            materialTabSelector1.Text = "materialTabSelector1";
            materialTabSelector1.TitleTextState = ReaLTaiizor.Controls.MaterialTabSelector.TextState.Normal;
            // 
            // Setting
            // 
            Setting.BackColor = System.Drawing.SystemColors.Control;
            Setting.Location = new System.Drawing.Point(4, 4);
            Setting.Name = "Setting";
            Setting.Padding = new System.Windows.Forms.Padding(3);
            Setting.Size = new System.Drawing.Size(327, 201);
            Setting.TabIndex = 2;
            Setting.Text = "Setting";
            // 
            // HYS
            // 
            HYS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            HYS.AutoSize = true;
            HYS.Checked = true;
            HYS.CheckState = System.Windows.Forms.CheckState.Checked;
            HYS.Depth = 0;
            HYS.Location = new System.Drawing.Point(117, 57);
            HYS.Margin = new System.Windows.Forms.Padding(0);
            HYS.MouseLocation = new System.Drawing.Point(-1, -1);
            HYS.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            HYS.Name = "HYS";
            HYS.Ripple = true;
            HYS.Size = new System.Drawing.Size(108, 37);
            HYS.TabIndex = 16;
            HYS.Text = "History";
            HYS.UseAccentColor = true;
            HYS.UseVisualStyleBackColor = true;
            // 
            // LIGHT
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(359, 381);
            Controls.Add(materialTabSelector1);
            Controls.Add(materialTabControl1);
            Controls.Add(foreverStatusBar1);
            Controls.Add(pictureBox1);
            Controls.Add(labelEdit1);
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MaximizeBox = false;
            Name = "LIGHT";
            Sizable = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "New Generation Password Generator";
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            materialTabControl1.ResumeLayout(false);
            Generate.ResumeLayout(false);
            Generate.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.LabelEdit labelEdit1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.BigTextBox PWDTB;
        private ReaLTaiizor.Controls.PoisonProgressBar poisonProgressBar1;
        private ReaLTaiizor.Controls.ForeverStatusBar foreverStatusBar1;
        private ReaLTaiizor.Controls.MaterialButton CEB;
        private ReaLTaiizor.Controls.MaterialButton CYB;
        private ReaLTaiizor.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage History;
        private System.Windows.Forms.TabPage Generate;
        private ReaLTaiizor.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.TabPage Setting;
        private ReaLTaiizor.Controls.MaterialSwitch HYS;
    }
}
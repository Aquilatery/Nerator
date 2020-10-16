
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
            this.labelEdit1 = new ReaLTaiizor.Controls.LabelEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PWDTB = new ReaLTaiizor.Controls.BigTextBox();
            this.poisonProgressBar1 = new ReaLTaiizor.Controls.PoisonProgressBar();
            this.foreverStatusBar1 = new ReaLTaiizor.Controls.ForeverStatusBar();
            this.CEB = new ReaLTaiizor.Controls.MaterialButton();
            this.CYB = new ReaLTaiizor.Controls.MaterialButton();
            this.materialTabControl1 = new ReaLTaiizor.Controls.MaterialTabControl();
            this.History = new System.Windows.Forms.TabPage();
            this.Generate = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new ReaLTaiizor.Controls.MaterialTabSelector();
            this.Setting = new System.Windows.Forms.TabPage();
            this.HYS = new ReaLTaiizor.Controls.MaterialSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.materialTabControl1.SuspendLayout();
            this.Generate.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelEdit1
            // 
            this.labelEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEdit1.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit1.Enabled = false;
            this.labelEdit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelEdit1.ForeColor = System.Drawing.Color.White;
            this.labelEdit1.Location = new System.Drawing.Point(0, 0);
            this.labelEdit1.Name = "labelEdit1";
            this.labelEdit1.Size = new System.Drawing.Size(359, 25);
            this.labelEdit1.TabIndex = 1;
            this.labelEdit1.Text = "Nerator";
            this.labelEdit1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::Nerator.Properties.Resources.ShowPassword;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // PWDTB
            // 
            this.PWDTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PWDTB.BackColor = System.Drawing.Color.Transparent;
            this.PWDTB.Font = new System.Drawing.Font("Tahoma", 11F);
            this.PWDTB.ForeColor = System.Drawing.Color.DimGray;
            this.PWDTB.Image = global::Nerator.Properties.Resources.Key1;
            this.PWDTB.Location = new System.Drawing.Point(6, 6);
            this.PWDTB.MaxLength = 50;
            this.PWDTB.Multiline = false;
            this.PWDTB.Name = "PWDTB";
            this.PWDTB.ReadOnly = false;
            this.PWDTB.Size = new System.Drawing.Size(315, 41);
            this.PWDTB.TabIndex = 6;
            this.PWDTB.Text = "Nerator";
            this.PWDTB.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.PWDTB.UseSystemPasswordChar = false;
            // 
            // poisonProgressBar1
            // 
            this.poisonProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.poisonProgressBar1.Location = new System.Drawing.Point(10, 46);
            this.poisonProgressBar1.Name = "poisonProgressBar1";
            this.poisonProgressBar1.Size = new System.Drawing.Size(307, 5);
            this.poisonProgressBar1.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Green;
            this.poisonProgressBar1.TabIndex = 12;
            this.poisonProgressBar1.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            // 
            // foreverStatusBar1
            // 
            this.foreverStatusBar1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.foreverStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.foreverStatusBar1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.foreverStatusBar1.ForeColor = System.Drawing.Color.White;
            this.foreverStatusBar1.Location = new System.Drawing.Point(0, 359);
            this.foreverStatusBar1.Name = "foreverStatusBar1";
            this.foreverStatusBar1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.foreverStatusBar1.ShowTimeDate = true;
            this.foreverStatusBar1.Size = new System.Drawing.Size(359, 22);
            this.foreverStatusBar1.TabIndex = 13;
            this.foreverStatusBar1.Text = "foreverStatusBar1";
            this.foreverStatusBar1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.foreverStatusBar1.TimeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.foreverStatusBar1.TimeFormat = "HH:mm:ss";
            // 
            // CEB
            // 
            this.CEB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CEB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CEB.Depth = 0;
            this.CEB.DrawShadows = true;
            this.CEB.HighEmphasis = true;
            this.CEB.Icon = global::Nerator.Properties.Resources.QuillInk;
            this.CEB.Location = new System.Drawing.Point(6, 56);
            this.CEB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CEB.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.CEB.Name = "CEB";
            this.CEB.Size = new System.Drawing.Size(104, 36);
            this.CEB.TabIndex = 14;
            this.CEB.Text = "CREATE";
            this.CEB.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CEB.UseAccentColor = false;
            this.CEB.UseVisualStyleBackColor = true;
            this.CEB.Click += new System.EventHandler(this.CEB_Click);
            // 
            // CYB
            // 
            this.CYB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CYB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CYB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CYB.Depth = 0;
            this.CYB.DrawShadows = true;
            this.CYB.HighEmphasis = true;
            this.CYB.Icon = global::Nerator.Properties.Resources.CopyClipboard;
            this.CYB.Location = new System.Drawing.Point(234, 56);
            this.CYB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CYB.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.CYB.Name = "CYB";
            this.CYB.Size = new System.Drawing.Size(87, 36);
            this.CYB.TabIndex = 15;
            this.CYB.Text = "COPY";
            this.CYB.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CYB.UseAccentColor = false;
            this.CYB.UseVisualStyleBackColor = true;
            this.CYB.Click += new System.EventHandler(this.CYB_Click);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.materialTabControl1.Controls.Add(this.Generate);
            this.materialTabControl1.Controls.Add(this.History);
            this.materialTabControl1.Controls.Add(this.Setting);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(12, 99);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.materialTabControl1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.Padding = new System.Drawing.Point(0, 0);
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(335, 227);
            this.materialTabControl1.TabIndex = 16;
            // 
            // History
            // 
            this.History.BackColor = System.Drawing.SystemColors.Control;
            this.History.Location = new System.Drawing.Point(4, 4);
            this.History.Name = "History";
            this.History.Padding = new System.Windows.Forms.Padding(3);
            this.History.Size = new System.Drawing.Size(327, 201);
            this.History.TabIndex = 0;
            this.History.Text = "History";
            // 
            // Generate
            // 
            this.Generate.BackColor = System.Drawing.SystemColors.Control;
            this.Generate.Controls.Add(this.HYS);
            this.Generate.Controls.Add(this.CEB);
            this.Generate.Controls.Add(this.CYB);
            this.Generate.Controls.Add(this.PWDTB);
            this.Generate.Controls.Add(this.poisonProgressBar1);
            this.Generate.Location = new System.Drawing.Point(4, 4);
            this.Generate.Name = "Generate";
            this.Generate.Padding = new System.Windows.Forms.Padding(3);
            this.Generate.Size = new System.Drawing.Size(327, 201);
            this.Generate.TabIndex = 1;
            this.Generate.Text = "Generate";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.HeadAlignment = ReaLTaiizor.Controls.MaterialTabSelector.Alignment.Center;
            this.materialTabSelector1.Location = new System.Drawing.Point(12, 76);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.materialTabSelector1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(335, 23);
            this.materialTabSelector1.TabIndex = 17;
            this.materialTabSelector1.Text = "materialTabSelector1";
            this.materialTabSelector1.TitleTextState = ReaLTaiizor.Controls.MaterialTabSelector.TextState.Normal;
            // 
            // Setting
            // 
            this.Setting.BackColor = System.Drawing.SystemColors.Control;
            this.Setting.Location = new System.Drawing.Point(4, 4);
            this.Setting.Name = "Setting";
            this.Setting.Padding = new System.Windows.Forms.Padding(3);
            this.Setting.Size = new System.Drawing.Size(327, 201);
            this.Setting.TabIndex = 2;
            this.Setting.Text = "Setting";
            // 
            // HYS
            // 
            this.HYS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HYS.AutoSize = true;
            this.HYS.Checked = true;
            this.HYS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HYS.Depth = 0;
            this.HYS.Location = new System.Drawing.Point(117, 57);
            this.HYS.Margin = new System.Windows.Forms.Padding(0);
            this.HYS.MouseLocation = new System.Drawing.Point(-1, -1);
            this.HYS.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.HYS.Name = "HYS";
            this.HYS.Ripple = true;
            this.HYS.Size = new System.Drawing.Size(108, 37);
            this.HYS.TabIndex = 16;
            this.HYS.Text = "History";
            this.HYS.UseAccentColor = true;
            this.HYS.UseVisualStyleBackColor = true;
            // 
            // LIGHT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 381);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.foreverStatusBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelEdit1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LIGHT";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Generation Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.materialTabControl1.ResumeLayout(false);
            this.Generate.ResumeLayout(false);
            this.Generate.PerformLayout();
            this.ResumeLayout(false);

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
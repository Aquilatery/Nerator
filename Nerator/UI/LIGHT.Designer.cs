
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LIGHT));
            this.labelEdit1 = new ReaLTaiizor.Controls.LabelEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PWDTB = new ReaLTaiizor.Controls.BigTextBox();
            this.PLPB = new ReaLTaiizor.Controls.PoisonProgressBar();
            this.SSBR = new ReaLTaiizor.Controls.ForeverStatusBar();
            this.CEB = new ReaLTaiizor.Controls.MaterialButton();
            this.CYB = new ReaLTaiizor.Controls.MaterialButton();
            this.MTC = new ReaLTaiizor.Controls.MaterialTabControl();
            this.Generate = new System.Windows.Forms.TabPage();
            this.HYS = new ReaLTaiizor.Controls.MaterialSwitch();
            this.History = new System.Windows.Forms.TabPage();
            this.HYP = new System.Windows.Forms.Panel();
            this.Setting = new System.Windows.Forms.TabPage();
            this.MTS = new ReaLTaiizor.Controls.MaterialTabSelector();
            this.STATUST = new System.Windows.Forms.Timer(this.components);
            this.STATUSMT = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MTC.SuspendLayout();
            this.Generate.SuspendLayout();
            this.History.SuspendLayout();
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
            this.PWDTB.Image = global::Nerator.Properties.Resources.PasteSpecial;
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
            // PLPB
            // 
            this.PLPB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PLPB.Location = new System.Drawing.Point(10, 46);
            this.PLPB.Name = "PLPB";
            this.PLPB.Size = new System.Drawing.Size(307, 5);
            this.PLPB.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Green;
            this.PLPB.TabIndex = 12;
            this.PLPB.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            // 
            // SSBR
            // 
            this.SSBR.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.SSBR.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SSBR.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.SSBR.ForeColor = System.Drawing.Color.White;
            this.SSBR.Location = new System.Drawing.Point(0, 359);
            this.SSBR.Name = "SSBR";
            this.SSBR.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.SSBR.ShowTimeDate = true;
            this.SSBR.Size = new System.Drawing.Size(359, 22);
            this.SSBR.TabIndex = 13;
            this.SSBR.Text = "Uygulama işleyişi sorunsuz bir şekilde devam etmektedir.";
            this.SSBR.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SSBR.TimeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.SSBR.TimeFormat = "HH:mm:ss";
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
            // MTC
            // 
            this.MTC.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.MTC.Controls.Add(this.Generate);
            this.MTC.Controls.Add(this.History);
            this.MTC.Controls.Add(this.Setting);
            this.MTC.Depth = 0;
            this.MTC.ItemSize = new System.Drawing.Size(44, 18);
            this.MTC.Location = new System.Drawing.Point(12, 99);
            this.MTC.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.MTC.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.MTC.Multiline = true;
            this.MTC.Name = "MTC";
            this.MTC.Padding = new System.Drawing.Point(0, 0);
            this.MTC.SelectedIndex = 0;
            this.MTC.Size = new System.Drawing.Size(335, 227);
            this.MTC.TabIndex = 16;
            // 
            // Generate
            // 
            this.Generate.BackColor = System.Drawing.SystemColors.Control;
            this.Generate.Controls.Add(this.HYS);
            this.Generate.Controls.Add(this.CEB);
            this.Generate.Controls.Add(this.CYB);
            this.Generate.Controls.Add(this.PWDTB);
            this.Generate.Controls.Add(this.PLPB);
            this.Generate.Location = new System.Drawing.Point(4, 4);
            this.Generate.Name = "Generate";
            this.Generate.Padding = new System.Windows.Forms.Padding(3);
            this.Generate.Size = new System.Drawing.Size(327, 201);
            this.Generate.TabIndex = 1;
            this.Generate.Text = "Generate";
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
            // History
            // 
            this.History.BackColor = System.Drawing.SystemColors.Control;
            this.History.Controls.Add(this.HYP);
            this.History.Location = new System.Drawing.Point(4, 4);
            this.History.Name = "History";
            this.History.Padding = new System.Windows.Forms.Padding(3);
            this.History.Size = new System.Drawing.Size(327, 201);
            this.History.TabIndex = 0;
            this.History.Text = "History";
            // 
            // HYP
            // 
            this.HYP.AutoScroll = true;
            this.HYP.BackColor = System.Drawing.Color.Transparent;
            this.HYP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HYP.Location = new System.Drawing.Point(3, 3);
            this.HYP.Margin = new System.Windows.Forms.Padding(0);
            this.HYP.Name = "HYP";
            this.HYP.Size = new System.Drawing.Size(321, 195);
            this.HYP.TabIndex = 0;
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
            // MTS
            // 
            this.MTS.BaseTabControl = this.MTC;
            this.MTS.Depth = 0;
            this.MTS.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MTS.HeadAlignment = ReaLTaiizor.Controls.MaterialTabSelector.Alignment.Center;
            this.MTS.Location = new System.Drawing.Point(12, 76);
            this.MTS.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.MTS.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.MTS.Name = "MTS";
            this.MTS.Size = new System.Drawing.Size(335, 23);
            this.MTS.TabIndex = 17;
            this.MTS.Text = "materialTabSelector1";
            this.MTS.TitleTextState = ReaLTaiizor.Controls.MaterialTabSelector.TextState.Normal;
            // 
            // STATUST
            // 
            this.STATUST.Enabled = true;
            this.STATUST.Interval = 1000;
            this.STATUST.Tick += new System.EventHandler(this.STATUST_Tick);
            // 
            // STATUSMT
            // 
            this.STATUSMT.Enabled = true;
            this.STATUSMT.Interval = 50;
            this.STATUSMT.Tick += new System.EventHandler(this.STATUSMT_Tick);
            // 
            // LIGHT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(359, 381);
            this.Controls.Add(this.MTS);
            this.Controls.Add(this.MTC);
            this.Controls.Add(this.SSBR);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelEdit1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LIGHT";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Generation Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MTC.ResumeLayout(false);
            this.Generate.ResumeLayout(false);
            this.Generate.PerformLayout();
            this.History.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.LabelEdit labelEdit1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.BigTextBox PWDTB;
        private ReaLTaiizor.Controls.PoisonProgressBar PLPB;
        private ReaLTaiizor.Controls.ForeverStatusBar SSBR;
        private ReaLTaiizor.Controls.MaterialButton CEB;
        private ReaLTaiizor.Controls.MaterialButton CYB;
        private ReaLTaiizor.Controls.MaterialTabControl MTC;
        private System.Windows.Forms.TabPage History;
        private System.Windows.Forms.TabPage Generate;
        private ReaLTaiizor.Controls.MaterialTabSelector MTS;
        private System.Windows.Forms.TabPage Setting;
        private ReaLTaiizor.Controls.MaterialSwitch HYS;
        private System.Windows.Forms.Panel HYP;
        private System.Windows.Forms.Timer STATUST;
        private System.Windows.Forms.Timer STATUSMT;
    }
}
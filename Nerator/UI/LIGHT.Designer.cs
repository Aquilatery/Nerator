
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LIGHT));
            labelEdit1 = new ReaLTaiizor.Controls.LabelEdit();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            PWDTB = new ReaLTaiizor.Controls.BigTextBox();
            PLPB = new ReaLTaiizor.Controls.PoisonProgressBar();
            SSBR = new ReaLTaiizor.Controls.ForeverStatusBar();
            CEB = new ReaLTaiizor.Controls.MaterialButton();
            CYB = new ReaLTaiizor.Controls.MaterialButton();
            MTC = new ReaLTaiizor.Controls.MaterialTabControl();
            Generate = new System.Windows.Forms.TabPage();
            HYS = new ReaLTaiizor.Controls.MaterialSwitch();
            History = new System.Windows.Forms.TabPage();
            HYP = new System.Windows.Forms.Panel();
            Setting = new System.Windows.Forms.TabPage();
            MTS = new ReaLTaiizor.Controls.MaterialTabSelector();
            STATUST = new System.Windows.Forms.Timer(components);
            STATUSMT = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            MTC.SuspendLayout();
            Generate.SuspendLayout();
            History.SuspendLayout();
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
            PWDTB.Image = global::Nerator.Properties.Resources.PasteSpecial;
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
            // PLPB
            // 
            PLPB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            PLPB.Location = new System.Drawing.Point(10, 46);
            PLPB.Name = "PLPB";
            PLPB.Size = new System.Drawing.Size(307, 5);
            PLPB.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Green;
            PLPB.TabIndex = 12;
            PLPB.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            // 
            // SSBR
            // 
            SSBR.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            SSBR.Dock = System.Windows.Forms.DockStyle.Bottom;
            SSBR.Font = new System.Drawing.Font("Segoe UI", 8F);
            SSBR.ForeColor = System.Drawing.Color.White;
            SSBR.Location = new System.Drawing.Point(0, 359);
            SSBR.Name = "SSBR";
            SSBR.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            SSBR.ShowTimeDate = true;
            SSBR.Size = new System.Drawing.Size(359, 22);
            SSBR.TabIndex = 13;
            SSBR.Text = "Uygulama işleyişi sorunsuz bir şekilde devam etmektedir.";
            SSBR.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            SSBR.TimeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            SSBR.TimeFormat = "HH:mm:ss";
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
            // MTC
            // 
            MTC.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            MTC.Controls.Add(Generate);
            MTC.Controls.Add(History);
            MTC.Controls.Add(Setting);
            MTC.Depth = 0;
            MTC.ItemSize = new System.Drawing.Size(44, 18);
            MTC.Location = new System.Drawing.Point(12, 99);
            MTC.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            MTC.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            MTC.Multiline = true;
            MTC.Name = "MTC";
            MTC.Padding = new System.Drawing.Point(0, 0);
            MTC.SelectedIndex = 0;
            MTC.Size = new System.Drawing.Size(335, 227);
            MTC.TabIndex = 16;
            // 
            // Generate
            // 
            Generate.BackColor = System.Drawing.SystemColors.Control;
            Generate.Controls.Add(HYS);
            Generate.Controls.Add(CEB);
            Generate.Controls.Add(CYB);
            Generate.Controls.Add(PWDTB);
            Generate.Controls.Add(PLPB);
            Generate.Location = new System.Drawing.Point(4, 4);
            Generate.Name = "Generate";
            Generate.Padding = new System.Windows.Forms.Padding(3);
            Generate.Size = new System.Drawing.Size(327, 201);
            Generate.TabIndex = 1;
            Generate.Text = "Generate";
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
            // History
            // 
            History.BackColor = System.Drawing.SystemColors.Control;
            History.Controls.Add(HYP);
            History.Location = new System.Drawing.Point(4, 4);
            History.Name = "History";
            History.Padding = new System.Windows.Forms.Padding(3);
            History.Size = new System.Drawing.Size(327, 201);
            History.TabIndex = 0;
            History.Text = "History";
            // 
            // HYP
            // 
            HYP.AutoScroll = true;
            HYP.BackColor = System.Drawing.Color.Transparent;
            HYP.Dock = System.Windows.Forms.DockStyle.Fill;
            HYP.Location = new System.Drawing.Point(3, 3);
            HYP.Margin = new System.Windows.Forms.Padding(0);
            HYP.Name = "HYP";
            HYP.Size = new System.Drawing.Size(321, 195);
            HYP.TabIndex = 0;
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
            // MTS
            // 
            MTS.BaseTabControl = MTC;
            MTS.Depth = 0;
            MTS.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            MTS.HeadAlignment = ReaLTaiizor.Controls.MaterialTabSelector.Alignment.Center;
            MTS.Location = new System.Drawing.Point(12, 76);
            MTS.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            MTS.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            MTS.Name = "MTS";
            MTS.Size = new System.Drawing.Size(335, 23);
            MTS.TabIndex = 17;
            MTS.Text = "materialTabSelector1";
            MTS.TitleTextState = ReaLTaiizor.Controls.MaterialTabSelector.TextState.Normal;
            // 
            // STATUST
            // 
            STATUST.Enabled = true;
            STATUST.Interval = 1000;
            STATUST.Tick += new System.EventHandler(STATUST_Tick);
            // 
            // STATUSMT
            // 
            STATUSMT.Enabled = true;
            STATUSMT.Interval = 50;
            STATUSMT.Tick += new System.EventHandler(STATUSMT_Tick);
            // 
            // LIGHT
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            ClientSize = new System.Drawing.Size(359, 381);
            Controls.Add(MTS);
            Controls.Add(MTC);
            Controls.Add(SSBR);
            Controls.Add(pictureBox1);
            Controls.Add(labelEdit1);
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MaximizeBox = false;
            Name = "LIGHT";
            Sizable = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "New Generation Password Generator";
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            MTC.ResumeLayout(false);
            Generate.ResumeLayout(false);
            Generate.PerformLayout();
            History.ResumeLayout(false);
            ResumeLayout(false);

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
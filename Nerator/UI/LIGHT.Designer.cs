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
            this.TELE = new ReaLTaiizor.Controls.LabelEdit();
            this.LOPB = new System.Windows.Forms.PictureBox();
            this.PWDTB = new ReaLTaiizor.Controls.BigTextBox();
            this.PLPB = new ReaLTaiizor.Controls.PoisonProgressBar();
            this.SSBR = new ReaLTaiizor.Controls.ForeverStatusBar();
            this.CEB = new ReaLTaiizor.Controls.MaterialButton();
            this.CYB = new ReaLTaiizor.Controls.MaterialButton();
            this.MTC = new ReaLTaiizor.Controls.MaterialTabControl();
            this.Generate = new System.Windows.Forms.TabPage();
            this.HYS = new ReaLTaiizor.Controls.MaterialSwitch();
            this.WRPB = new System.Windows.Forms.PictureBox();
            this.History = new System.Windows.Forms.TabPage();
            this.HYP = new System.Windows.Forms.Panel();
            this.Setting = new System.Windows.Forms.TabPage();
            this.DKUC = new Nerator.UC.THEME.DK();
            this.LTUC = new Nerator.UC.THEME.LT();
            this.TMCB = new ReaLTaiizor.Controls.MaterialCheckBox();
            this.RTPB = new System.Windows.Forms.PictureBox();
            this.PWLN = new ReaLTaiizor.Controls.HopeNumeric();
            this.SMCB = new ReaLTaiizor.Controls.MaterialComboBox();
            this.AMCB = new ReaLTaiizor.Controls.MaterialComboBox();
            this.MTS = new ReaLTaiizor.Controls.MaterialTabSelector();
            this.STATUST = new System.Windows.Forms.Timer(this.components);
            this.STATUSMT = new System.Windows.Forms.Timer(this.components);
            this.materialCheckBox1 = new ReaLTaiizor.Controls.MaterialCheckBox();
            this.materialCheckBox2 = new ReaLTaiizor.Controls.MaterialCheckBox();
            this.materialCheckBox3 = new ReaLTaiizor.Controls.MaterialCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.LOPB)).BeginInit();
            this.MTC.SuspendLayout();
            this.Generate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WRPB)).BeginInit();
            this.History.SuspendLayout();
            this.Setting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RTPB)).BeginInit();
            this.SuspendLayout();
            // 
            // TELE
            // 
            this.TELE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TELE.BackColor = System.Drawing.Color.Transparent;
            this.TELE.Enabled = false;
            this.TELE.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.TELE.ForeColor = System.Drawing.Color.White;
            this.TELE.Location = new System.Drawing.Point(0, 0);
            this.TELE.Name = "TELE";
            this.TELE.Size = new System.Drawing.Size(359, 25);
            this.TELE.TabIndex = 1;
            this.TELE.Text = "Nerator";
            this.TELE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LOPB
            // 
            this.LOPB.BackColor = System.Drawing.Color.Transparent;
            this.LOPB.Enabled = false;
            this.LOPB.Image = global::Nerator.Properties.Resources.ShowPassword;
            this.LOPB.Location = new System.Drawing.Point(0, 0);
            this.LOPB.Name = "LOPB";
            this.LOPB.Size = new System.Drawing.Size(25, 24);
            this.LOPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LOPB.TabIndex = 3;
            this.LOPB.TabStop = false;
            // 
            // PWDTB
            // 
            this.PWDTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PWDTB.BackColor = System.Drawing.Color.White;
            this.PWDTB.Font = new System.Drawing.Font("Tahoma", 11F);
            this.PWDTB.ForeColor = System.Drawing.Color.DimGray;
            this.PWDTB.Image = global::Nerator.Properties.Resources.PasteSpecial;
            this.PWDTB.Location = new System.Drawing.Point(6, 106);
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
            this.PLPB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PLPB.Location = new System.Drawing.Point(10, 146);
            this.PLPB.Name = "PLPB";
            this.PLPB.Size = new System.Drawing.Size(307, 5);
            this.PLPB.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Green;
            this.PLPB.TabIndex = 12;
            this.PLPB.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.PLPB.Value = 50;
            // 
            // SSBR
            // 
            this.SSBR.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.SSBR.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SSBR.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.SSBR.ForeColor = System.Drawing.Color.White;
            this.SSBR.Location = new System.Drawing.Point(0, 336);
            this.SSBR.Name = "SSBR";
            this.SSBR.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.SSBR.ShowTimeDate = true;
            this.SSBR.Size = new System.Drawing.Size(359, 22);
            this.SSBR.TabIndex = 13;
            this.SSBR.Text = "The application continues to run smoothly.";
            this.SSBR.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SSBR.TimeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.SSBR.TimeFormat = "HH:mm:ss";
            // 
            // CEB
            // 
            this.CEB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CEB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CEB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CEB.Depth = 0;
            this.CEB.DrawShadows = true;
            this.CEB.HighEmphasis = true;
            this.CEB.Icon = global::Nerator.Properties.Resources.QuillInk;
            this.CEB.Location = new System.Drawing.Point(6, 156);
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
            this.CYB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CYB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CYB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CYB.Depth = 0;
            this.CYB.DrawShadows = true;
            this.CYB.HighEmphasis = true;
            this.CYB.Icon = global::Nerator.Properties.Resources.CopyClipboard;
            this.CYB.Location = new System.Drawing.Point(234, 156);
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
            this.MTC.Location = new System.Drawing.Point(12, 98);
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
            this.Generate.Controls.Add(this.WRPB);
            this.Generate.Location = new System.Drawing.Point(4, 4);
            this.Generate.Name = "Generate";
            this.Generate.Padding = new System.Windows.Forms.Padding(3);
            this.Generate.Size = new System.Drawing.Size(327, 201);
            this.Generate.TabIndex = 1;
            this.Generate.Text = "Generate";
            // 
            // HYS
            // 
            this.HYS.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.HYS.AutoSize = true;
            this.HYS.Checked = true;
            this.HYS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HYS.Depth = 0;
            this.HYS.Location = new System.Drawing.Point(117, 157);
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
            this.HYS.CheckedChanged += new System.EventHandler(this.HYS_CheckedChanged);
            // 
            // WRPB
            // 
            this.WRPB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WRPB.BackColor = System.Drawing.Color.Transparent;
            this.WRPB.Image = global::Nerator.Properties.Resources.WaitRabbit;
            this.WRPB.Location = new System.Drawing.Point(0, 0);
            this.WRPB.Margin = new System.Windows.Forms.Padding(0);
            this.WRPB.Name = "WRPB";
            this.WRPB.Size = new System.Drawing.Size(327, 103);
            this.WRPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WRPB.TabIndex = 17;
            this.WRPB.TabStop = false;
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
            this.Setting.Controls.Add(this.DKUC);
            this.Setting.Controls.Add(this.LTUC);
            this.Setting.Controls.Add(this.TMCB);
            this.Setting.Controls.Add(this.RTPB);
            this.Setting.Controls.Add(this.PWLN);
            this.Setting.Controls.Add(this.SMCB);
            this.Setting.Controls.Add(this.AMCB);
            this.Setting.Location = new System.Drawing.Point(4, 4);
            this.Setting.Name = "Setting";
            this.Setting.Padding = new System.Windows.Forms.Padding(3);
            this.Setting.Size = new System.Drawing.Size(327, 201);
            this.Setting.TabIndex = 2;
            this.Setting.Text = "Setting";
            // 
            // DKUC
            // 
            this.DKUC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DKUC.BackColor = System.Drawing.Color.Transparent;
            this.DKUC.Location = new System.Drawing.Point(218, 98);
            this.DKUC.Margin = new System.Windows.Forms.Padding(5);
            this.DKUC.MaximumSize = new System.Drawing.Size(103, 97);
            this.DKUC.MinimumSize = new System.Drawing.Size(103, 97);
            this.DKUC.Name = "DKUC";
            this.DKUC.Size = new System.Drawing.Size(103, 97);
            this.DKUC.TabIndex = 16;
            // 
            // LTUC
            // 
            this.LTUC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LTUC.BackColor = System.Drawing.Color.Transparent;
            this.LTUC.Location = new System.Drawing.Point(6, 98);
            this.LTUC.Margin = new System.Windows.Forms.Padding(5);
            this.LTUC.MaximumSize = new System.Drawing.Size(103, 97);
            this.LTUC.MinimumSize = new System.Drawing.Size(103, 97);
            this.LTUC.Name = "LTUC";
            this.LTUC.Size = new System.Drawing.Size(103, 97);
            this.LTUC.TabIndex = 15;
            // 
            // TMCB
            // 
            this.TMCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TMCB.AutoSize = true;
            this.TMCB.Checked = true;
            this.TMCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TMCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TMCB.Depth = 0;
            this.TMCB.Location = new System.Drawing.Point(108, 61);
            this.TMCB.Margin = new System.Windows.Forms.Padding(0);
            this.TMCB.MouseLocation = new System.Drawing.Point(-1, -1);
            this.TMCB.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.TMCB.Name = "TMCB";
            this.TMCB.Ripple = true;
            this.TMCB.Size = new System.Drawing.Size(103, 37);
            this.TMCB.TabIndex = 12;
            this.TMCB.Text = "Top Most";
            this.TMCB.UseVisualStyleBackColor = true;
            this.TMCB.CheckedChanged += new System.EventHandler(this.TMCB_CheckedChanged);
            // 
            // RTPB
            // 
            this.RTPB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTPB.BackColor = System.Drawing.Color.Transparent;
            this.RTPB.Image = global::Nerator.Properties.Resources.WhiteCat;
            this.RTPB.Location = new System.Drawing.Point(0, 98);
            this.RTPB.Margin = new System.Windows.Forms.Padding(0);
            this.RTPB.Name = "RTPB";
            this.RTPB.Size = new System.Drawing.Size(327, 103);
            this.RTPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RTPB.TabIndex = 5;
            this.RTPB.TabStop = false;
            // 
            // PWLN
            // 
            this.PWLN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PWLN.BackColor = System.Drawing.Color.White;
            this.PWLN.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.PWLN.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.PWLN.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.PWLN.BorderHoverColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.PWLN.ButtonTextColorA = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.PWLN.ButtonTextColorB = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.PWLN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PWLN.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PWLN.ForeColor = System.Drawing.Color.Black;
            this.PWLN.HoverButtonTextColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.PWLN.HoverButtonTextColorB = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.PWLN.Location = new System.Drawing.Point(3, 60);
            this.PWLN.MaxNum = 50F;
            this.PWLN.MinNum = 6F;
            this.PWLN.Name = "PWLN";
            this.PWLN.Precision = 0;
            this.PWLN.Size = new System.Drawing.Size(120, 32);
            this.PWLN.Step = 1F;
            this.PWLN.Style = ReaLTaiizor.Controls.HopeNumeric.NumericStyle.LeftRight;
            this.PWLN.TabIndex = 4;
            this.PWLN.Text = "PWLN";
            this.PWLN.ValueNumber = 15F;
            // 
            // SMCB
            // 
            this.SMCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SMCB.AutoResize = false;
            this.SMCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SMCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SMCB.Depth = 0;
            this.SMCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.SMCB.DropDownHeight = 174;
            this.SMCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SMCB.DropDownWidth = 135;
            this.SMCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.SMCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SMCB.FormattingEnabled = true;
            this.SMCB.Hint = "Special Mode";
            this.SMCB.IntegralHeight = false;
            this.SMCB.ItemHeight = 43;
            this.SMCB.Items.AddRange(new object[] {
            "Mixed",
            "Symbol",
            "Number"});
            this.SMCB.Location = new System.Drawing.Point(186, 6);
            this.SMCB.MaxDropDownItems = 4;
            this.SMCB.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.SMCB.Name = "SMCB";
            this.SMCB.Size = new System.Drawing.Size(135, 49);
            this.SMCB.TabIndex = 14;
            this.SMCB.UseAccent = false;
            this.SMCB.SelectedIndexChanged += new System.EventHandler(this.SMCB_SelectedIndexChanged);
            // 
            // AMCB
            // 
            this.AMCB.AutoResize = false;
            this.AMCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AMCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AMCB.Depth = 0;
            this.AMCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.AMCB.DropDownHeight = 174;
            this.AMCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AMCB.DropDownWidth = 135;
            this.AMCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.AMCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AMCB.FormattingEnabled = true;
            this.AMCB.Hint = "Alphabetic Mode";
            this.AMCB.IntegralHeight = false;
            this.AMCB.ItemHeight = 43;
            this.AMCB.Items.AddRange(new object[] {
            "Mixed",
            "Uppercase",
            "Lowercase"});
            this.AMCB.Location = new System.Drawing.Point(6, 6);
            this.AMCB.MaxDropDownItems = 4;
            this.AMCB.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.AMCB.Name = "AMCB";
            this.AMCB.Size = new System.Drawing.Size(135, 49);
            this.AMCB.TabIndex = 13;
            this.AMCB.UseAccent = false;
            this.AMCB.SelectedIndexChanged += new System.EventHandler(this.AMCB_SelectedIndexChanged);
            // 
            // MTS
            // 
            this.MTS.BaseTabControl = this.MTC;
            this.MTS.Cursor = System.Windows.Forms.Cursors.Default;
            this.MTS.Depth = 0;
            this.MTS.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MTS.HeadAlignment = ReaLTaiizor.Controls.MaterialTabSelector.Alignment.Center;
            this.MTS.Location = new System.Drawing.Point(12, 75);
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
            // materialCheckBox1
            // 
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Location = new System.Drawing.Point(0, 0);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(104, 37);
            this.materialCheckBox1.TabIndex = 0;
            this.materialCheckBox1.Text = "materialCheckBox1";
            this.materialCheckBox1.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox2
            // 
            this.materialCheckBox2.Depth = 0;
            this.materialCheckBox2.Location = new System.Drawing.Point(0, 0);
            this.materialCheckBox2.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialCheckBox2.Name = "materialCheckBox2";
            this.materialCheckBox2.Ripple = true;
            this.materialCheckBox2.Size = new System.Drawing.Size(104, 37);
            this.materialCheckBox2.TabIndex = 0;
            this.materialCheckBox2.Text = "materialCheckBox2";
            this.materialCheckBox2.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox3
            // 
            this.materialCheckBox3.Depth = 0;
            this.materialCheckBox3.Location = new System.Drawing.Point(0, 0);
            this.materialCheckBox3.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialCheckBox3.Name = "materialCheckBox3";
            this.materialCheckBox3.Ripple = true;
            this.materialCheckBox3.Size = new System.Drawing.Size(104, 37);
            this.materialCheckBox3.TabIndex = 0;
            this.materialCheckBox3.Text = "materialCheckBox3";
            this.materialCheckBox3.UseVisualStyleBackColor = true;
            // 
            // LIGHT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(359, 358);
            this.Controls.Add(this.SSBR);
            this.Controls.Add(this.MTS);
            this.Controls.Add(this.MTC);
            this.Controls.Add(this.LOPB);
            this.Controls.Add(this.TELE);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(359, 358);
            this.MinimumSize = new System.Drawing.Size(359, 358);
            this.Name = "LIGHT";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Generation Password Generator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LIGHT_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.LOPB)).EndInit();
            this.MTC.ResumeLayout(false);
            this.Generate.ResumeLayout(false);
            this.Generate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WRPB)).EndInit();
            this.History.ResumeLayout(false);
            this.Setting.ResumeLayout(false);
            this.Setting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RTPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.LabelEdit TELE;
        private System.Windows.Forms.PictureBox LOPB;
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
        private System.Windows.Forms.PictureBox WRPB;
        private ReaLTaiizor.Controls.HopeNumeric PWLN;
        private System.Windows.Forms.PictureBox RTPB;
        private ReaLTaiizor.Controls.MaterialCheckBox TMCB;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox1;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox2;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox3;
        private ReaLTaiizor.Controls.MaterialComboBox AMCB;
        private ReaLTaiizor.Controls.MaterialComboBox SMCB;
        private UC.THEME.LT LTUC;
        private UC.THEME.DK DKUC;
    }
}
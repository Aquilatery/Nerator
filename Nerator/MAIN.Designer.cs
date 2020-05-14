namespace Nerator
{
    partial class MAIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAIN));
            this.themeForm1 = new ReaLTaiizor.ThemeForm();
            this.Copy_B = new ReaLTaiizor.ForeverButton();
            this.Settings = new ReaLTaiizor.ThunderGroupBox();
            this.Special = new System.Windows.Forms.GroupBox();
            this.Just_Number = new ReaLTaiizor.ForeverRadioButton();
            this.Just_Symbol = new ReaLTaiizor.ForeverRadioButton();
            this.Number_Symbol = new ReaLTaiizor.ForeverRadioButton();
            this.Alphabetic = new System.Windows.Forms.GroupBox();
            this.Just_Big = new ReaLTaiizor.ForeverRadioButton();
            this.Just_Small = new ReaLTaiizor.ForeverRadioButton();
            this.Big_Small = new ReaLTaiizor.ForeverRadioButton();
            this.PLength = new ReaLTaiizor.ForeverNumeric();
            this.Length = new ReaLTaiizor.LabelEdit();
            this.labelEdit1 = new ReaLTaiizor.LabelEdit();
            this.Create_B = new ReaLTaiizor.ForeverButton();
            this.Password = new ReaLTaiizor.TextEdit();
            this.Description = new ReaLTaiizor.LabelEdit();
            this.controlBox1 = new ReaLTaiizor.ControlBox();
            this.themeForm1.SuspendLayout();
            this.Settings.SuspendLayout();
            this.Special.SuspendLayout();
            this.Alphabetic.SuspendLayout();
            this.SuspendLayout();
            // 
            // themeForm1
            // 
            this.themeForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.themeForm1.Controls.Add(this.Copy_B);
            this.themeForm1.Controls.Add(this.Settings);
            this.themeForm1.Controls.Add(this.labelEdit1);
            this.themeForm1.Controls.Add(this.Create_B);
            this.themeForm1.Controls.Add(this.Password);
            this.themeForm1.Controls.Add(this.Description);
            this.themeForm1.Controls.Add(this.controlBox1);
            this.themeForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.themeForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.themeForm1.Image = global::Nerator.Properties.Resources.Password1;
            this.themeForm1.Location = new System.Drawing.Point(0, 0);
            this.themeForm1.Name = "themeForm1";
            this.themeForm1.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.themeForm1.RoundCorners = true;
            this.themeForm1.Sizable = false;
            this.themeForm1.Size = new System.Drawing.Size(335, 545);
            this.themeForm1.SmartBounds = true;
            this.themeForm1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.themeForm1.TabIndex = 0;
            this.themeForm1.Text = "Soferity - Nerator";
            // 
            // Copy_B
            // 
            this.Copy_B.BackColor = System.Drawing.Color.Transparent;
            this.Copy_B.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.Copy_B.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Copy_B.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Copy_B.Location = new System.Drawing.Point(196, 152);
            this.Copy_B.Name = "Copy_B";
            this.Copy_B.Rounded = true;
            this.Copy_B.Size = new System.Drawing.Size(120, 40);
            this.Copy_B.TabIndex = 4;
            this.Copy_B.Text = "Copy";
            this.Copy_B.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.Copy_B.Click += new System.EventHandler(this.Copy_B_Click);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.Transparent;
            this.Settings.Controls.Add(this.Special);
            this.Settings.Controls.Add(this.Alphabetic);
            this.Settings.Controls.Add(this.PLength);
            this.Settings.Controls.Add(this.Length);
            this.Settings.Location = new System.Drawing.Point(20, 202);
            this.Settings.Margin = new System.Windows.Forms.Padding(10);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(6, 30, 6, 6);
            this.Settings.Size = new System.Drawing.Size(296, 324);
            this.Settings.TabIndex = 0;
            this.Settings.Text = "Advanced Settings";
            // 
            // Special
            // 
            this.Special.Controls.Add(this.Just_Number);
            this.Special.Controls.Add(this.Just_Symbol);
            this.Special.Controls.Add(this.Number_Symbol);
            this.Special.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Special.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.Special.Location = new System.Drawing.Point(12, 200);
            this.Special.Margin = new System.Windows.Forms.Padding(6);
            this.Special.Name = "Special";
            this.Special.Size = new System.Drawing.Size(272, 113);
            this.Special.TabIndex = 8;
            this.Special.TabStop = false;
            this.Special.Text = "Special Characters";
            // 
            // Just_Number
            // 
            this.Just_Number.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(52)))));
            this.Just_Number.Checked = false;
            this.Just_Number.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Just_Number.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Just_Number.ForeColor = System.Drawing.Color.DimGray;
            this.Just_Number.Location = new System.Drawing.Point(9, 81);
            this.Just_Number.Margin = new System.Windows.Forms.Padding(6, 3, 6, 6);
            this.Just_Number.Name = "Just_Number";
            this.Just_Number.Options = ReaLTaiizor.ForeverRadioButton._Options.Style1;
            this.Just_Number.Size = new System.Drawing.Size(254, 22);
            this.Just_Number.TabIndex = 9;
            this.Just_Number.Text = "Number Only - 123456";
            // 
            // Just_Symbol
            // 
            this.Just_Symbol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(52)))));
            this.Just_Symbol.Checked = false;
            this.Just_Symbol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Just_Symbol.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Just_Symbol.ForeColor = System.Drawing.Color.DimGray;
            this.Just_Symbol.Location = new System.Drawing.Point(9, 53);
            this.Just_Symbol.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Just_Symbol.Name = "Just_Symbol";
            this.Just_Symbol.Options = ReaLTaiizor.ForeverRadioButton._Options.Style1;
            this.Just_Symbol.Size = new System.Drawing.Size(254, 22);
            this.Just_Symbol.TabIndex = 8;
            this.Just_Symbol.Text = "Special Symbol Only - $&£/*+";
            // 
            // Number_Symbol
            // 
            this.Number_Symbol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(52)))));
            this.Number_Symbol.Checked = true;
            this.Number_Symbol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Number_Symbol.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Number_Symbol.ForeColor = System.Drawing.Color.DimGray;
            this.Number_Symbol.Location = new System.Drawing.Point(9, 25);
            this.Number_Symbol.Margin = new System.Windows.Forms.Padding(6, 6, 6, 3);
            this.Number_Symbol.Name = "Number_Symbol";
            this.Number_Symbol.Options = ReaLTaiizor.ForeverRadioButton._Options.Style1;
            this.Number_Symbol.Size = new System.Drawing.Size(254, 22);
            this.Number_Symbol.TabIndex = 7;
            this.Number_Symbol.Text = "Number and Special Symbol - 1$2&3£";
            // 
            // Alphabetic
            // 
            this.Alphabetic.Controls.Add(this.Just_Big);
            this.Alphabetic.Controls.Add(this.Just_Small);
            this.Alphabetic.Controls.Add(this.Big_Small);
            this.Alphabetic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Alphabetic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.Alphabetic.Location = new System.Drawing.Point(12, 75);
            this.Alphabetic.Margin = new System.Windows.Forms.Padding(6);
            this.Alphabetic.Name = "Alphabetic";
            this.Alphabetic.Size = new System.Drawing.Size(272, 113);
            this.Alphabetic.TabIndex = 7;
            this.Alphabetic.TabStop = false;
            this.Alphabetic.Text = "Alphabetic Characters";
            // 
            // Just_Big
            // 
            this.Just_Big.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(52)))));
            this.Just_Big.Checked = false;
            this.Just_Big.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Just_Big.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Just_Big.ForeColor = System.Drawing.Color.DimGray;
            this.Just_Big.Location = new System.Drawing.Point(9, 79);
            this.Just_Big.Margin = new System.Windows.Forms.Padding(6, 3, 6, 6);
            this.Just_Big.Name = "Just_Big";
            this.Just_Big.Options = ReaLTaiizor.ForeverRadioButton._Options.Style1;
            this.Just_Big.Size = new System.Drawing.Size(254, 22);
            this.Just_Big.TabIndex = 8;
            this.Just_Big.Text = "Capital Letter Only - ABCDEF";
            // 
            // Just_Small
            // 
            this.Just_Small.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(52)))));
            this.Just_Small.Checked = false;
            this.Just_Small.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Just_Small.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Just_Small.ForeColor = System.Drawing.Color.DimGray;
            this.Just_Small.Location = new System.Drawing.Point(9, 51);
            this.Just_Small.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Just_Small.Name = "Just_Small";
            this.Just_Small.Options = ReaLTaiizor.ForeverRadioButton._Options.Style1;
            this.Just_Small.Size = new System.Drawing.Size(254, 22);
            this.Just_Small.TabIndex = 7;
            this.Just_Small.Text = "Small Letter Only - abcdef";
            // 
            // Big_Small
            // 
            this.Big_Small.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(52)))));
            this.Big_Small.Checked = true;
            this.Big_Small.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Big_Small.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Big_Small.ForeColor = System.Drawing.Color.DimGray;
            this.Big_Small.Location = new System.Drawing.Point(9, 23);
            this.Big_Small.Margin = new System.Windows.Forms.Padding(6, 6, 6, 3);
            this.Big_Small.Name = "Big_Small";
            this.Big_Small.Options = ReaLTaiizor.ForeverRadioButton._Options.Style1;
            this.Big_Small.Size = new System.Drawing.Size(254, 22);
            this.Big_Small.TabIndex = 6;
            this.Big_Small.Text = "Uppercase and Lowercase - AaBbCc";
            // 
            // PLength
            // 
            this.PLength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(93)))));
            this.PLength.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.PLength.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.PLength.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.PLength.ForeColor = System.Drawing.Color.DimGray;
            this.PLength.Location = new System.Drawing.Point(209, 36);
            this.PLength.Margin = new System.Windows.Forms.Padding(6);
            this.PLength.Maximum = ((long)(50));
            this.PLength.Minimum = ((long)(6));
            this.PLength.Name = "PLength";
            this.PLength.Size = new System.Drawing.Size(75, 30);
            this.PLength.TabIndex = 2;
            this.PLength.Text = "PLength";
            this.PLength.Value = ((long)(15));
            // 
            // Length
            // 
            this.Length.AutoSize = true;
            this.Length.BackColor = System.Drawing.Color.Transparent;
            this.Length.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Length.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.Length.Location = new System.Drawing.Point(8, 41);
            this.Length.Margin = new System.Windows.Forms.Padding(6);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(136, 20);
            this.Length.TabIndex = 0;
            this.Length.Text = "Password Length:";
            // 
            // labelEdit1
            // 
            this.labelEdit1.AutoSize = true;
            this.labelEdit1.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelEdit1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.labelEdit1.Location = new System.Drawing.Point(62, 242);
            this.labelEdit1.Name = "labelEdit1";
            this.labelEdit1.Size = new System.Drawing.Size(62, 15);
            this.labelEdit1.TabIndex = 3;
            this.labelEdit1.Text = "labelEdit1";
            // 
            // Create_B
            // 
            this.Create_B.BackColor = System.Drawing.Color.Transparent;
            this.Create_B.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.Create_B.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Create_B.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Create_B.Location = new System.Drawing.Point(20, 152);
            this.Create_B.Name = "Create_B";
            this.Create_B.Rounded = true;
            this.Create_B.Size = new System.Drawing.Size(120, 40);
            this.Create_B.TabIndex = 1;
            this.Create_B.Text = "Create";
            this.Create_B.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.Create_B.Click += new System.EventHandler(this.Create_B_Click);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.Password.Image = global::Nerator.Properties.Resources.Key1;
            this.Password.Location = new System.Drawing.Point(20, 100);
            this.Password.Margin = new System.Windows.Forms.Padding(10);
            this.Password.MaxLength = 50;
            this.Password.Multiline = false;
            this.Password.Name = "Password";
            this.Password.ReadOnly = false;
            this.Password.Size = new System.Drawing.Size(296, 41);
            this.Password.TabIndex = 2;
            this.Password.Text = "Nerator";
            this.Password.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Password.UseSystemPasswordChar = false;
            // 
            // Description
            // 
            this.Description.BackColor = System.Drawing.Color.Transparent;
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.Description.Location = new System.Drawing.Point(0, 70);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(335, 20);
            this.Description.TabIndex = 1;
            this.Description.Text = "New Generation Password Generator";
            this.Description.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // controlBox1
            // 
            this.controlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.controlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.controlBox1.DefaultLocation = true;
            this.controlBox1.EnableHoverHighlight = true;
            this.controlBox1.EnableMaximizeButton = false;
            this.controlBox1.EnableMinimizeButton = true;
            this.controlBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.controlBox1.Location = new System.Drawing.Point(235, 18);
            this.controlBox1.Name = "controlBox1";
            this.controlBox1.Size = new System.Drawing.Size(90, 25);
            this.controlBox1.TabIndex = 0;
            this.controlBox1.Text = "controlBox1";
            // 
            // MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 545);
            this.Controls.Add(this.themeForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(261, 61);
            this.Name = "MAIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soferity - Nerator";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.themeForm1.ResumeLayout(false);
            this.themeForm1.PerformLayout();
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.Special.ResumeLayout(false);
            this.Alphabetic.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.ThemeForm themeForm1;
        private ReaLTaiizor.ControlBox controlBox1;
        private ReaLTaiizor.TextEdit Password;
        private ReaLTaiizor.LabelEdit Description;
        private ReaLTaiizor.ThunderGroupBox Settings;
        private ReaLTaiizor.LabelEdit labelEdit1;
        private ReaLTaiizor.ForeverNumeric PLength;
        private ReaLTaiizor.LabelEdit Length;
        private ReaLTaiizor.ForeverRadioButton Big_Small;
        private System.Windows.Forms.GroupBox Alphabetic;
        private ReaLTaiizor.ForeverRadioButton Just_Big;
        private ReaLTaiizor.ForeverRadioButton Just_Small;
        private System.Windows.Forms.GroupBox Special;
        private ReaLTaiizor.ForeverRadioButton Just_Number;
        private ReaLTaiizor.ForeverRadioButton Just_Symbol;
        private ReaLTaiizor.ForeverRadioButton Number_Symbol;
        private ReaLTaiizor.Button Create;
        private ReaLTaiizor.ForeverButton Copy_B;
        private ReaLTaiizor.ForeverButton Create_B;
    }
}
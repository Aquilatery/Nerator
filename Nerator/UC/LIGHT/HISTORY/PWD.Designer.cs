
namespace Nerator.UC.LIGHT.HISTORY
{
    partial class PWD
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.PASSWORD = new ReaLTaiizor.Controls.MetroLabel();
            this.COPY = new ReaLTaiizor.Controls.MaterialButton();
            this.REMOVE = new ReaLTaiizor.Controls.MaterialButton();
            this.TIMEDATE = new ReaLTaiizor.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // PASSWORD
            // 
            this.PASSWORD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PASSWORD.AutoEllipsis = true;
            this.PASSWORD.Cursor = System.Windows.Forms.Cursors.Default;
            this.PASSWORD.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.PASSWORD.IsDerivedStyle = true;
            this.PASSWORD.Location = new System.Drawing.Point(80, -1);
            this.PASSWORD.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.Size = new System.Drawing.Size(142, 36);
            this.PASSWORD.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.PASSWORD.StyleManager = null;
            this.PASSWORD.TabIndex = 0;
            this.PASSWORD.Text = "PASSWORD PASSWORD PASSWORD PASSWORD";
            this.PASSWORD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PASSWORD.ThemeAuthor = "Taiizor";
            this.PASSWORD.ThemeName = "MetroLight";
            this.PASSWORD.UseCompatibleTextRendering = true;
            // 
            // COPY
            // 
            this.COPY.AutoSize = false;
            this.COPY.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.COPY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.COPY.Depth = 0;
            this.COPY.Dock = System.Windows.Forms.DockStyle.Right;
            this.COPY.DrawShadows = false;
            this.COPY.HighEmphasis = true;
            this.COPY.Icon = global::Nerator.Properties.Resources.Copy;
            this.COPY.Location = new System.Drawing.Point(224, 0);
            this.COPY.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.COPY.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.COPY.Name = "COPY";
            this.COPY.Size = new System.Drawing.Size(44, 36);
            this.COPY.TabIndex = 2;
            this.COPY.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Text;
            this.COPY.UseAccentColor = false;
            this.COPY.UseVisualStyleBackColor = true;
            this.COPY.Click += new System.EventHandler(this.COPY_Click);
            // 
            // REMOVE
            // 
            this.REMOVE.AutoSize = false;
            this.REMOVE.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.REMOVE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.REMOVE.Depth = 0;
            this.REMOVE.Dock = System.Windows.Forms.DockStyle.Right;
            this.REMOVE.DrawShadows = false;
            this.REMOVE.HighEmphasis = true;
            this.REMOVE.Icon = global::Nerator.Properties.Resources.Delete;
            this.REMOVE.Location = new System.Drawing.Point(268, 0);
            this.REMOVE.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.REMOVE.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.REMOVE.Name = "REMOVE";
            this.REMOVE.Size = new System.Drawing.Size(44, 36);
            this.REMOVE.TabIndex = 3;
            this.REMOVE.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Text;
            this.REMOVE.UseAccentColor = true;
            this.REMOVE.UseVisualStyleBackColor = true;
            this.REMOVE.Click += new System.EventHandler(this.REMOVE_Click);
            // 
            // TIMEDATE
            // 
            this.TIMEDATE.Cursor = System.Windows.Forms.Cursors.Default;
            this.TIMEDATE.Dock = System.Windows.Forms.DockStyle.Left;
            this.TIMEDATE.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.TIMEDATE.IsDerivedStyle = true;
            this.TIMEDATE.Location = new System.Drawing.Point(0, 0);
            this.TIMEDATE.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.TIMEDATE.Name = "TIMEDATE";
            this.TIMEDATE.Size = new System.Drawing.Size(78, 36);
            this.TIMEDATE.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.TIMEDATE.StyleManager = null;
            this.TIMEDATE.TabIndex = 4;
            this.TIMEDATE.Text = "00:00:00\r\n00.00.0000";
            this.TIMEDATE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TIMEDATE.ThemeAuthor = "Taiizor";
            this.TIMEDATE.ThemeName = "MetroLight";
            // 
            // PWD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.Controls.Add(this.TIMEDATE);
            this.Controls.Add(this.COPY);
            this.Controls.Add(this.PASSWORD);
            this.Controls.Add(this.REMOVE);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(329, 36);
            this.MinimumSize = new System.Drawing.Size(312, 36);
            this.Name = "PWD";
            this.Size = new System.Drawing.Size(312, 36);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MetroLabel PASSWORD;
        private ReaLTaiizor.Controls.MaterialButton COPY;
        private ReaLTaiizor.Controls.MaterialButton REMOVE;
        private ReaLTaiizor.Controls.MetroLabel TIMEDATE;
    }
}

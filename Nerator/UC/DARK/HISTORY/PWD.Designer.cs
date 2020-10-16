
namespace Nerator.UC.DARK.HISTORY
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
            PASSWORD = new ReaLTaiizor.Controls.MetroLabel();
            COPY = new ReaLTaiizor.Controls.MaterialButton();
            REMOVE = new ReaLTaiizor.Controls.MaterialButton();
            TIMEDATE = new ReaLTaiizor.Controls.MetroLabel();
            SuspendLayout();
            // 
            // PASSWORD
            // 
            PASSWORD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            PASSWORD.AutoEllipsis = true;
            PASSWORD.Cursor = System.Windows.Forms.Cursors.Default;
            PASSWORD.Font = new System.Drawing.Font("Segoe UI", 11F);
            PASSWORD.IsDerivedStyle = true;
            PASSWORD.Location = new System.Drawing.Point(80, 0);
            PASSWORD.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            PASSWORD.Name = "PASSWORD";
            PASSWORD.Size = new System.Drawing.Size(142, 36);
            PASSWORD.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            PASSWORD.StyleManager = null;
            PASSWORD.TabIndex = 0;
            PASSWORD.Text = "PASSWORD PASSWORD PASSWORD PASSWORD";
            PASSWORD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            PASSWORD.ThemeAuthor = "Taiizor";
            PASSWORD.ThemeName = "MetroLight";
            PASSWORD.UseCompatibleTextRendering = true;
            // 
            // COPY
            // 
            COPY.AutoSize = false;
            COPY.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            COPY.Cursor = System.Windows.Forms.Cursors.Hand;
            COPY.Depth = 0;
            COPY.Dock = System.Windows.Forms.DockStyle.Right;
            COPY.DrawShadows = false;
            COPY.HighEmphasis = true;
            COPY.Icon = global::Nerator.Properties.Resources.Copy;
            COPY.Location = new System.Drawing.Point(224, 1);
            COPY.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            COPY.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            COPY.Name = "COPY";
            COPY.Size = new System.Drawing.Size(44, 34);
            COPY.TabIndex = 2;
            COPY.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Text;
            COPY.UseAccentColor = false;
            COPY.UseVisualStyleBackColor = true;
            COPY.Click += new System.EventHandler(COPY_Click);
            // 
            // REMOVE
            // 
            REMOVE.AutoSize = false;
            REMOVE.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            REMOVE.Cursor = System.Windows.Forms.Cursors.Hand;
            REMOVE.Depth = 0;
            REMOVE.Dock = System.Windows.Forms.DockStyle.Right;
            REMOVE.DrawShadows = false;
            REMOVE.HighEmphasis = true;
            REMOVE.Icon = global::Nerator.Properties.Resources.Delete;
            REMOVE.Location = new System.Drawing.Point(268, 1);
            REMOVE.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            REMOVE.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            REMOVE.Name = "REMOVE";
            REMOVE.Size = new System.Drawing.Size(44, 34);
            REMOVE.TabIndex = 3;
            REMOVE.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Text;
            REMOVE.UseAccentColor = true;
            REMOVE.UseVisualStyleBackColor = true;
            REMOVE.Click += new System.EventHandler(REMOVE_Click);
            // 
            // TIMEDATE
            // 
            TIMEDATE.Cursor = System.Windows.Forms.Cursors.Default;
            TIMEDATE.Dock = System.Windows.Forms.DockStyle.Left;
            TIMEDATE.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            TIMEDATE.IsDerivedStyle = true;
            TIMEDATE.Location = new System.Drawing.Point(0, 1);
            TIMEDATE.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            TIMEDATE.Name = "TIMEDATE";
            TIMEDATE.Size = new System.Drawing.Size(78, 34);
            TIMEDATE.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            TIMEDATE.StyleManager = null;
            TIMEDATE.TabIndex = 4;
            TIMEDATE.Text = "00:00:00\r\n00.00.0000";
            TIMEDATE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            TIMEDATE.ThemeAuthor = "Taiizor";
            TIMEDATE.ThemeName = "MetroLight";
            // 
            // PWD
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            Controls.Add(TIMEDATE);
            Controls.Add(COPY);
            Controls.Add(PASSWORD);
            Controls.Add(REMOVE);
            Margin = new System.Windows.Forms.Padding(0);
            MaximumSize = new System.Drawing.Size(329, 36);
            MinimumSize = new System.Drawing.Size(312, 36);
            Name = "PWD";
            Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            Size = new System.Drawing.Size(312, 36);
            ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MetroLabel PASSWORD;
        private ReaLTaiizor.Controls.MaterialButton COPY;
        private ReaLTaiizor.Controls.MaterialButton REMOVE;
        private ReaLTaiizor.Controls.MetroLabel TIMEDATE;
    }
}

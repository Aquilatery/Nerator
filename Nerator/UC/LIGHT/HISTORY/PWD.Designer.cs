
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
            this.COPY = new ReaLTaiizor.Controls.MaterialButton();
            this.REMOVE = new ReaLTaiizor.Controls.MaterialButton();
            this.FILL = new System.Windows.Forms.Panel();
            this.TIMEDATE = new ReaLTaiizor.Controls.PoisonLabel();
            this.PASSWORD = new ReaLTaiizor.Controls.PoisonLabel();
            this.FILL.SuspendLayout();
            this.SuspendLayout();
            // 
            // COPY
            // 
            this.COPY.AutoSize = false;
            this.COPY.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.COPY.BackColor = System.Drawing.Color.Transparent;
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
            this.COPY.TabIndex = 3;
            this.COPY.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Text;
            this.COPY.UseAccentColor = false;
            this.COPY.UseVisualStyleBackColor = false;
            this.COPY.Click += new System.EventHandler(this.COPY_Click);
            // 
            // REMOVE
            // 
            this.REMOVE.AutoSize = false;
            this.REMOVE.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.REMOVE.BackColor = System.Drawing.Color.Transparent;
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
            this.REMOVE.TabIndex = 4;
            this.REMOVE.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Text;
            this.REMOVE.UseAccentColor = true;
            this.REMOVE.UseVisualStyleBackColor = false;
            this.REMOVE.Click += new System.EventHandler(this.REMOVE_Click);
            // 
            // FILL
            // 
            this.FILL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.FILL.Controls.Add(this.PASSWORD);
            this.FILL.Controls.Add(this.TIMEDATE);
            this.FILL.Controls.Add(this.COPY);
            this.FILL.Controls.Add(this.REMOVE);
            this.FILL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FILL.Location = new System.Drawing.Point(0, 1);
            this.FILL.Margin = new System.Windows.Forms.Padding(0);
            this.FILL.Name = "FILL";
            this.FILL.Size = new System.Drawing.Size(312, 36);
            this.FILL.TabIndex = 0;
            // 
            // TIMEDATE
            // 
            this.TIMEDATE.BackColor = System.Drawing.Color.Transparent;
            this.TIMEDATE.Dock = System.Windows.Forms.DockStyle.Left;
            this.TIMEDATE.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Small;
            this.TIMEDATE.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Bold;
            this.TIMEDATE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TIMEDATE.Location = new System.Drawing.Point(0, 0);
            this.TIMEDATE.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.TIMEDATE.Name = "TIMEDATE";
            this.TIMEDATE.Size = new System.Drawing.Size(72, 36);
            this.TIMEDATE.TabIndex = 5;
            this.TIMEDATE.Text = "00:00:00\r\n00.00.0000";
            this.TIMEDATE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TIMEDATE.UseCustomBackColor = true;
            this.TIMEDATE.UseCustomForeColor = true;
            // 
            // PASSWORD
            // 
            this.PASSWORD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PASSWORD.BackColor = System.Drawing.Color.Transparent;
            this.PASSWORD.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Bold;
            this.PASSWORD.ForeColor = System.Drawing.Color.SeaGreen;
            this.PASSWORD.Location = new System.Drawing.Point(74, 0);
            this.PASSWORD.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.Size = new System.Drawing.Size(148, 36);
            this.PASSWORD.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Green;
            this.PASSWORD.TabIndex = 6;
            this.PASSWORD.Text = "PASSWORD PASSWORD PASSWORD PASSWORD";
            this.PASSWORD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PASSWORD.UseCustomBackColor = true;
            this.PASSWORD.UseCustomForeColor = true;
            // 
            // PWD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.FILL);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(329, 38);
            this.MinimumSize = new System.Drawing.Size(312, 38);
            this.Name = "PWD";
            this.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.Size = new System.Drawing.Size(312, 38);
            this.FILL.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Controls.MaterialButton COPY;
        private ReaLTaiizor.Controls.MaterialButton REMOVE;
        private System.Windows.Forms.Panel FILL;
        private ReaLTaiizor.Controls.PoisonLabel PASSWORD;
        private ReaLTaiizor.Controls.PoisonLabel TIMEDATE;
    }
}

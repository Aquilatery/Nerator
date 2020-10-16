using System;
using System.Drawing;
using ReaLTaiizor.Forms;
using System.Windows.Forms;
using ReaLTaiizor.Controls;
using Nerator.UC.DARK.HISTORY;

namespace Nerator.UI
{
    public partial class LIGHT : MaterialForm
    {
        public LIGHT()
        {
            InitializeComponent();
            flowLayoutPanel1.Controls.Add(new PWD("53X", "00:00:00", "00.00.0000") { Margin = new Padding(0, 0, 0, 1), Anchor = AnchorStyles.Left | AnchorStyles.Right, Dock = DockStyle.Top });
            flowLayoutPanel1.Controls.Add(new PWD("5EX", "00:00:00", "00.00.0000") { Margin = new Padding(0, 0, 0, 1) });
            flowLayoutPanel1.Controls.Add(new PWD("SEX", "00:00:00", "00.00.0000") { Margin = new Padding(0, 0, 0, 1) });
            flowLayoutPanel1.Controls.Add(new PWD("S3X", "00:00:00", "00.00.0000") { Margin = new Padding(0, 0, 0, 1) });
            flowLayoutPanel1.Controls.Add(new PWD("53X", "00:00:00", "00.00.0000") { Margin = new Padding(0, 0, 0, 1) });
            flowLayoutPanel1.Controls.Add(new PWD("5EX", "00:00:00", "00.00.0000") { Margin = new Padding(0, 0, 0, 1) });
            flowLayoutPanel1.Controls.Add(new PWD("SEX", "00:00:00", "00.00.0000") { Margin = new Padding(0, 0, 0, 1) });
            flowLayoutPanel1.Controls.Add(new PWD("S3X", "00:00:00", "00.00.0000") { Margin = new Padding(0, 0, 0, 1) });
            flowLayoutPanel1.Controls.Add(new PWD("53X", "00:00:00", "00.00.0000") { Margin = new Padding(0, 0, 0, 1) });
            flowLayoutPanel1.Controls.Add(new PWD("5EX", "00:00:00", "00.00.0000") { Margin = new Padding(0, 0, 0, 1) });
            flowLayoutPanel1.Controls.Add(new PWD("SEX", "00:00:00", "00.00.0000") { Margin = new Padding(0, 0, 0, 1) });
            flowLayoutPanel1.Controls.Add(new PWD("S3X", "00:00:00", "00.00.0000") { Margin = new Padding(0, 0, 0, 0) });
        }

        private void CEB_Click(object sender, EventArgs e)
        {
            MaterialMessageBox.Show(flowLayoutPanel1.Width + " - " + flowLayoutPanel1.Height);
        }

        private void CYB_Click(object sender, EventArgs e)
        {

        }
    }
}
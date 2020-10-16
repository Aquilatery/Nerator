using System;
using Nerator.CS;
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
            panel1.Controls.Add(new PWD("53X", "00:00:00", "00.00.0000") { Dock = DockStyle.Top });
            panel1.Controls.Add(new PWD("5EX", "00:00:00", "00.00.0000") { Dock = DockStyle.Top });
            panel1.Controls.Add(new PWD("SEX", "00:00:00", "00.00.0000") { Dock = DockStyle.Top });
            panel1.Controls.Add(new PWD("S3X", "00:00:00", "00.00.0000") { Dock = DockStyle.Top });
            panel1.Controls.Add(new PWD("53X", "00:00:00", "00.00.0000") { Dock = DockStyle.Top });
            panel1.Controls.Add(new PWD("5EX", "00:00:00", "00.00.0000") { Dock = DockStyle.Top });
            panel1.Controls.Add(new PWD("SEX", "00:00:00", "00.00.0000") { Dock = DockStyle.Top });
            panel1.Controls.Add(new PWD("S3X", "00:00:00", "00.00.0000") { Dock = DockStyle.Top });
            panel1.Controls.Add(new PWD("53X", "00:00:00", "00.00.0000") { Dock = DockStyle.Top });
            panel1.Controls.Add(new PWD("5EX", "00:00:00", "00.00.0000") { Dock = DockStyle.Top });
            panel1.Controls.Add(new PWD("SEX", "00:00:00", "00.00.0000") { Dock = DockStyle.Top });
            panel1.Controls.Add(new PWD("S3X", "00:00:00", "00.00.0000") { Dock = DockStyle.Top });
        }

        private void CEB_Click(object sender, EventArgs e)
        {
            MaterialMessageBox.Show(panel1.Width + " - " + panel1.Height);
        }

        private void CYB_Click(object sender, EventArgs e)
        {

        }

        private void STATUST_Tick(object sender, EventArgs e)
        {
            try
            {
                long Result = DateTimeOffset.UtcNow.ToUnixTimeSeconds() - Status.ChangedStatus;
                if (Result >= 3)
                    Status.Message = Status.DefaultStatus;
            }
            catch (Exception Ex)
            {
                Status.Message = "Hata - " + Ex.Source + ": " + Ex.Message;
            }
        }

        private void STATUSMT_Tick(object sender, EventArgs e)
        {
            try
            {
                SSBR.Text = Status.Message;
            }
            catch (Exception Ex)
            {
                Status.Message = "Hata - " + Ex.Source + ": " + Ex.Message;
            }
        }
    }
}
using System;
using Nerator.CS;
using System.Windows.Forms;
using static Nerator.CS.Window;
using static Nerator.CS.Setting;

namespace Nerator.UC.THEME
{
    public partial class DK : UserControl
    {
        public DK()
        {
            InitializeComponent();
        }

        private void DKPL_MouseEnter(object sender, EventArgs e)
        {
            DKPL.EdgeColor = System.Drawing.Color.DodgerBlue;
        }

        private void DKPL_MouseLeave(object sender, EventArgs e)
        {
            DKPL.EdgeColor = System.Drawing.SystemColors.Control;
        }

        private void DKPL_Click(object sender, EventArgs e)
        {
            if (WindowMode == WindowType.LIGHT)
            {
                WindowMode = WindowType.DARK;
                Application.Restart();
            }
            else
            {
                Status.Message = "Dark theme already selected!";
            }
        }
    }
}
using System;
using System.Windows.Forms;
using static Nerator.CS.Window;
using static Nerator.CS.Setting;

namespace Nerator.UC.THEME
{
    public partial class LT : UserControl
    {
        public LT()
        {
            InitializeComponent();
        }

        private void LTPL_MouseEnter(object sender, EventArgs e)
        {
            LTPL.EdgeColor = System.Drawing.Color.DodgerBlue;
        }

        private void LTPL_MouseLeave(object sender, EventArgs e)
        {
            LTPL.EdgeColor = System.Drawing.SystemColors.Control;
        }

        private void LTPL_Click(object sender, EventArgs e)
        {
            if (WindowMode == WindowType.DARK)
            {
                WindowMode = WindowType.LIGHT;
                Application.Restart();
            }
        }
    }
}
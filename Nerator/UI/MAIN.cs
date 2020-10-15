using System;
using Conforyon;
using System.Drawing;
using System.Windows.Forms;
using static Nerator.CS.Generator;

namespace Nerator.UI
{
    public partial class MAIN : Form
    {
        public MAIN()
        {
            InitializeComponent();
        }

        private void Create_B_Click(object sender, EventArgs e)
        {
            Password.Text = Create(Convert.ToInt32(PLength.Value), GET_AC(), GET_SL());
        }

        private void Expand_CheckedChanged(object sender)
        {
            if (Expand.Checked)
                Size = new Size(335, 595);
            else
                Size = new Size(335, 202);
            CenterToScreen();
        }

        private void Copy_B_Click(object sender, EventArgs e)
        {
            ClipBoard.CopyText(Password.Text, true);
            Password.Focus();
        }

        private void TopMost_T_CheckedChanged(object sender)
        {
            TopMost = TopMost_T.Checked;
        }

        private Alphabetic GET_AC()
        {
            if (Just_Big.Checked)
                return Alphabetic.JB;
            else if (Just_Small.Checked)
                return Alphabetic.JS;
            else
                return Alphabetic.BS;
        }

        private Special GET_SL()
        {
            if (Just_Number.Checked)
                return Special.JN;
            else if (Just_Symbol.Checked)
                return Special.JS;
            else
                return Special.NS;
        }
    }
}
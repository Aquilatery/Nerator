using System;
using System.Windows.Forms;
using static Nerator.Generate;

namespace Nerator
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

        private void Copy_B_Click(object sender, EventArgs e)
        {
            Copy(Password.Text);
            Password.Focus();
        }

        private Alphabetic GET_AC()
        {
            if (Just_Big.Checked)
                return Generate.Alphabetic.JB;
            else if (Just_Small.Checked)
                return Generate.Alphabetic.JS;
            else
                return Generate.Alphabetic.BS;
        }

        private Special GET_SL()
        {
            if (Just_Number.Checked)
                return Generate.Special.JN;
            else if (Just_Symbol.Checked)
                return Generate.Special.JS;
            else
                return Generate.Special.NS;
        }
    }
}
using System;
using Conforyon;
using System.Windows.Forms;

namespace Nerator.UC.DARK.HISTORY
{
    public partial class PWD : UserControl
    {
        public PWD(string Password = null, string Time = null, string Date = null)
        {
            if (!string.IsNullOrEmpty(Password) && !string.IsNullOrWhiteSpace(Password) && !string.IsNullOrEmpty(Time) && !string.IsNullOrWhiteSpace(Time) && !string.IsNullOrEmpty(Date) && !string.IsNullOrWhiteSpace(Date))
            {
                InitializeComponent();

                PASSWORD.Text = Password;
                /*
                    oluşturulan şifre güvenliĞi ne ise
                    password labelinin yazı rengi de
                    ona dönüşsün. nasıl olsa güvenlik
                    barı için algoritma yazacan.
                */

                TIMEDATE.Text = Time + "\n" + Date;
            }
            else
                Dispose();
        }

        private void COPY_Click(object sender, EventArgs e)
        {
            ClipBoard.CopyText(PASSWORD.Text, true);
        }

        private void REMOVE_Click(object sender, EventArgs e)
        {
            Dispose(); //Hide - Visible - etc.
        }
    }
}
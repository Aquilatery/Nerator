using System;
using Conforyon;
using Nerator.CS;
using System.Windows.Forms;

namespace Nerator.UC.DARK.HISTORY
{
    public partial class PWD : UserControl
    {
        bool CheckRemove = true;

        public PWD(string Password = null, string Time = null, string Date = null, bool Double = true)
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

                CheckRemove = Double;
            }
            else
                Dispose();
        }

        private void COPY_Click(object sender, EventArgs e)
        {
            ClipBoard.CopyText(PASSWORD.Text, true);
            if (PASSWORD.Text == Clipboard.GetText())
                Status.Message = PASSWORD.Text + " geçmişten başarıyla kopyalandı!";
            else
                Status.Message = PASSWORD.Text + " geçmişten kopyalama başarısız!";
        }

        private void REMOVE_Click(object sender, EventArgs e)
        {
            if (CheckRemove)
            {
                CheckRemove = false;
                Status.Message = "Silmek istiyorsanız bir kere daha tıklayın!";
            }
            else
            {
                Status.Message = PASSWORD.Text + " geçmişten başarıyla silindi!";
                Dispose(); //Hide - Visible - etc.
            }
        }
    }
}
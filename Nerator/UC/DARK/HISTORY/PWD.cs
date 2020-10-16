using System;
using Conforyon;
using Nerator.CS;
using System.Windows.Forms;
using static Nerator.CS.History;

namespace Nerator.UC.DARK.HISTORY
{
    public partial class PWD : UserControl
    {
        private bool CheckRemove = true;

        public PWD(string Password = null, string Time = null, string Date = null, bool Check = true)
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

                CheckRemove = Check;
            }
            else
            {
                Dispose();
            }
        }

        private void COPY_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetText() != PASSWORD.Text)
            {
                ClipBoard.CopyText(PASSWORD.Text, true);
                if (PASSWORD.Text == Clipboard.GetText())
                {
                    Status.Message = PASSWORD.Text + " geçmişten başarıyla kopyalandı!";
                }
                else
                {
                    Status.Message = PASSWORD.Text + " geçmişten kopyalama başarısız!";
                }
            }
        }

        private void REMOVE_Click(object sender, EventArgs e)
        {
            if (CheckRemove)
            {
                CheckRemove = false;
                Status.Message = "Geçmişten silmek istiyorsanız tekrar tıklayın!";
            }
            else
            {
                if (Remove(HistoryFileName, PASSWORD.Text))
                {
                    Status.Message = PASSWORD.Text + " geçmişten başarıyla silindi!";
                    Dispose(); //Hide - Visible - etc.
                }
                else
                    Status.Message = PASSWORD.Text + " geçmişten silinemedi!";
            }
        }
    }
}
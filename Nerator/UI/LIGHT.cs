using System;
using Conforyon;
using Nerator.CS;
using ReaLTaiizor.Forms;
using System.Windows.Forms;
using Nerator.UC.LIGHT.HISTORY;
using static Nerator.CS.History;
using static Nerator.CS.Setting;
using System.Collections.Generic;
using static Nerator.CS.Variable;
using static Nerator.CS.Generator;

namespace Nerator.UI
{
    public partial class LIGHT : MaterialForm
    {
        public LIGHT()
        {
            InitializeComponent();
            HistoryLoad();
        }

        private void CEB_Click(object sender, EventArgs e)
        {
            PWDTB.Text = Create(GetInt("15", PasswordLenght, MinimumPasswordLenght, MaximumPasswordLenght), AlphabeticMode, SpecialMode);
            if (HYS.Checked)
            {
                Add(HistoryFileName, PWDTB.Text, DefaultDateTime);
                HistoryAdd(PWDTB.Text, GetTime(DefaultDateTime, DefaultDateTime), GetDate(DefaultDateTime, DefaultDateTime));
            }
            Random RM = new Random();
            PLPB.Value = RM.Next(PLPB.Maximum);
            Status.Message = "Üretilen yeni şifre: " + PWDTB.Text;
        }

        private void CYB_Click(object sender, EventArgs e)
        {
            if (PWDTB.Text != Clipboard.GetText())
            {
                ClipBoard.CopyText(PWDTB.Text, true);
                if (PWDTB.Text == Clipboard.GetText())
                {
                    Status.Message = PWDTB.Text + " başarıyla kopyalandı!";
                    PWDTB.Focus();
                }
                else
                {
                    Status.Message = PWDTB.Text + " kopyalama başarısız!";
                }
            }
        }

        private void HistoryAdd(string Password, string Time, string Date, DockStyle Style = DockStyle.Top)
        {
            HYP.Controls.Add(new PWD(Password, Time, Date) { Dock = Style });
        }

        private void HistoryLoad()
        {
            if (HYP.Controls.Count > 1)
            {
                HYP.Controls.Clear();
            }

            new History(HistoryFileName);

            Dictionary<string, string> History = Loader(HistoryFileName);

            foreach (string PKey in History.Keys)
            {
                if (++ListPasswordCount <= MaximumHistoryList)
                {
                    HistoryAdd(PKey, GetTime(GetLong(History[PKey], DefaultDateTime), DefaultDateTime), GetDate(GetLong(History[PKey], DefaultDateTime), DefaultDateTime));
                }
                else
                {
                    break;
                }
            }

            History.Clear();
        }

        private void STATUST_Tick(object sender, EventArgs e)
        {
            try
            {
                long Result = DateTimeOffset.UtcNow.ToUnixTimeSeconds() - Status.ChangedStatus;
                if (Result >= 3)
                {
                    Status.Message = Status.DefaultStatus;
                }
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
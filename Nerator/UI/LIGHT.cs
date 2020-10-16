using System;
using Conforyon;
using Nerator.CS;
using ReaLTaiizor.Forms;
using System.Windows.Forms;
using Nerator.UC.DARK.HISTORY;
using static Nerator.CS.History;
using static Nerator.CS.Setting;
using static Nerator.CS.Variable;
using static Nerator.CS.Generator;
using System.Collections.Generic;

namespace Nerator.UI
{
    public partial class LIGHT : MaterialForm
    {
        public LIGHT()
        {
            InitializeComponent();
        }

        private void CEB_Click(object sender, EventArgs e)
        {
            PWDTB.Text = Create(GetInt("15", PasswordLenght, MinimumPasswordLenght, MaximumPasswordLenght), AlphabeticMode, SpecialMode);
            if (HYS.Checked)
            {
                Add(HistoryFileName, PWDTB.Text, DefaultDateTime);
                HYP.Controls.Add(new PWD(PWDTB.Text, "00:00:00", "00.00.0000") { Dock = DockStyle.Top });
            }
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

        private void MTC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MTC.SelectedTab == History)
                HistoryLoad();
        }

        private void HistoryLoad()
        {
            if (HYP.Controls.Count > 1)
                HYP.Controls.Clear();

            new History(HistoryFileName);

            Dictionary<string, string> History = Loader(HistoryFileName);

            foreach (string PKey in History.Keys)
            {
                HYP.Controls.Add(new PWD(PKey, "00:00:00", "00.00.0000") { Dock = DockStyle.Top });
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
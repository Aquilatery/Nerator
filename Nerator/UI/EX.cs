﻿using System;
using Conforyon;
using Nerator.CS;
using System.Drawing;
using System.Windows.Forms;
using static Nerator.CS.Setting;
using static Nerator.CS.Variable;
using static Nerator.CS.Generator;
using static Nerator.CS.Character;

namespace Nerator.UI
{
    public partial class EX : Form
    {
        public EX()
        {
            InitializeComponent();
            LoadConfig();
        }

        private void Create_B_Click(object sender, EventArgs e)
        {
            Password.Text = Create(GetInt(PLength.Value.ToString(), PasswordLenght, MinimumPasswordLenght, MaximumPasswordLenght), AlphabeticMode, SpecialMode);
        }

        private void Expand_CheckedChanged(object sender)
        {
            if (Expand.Checked)
            {
                Size = new Size(335, 595);
            }
            else
            {
                Size = new Size(335, 202);
            }

            EXExpandMode = Expand.Checked;
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
            TopMostMode = TopMost;
        }

        private void Alphabetic_CheckedChanged(object sender)
        {
            if (Just_Big.Checked)
            {
                AlphabeticMode = AlphabeticType.JB;
            }
            else if (Just_Small.Checked)
            {
                AlphabeticMode = AlphabeticType.JS;
            }
            else
            {
                AlphabeticMode = AlphabeticType.BS;
            }
        }

        private void Special_CheckedChanged(object sender)
        {
            if (Just_Number.Checked)
            {
                SpecialMode = SpecialType.JN;
            }
            else if (Just_Symbol.Checked)
            {
                SpecialMode = SpecialType.JS;
            }
            else
            {
                SpecialMode = SpecialType.NS;
            }
        }

        private void LoadConfig()
        {
            Expand.Checked = EXExpandMode;
            if (Expand.Checked)
            {
                Expand_CheckedChanged(null);
            }

            PLength.Value = PasswordLenght;
            TopMost_T.Checked = TopMostMode;
            switch (AlphabeticMode)
            {
                case AlphabeticType.JB:
                    Just_Big.Checked = true;
                    break;
                case AlphabeticType.JS:
                    Just_Small.Checked = true;
                    break;
                default:
                    Big_Small.Checked = true;
                    break;
            }
            switch (SpecialMode)
            {
                case SpecialType.JN:
                    Just_Number.Checked = true;
                    break;
                case SpecialType.JS:
                    Just_Symbol.Checked = true;
                    break;
                default:
                    Number_Symbol.Checked = true;
                    break;
            }
        }

        private void EX_FormClosed(object sender, FormClosedEventArgs e)
        {
            PasswordLenght = GetInt(PLength.Value.ToString(), PasswordLenght, MinimumPasswordLenght, MaximumPasswordLenght);
            Save(ConfigFileName);
        }
    }
}
using System;
using System.Windows.Forms;

namespace Nerator
{
    public static class Generator
    {
        private static Random RM = new Random();

        private static string AC_JB = "ABCDEFGHIJKLMNOPRSTUVYZQWX";
        private static string AC_JS = "abcdefghijklmnoprstuvyzqwx";
        private static string AC_BS = AC_JB + AC_JS;

        private static string SL_JN = "111222333444555666777888999000";
        private static string SL_JS = "!'\"^+%&/=?_@€ß*-+#\\<|>.,~½£$({[]})Æé";
        private static string SL_NS = SL_JN + SL_JS;

        public static void Copy(string Text)
        {
            Clipboard.SetDataObject(Text, false);
        }

        public enum Alphabetic
        {
            BS, JB, JS
        }

        public enum Special
        {
            NS, JN, JS
        }

        public static string Create(int Length, Alphabetic AC, Special SL)
        {
            string Dictionary = null;
            switch (AC)
            {
                case Alphabetic.BS:
                    Dictionary = AC_BS;
                    break;
                case Alphabetic.JB:
                    Dictionary = AC_JB;
                    break;
                case Alphabetic.JS:
                    Dictionary = AC_JS;
                    break;
            }
            switch (SL)
            {
                case Special.NS:
                    Dictionary += SL_NS;
                    break;
                case Special.JN:
                    Dictionary += SL_JN;
                    break;
                case Special.JS:
                    Dictionary += SL_JS;
                    break;
            }
            return Shuffle_Mode_1(Dictionary).Substring(0, Length);
        }

        private static string Shuffle_Mode_1(string Text)
        {
            char[] Array = Text.ToCharArray();
            int Number = Array.Length;
            while (Number > 1)
            {
                Number--;
                int Result = RM.Next(Number + 1);
                var Value = Array[Result];
                Array[Result] = Array[Number];
                Array[Number] = Value;
            }
            return new string(Array);
        }

        private static string Shuffle_Mode_2(string Text)
        {
            string Result = null;
            int Size = Text.Length;
            int[] RandomArray = new int[Size];

            for (int C = 0; C < Size; C++)
                RandomArray[C] = C;

            Shuffle_Helper(RandomArray);

            for (int C = 0; C < Size; C++)
                Result += Text[RandomArray[C]];

            return Result;
        }

        private static void Shuffle_Helper(int[] Array)
        {
            int Size = Array.Length;
            int Random;
            int Temp;

            for (int C = 0; C < Size; C++)
            {
                Random = C + (int)(RM.NextDouble() * (Size - C));

                Temp = Array[Random];
                Array[Random] = Array[C];
                Array[C] = Temp;
            }
        }
    }
}
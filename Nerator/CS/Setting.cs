using System.IO;
using Newtonsoft.Json;
using static Nerator.CS.Page;
using static Nerator.CS.Window;
using static Nerator.CS.Variable;
using System.Collections.Generic;
using static Nerator.CS.Character;

namespace Nerator.CS
{
    public class Setting
    {
        public static string ConfigFileName => "Config.json";
        public static int MinimumPasswordLenght => 6;
        public static int MaximumPasswordLenght => 50;

        public Setting(string ConfigFileName)
        {
            if (File.Exists(ConfigFileName))
            {
                Load(ConfigFileName);
            }
            else
            {
                Save(ConfigFileName);
            }
        }

        private static void Load(string ConfigFileName)
        {
            string SS = File.ReadAllText(ConfigFileName);
            if (!string.IsNullOrEmpty(SS) && !string.IsNullOrWhiteSpace(SS))
            {
                Dictionary<string, string> Settings = JsonConvert.DeserializeObject<Dictionary<string, string>>(SS);
                if (Settings.ContainsKey("PageMode") && Settings.ContainsKey("WindowMode") && Settings.ContainsKey("SpecialMode") && Settings.ContainsKey("TopMostMode") && Settings.ContainsKey("HistoryMode") && Settings.ContainsKey("AlphabeticMode") && Settings.ContainsKey("EXExpandMode") && Settings.ContainsKey("PasswordLenght"))
                {
                    PageMode = GetPageMode(Settings["PageMode"]);
                    WindowMode = GetWindowMode(Settings["WindowMode"]);
                    SpecialMode = GetSpecialMode(Settings["SpecialMode"]);
                    TopMostMode = GetBoolean(Settings["TopMostMode"], TopMostMode);
                    HistoryMode = GetBoolean(Settings["HistoryMode"], HistoryMode);
                    AlphabeticMode = GetAlphabeticMode(Settings["AlphabeticMode"]);
                    EXExpandMode = GetBoolean(Settings["EXExpandMode"], EXExpandMode);
                    PasswordLenght = GetInt(Settings["PasswordLenght"], PasswordLenght, MinimumPasswordLenght, MaximumPasswordLenght);
                }
            }
            Save(ConfigFileName);
        }

        public static void Save(string ConfigFileName)
        {
            Dictionary<string, string> Settings = new Dictionary<string, string>()
            {
                { "PageMode" , GetPageMode(PageMode) },
                { "WindowMode" , GetWindowMode(WindowMode) },
                { "SpecialMode" , GetSpecialMode(SpecialMode) },
                { "TopMostMode" , GetString(TopMostMode, TopMostMode) },
                { "HistoryMode" , GetString(HistoryMode, HistoryMode) },
                { "AlphabeticMode" , GetAlphabeticMode(AlphabeticMode) },
                { "EXExpandMode" , GetString(EXExpandMode, EXExpandMode) },
                { "PasswordLenght" , GetString(PasswordLenght, PasswordLenght) }
            };
            File.WriteAllText(ConfigFileName, JsonConvert.SerializeObject(Settings, Formatting.Indented));
        }

        private static WindowType _WindowMode = WindowType.LIGHT;
        public static WindowType WindowMode
        {
            get => _WindowMode;
            set => _WindowMode = value;
        }

        private static bool _HistoryMode = true;
        public static bool HistoryMode
        {
            get => _HistoryMode;
            set => _HistoryMode = value;
        }

        private static int _PasswordLenght = 15;
        public static int PasswordLenght
        {
            get => _PasswordLenght;
            set => _PasswordLenght = value;
        }

        private static AlphabeticType _AlphabeticMode = AlphabeticType.BS;
        public static AlphabeticType AlphabeticMode
        {
            get => _AlphabeticMode;
            set => _AlphabeticMode = value;
        }

        private static SpecialType _SpecialMode = SpecialType.NS;
        public static SpecialType SpecialMode
        {
            get => _SpecialMode;
            set => _SpecialMode = value;
        }

        private static bool _TopMostMode;
        public static bool TopMostMode
        {
            get => _TopMostMode;
            set => _TopMostMode = value;
        }

        private static bool _EXExpandMode;
        public static bool EXExpandMode
        {
            get => _EXExpandMode;
            set => _EXExpandMode = value;
        }

        private static PageType _PageMode = PageType.Generate;
        public static PageType PageMode
        {
            get => _PageMode;
            set => _PageMode = value;
        }
    }
}
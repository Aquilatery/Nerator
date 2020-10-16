using System.IO;
using Newtonsoft.Json;
using static Nerator.CS.Window;
using static Nerator.CS.Variable;
using System.Collections.Generic;
using static Nerator.CS.Character;

namespace Nerator.CS
{
    public class Setting
    {
        public static string ConfigFileName => "Config.json";

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

        private void Load(string ConfigFileName)
        {
            string SS = File.ReadAllText(ConfigFileName);
            if (!string.IsNullOrEmpty(SS) && !string.IsNullOrWhiteSpace(SS))
            {
                Dictionary<string, string> Settings = JsonConvert.DeserializeObject<Dictionary<string, string>>(SS);
                if (Settings.ContainsKey("TopMost") && Settings.ContainsKey("WindowMode") && Settings.ContainsKey("SpecialMode") && Settings.ContainsKey("HistoryMode") && Settings.ContainsKey("AlphabeticMode") && Settings.ContainsKey("PasswordLenght"))
                {
                    TopMost = GetBoolean(Settings["TopMost"], TopMost);
                    WindowMode = GetWindowMode(Settings["WindowMode"]);
                    SpecialMode = GetSpecialMode(Settings["SpecialMode"]);
                    HistoryMode = GetBoolean(Settings["HistoryMode"], HistoryMode);
                    AlphabeticMode = GetAlphabeticMode(Settings["AlphabeticMode"]);
                    PasswordLenght = GetInt(Settings["WindowMode"], PasswordLenght, 6, 50);
                }
            }
            Save(ConfigFileName);
        }

        public void Save(string ConfigFileName)
        {
            Dictionary<string, string> Settings = new Dictionary<string, string>()
            {
                { "TopMost" , GetString(TopMost, TopMost) },
                { "WindowMode" , GetWindowMode(WindowMode) },
                { "SpecialMode" , GetSpecialMode(SpecialMode) },
                { "HistoryMode" , GetString(HistoryMode, HistoryMode) },
                { "AlphabeticMode" , GetAlphabeticMode(AlphabeticMode) },
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

        private static bool _TopMost = false;
        public static bool TopMost
        {
            get => _TopMost;
            set => _TopMost = value;
        }
    }
}
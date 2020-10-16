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
            if (string.IsNullOrEmpty(SS) || string.IsNullOrWhiteSpace(SS))
            {
                Save(ConfigFileName);
            }
            else
            {
                Dictionary<string, string> Settings = JsonConvert.DeserializeObject<Dictionary<string, string>>(SS);
                if (Settings.ContainsKey("WindowMode") && Settings.ContainsKey("HistoryMode") && Settings.ContainsKey("AlphabeticMode") && Settings.ContainsKey("PasswordLenght"))
                {
                    WindowMode = GetWindowMode(Settings["WindowMode"]);
                    HistoryMode = GetBoolean(Settings["HistoryMode"], HistoryMode);
                    AlphabeticMode = GetAlphabeticMode(Settings["AlphabeticMode"]);
                    PasswordLenght = GetInt(Settings["WindowMode"], PasswordLenght, 6, 50);
                }
                else
                {
                    Save(ConfigFileName);
                }
            }
        }

        public void Save(string ConfigFileName)
        {
            Dictionary<string, string> Settings = new Dictionary<string, string>()
            {
                { "WindowMode" , GetWindowMode(WindowMode) },
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
    }
}
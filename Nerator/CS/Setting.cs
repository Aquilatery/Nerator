using System.IO;
using Newtonsoft.Json;
using static Nerator.CS.Window;

namespace Nerator.CS
{
    public class Setting
    {
        public Setting(string ConfigFileName = "Config.json")
        {
            if (File.Exists(ConfigFileName))
                Save(ConfigFileName);
            else
                Load(ConfigFileName);
        }

        private void Load(string ConfigFileName)
        {

        }

        private void Save(string ConfigFileName)
        {

        }

        private static WindowType _WindowMode = WindowType.TEST;
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
    }
}
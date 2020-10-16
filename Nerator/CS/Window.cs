using Nerator.UI;
using System.Windows.Forms;

namespace Nerator.CS
{
    public static class Window
    {
        public enum WindowType
        {
            EX,
            DARK,
            LIGHT
        }

        public static WindowType GetWindowMode(string Type)
        {
            switch (Type)
            {
                case "EX":
                    return WindowType.EX;
                case "DARK":
                    return WindowType.DARK;
                default:
                    return WindowType.LIGHT;
            }
        }

        public static string GetWindowMode(WindowType Type)
        {
            switch (Type)
            {
                case WindowType.EX:
                    return "EX";
                case WindowType.DARK:
                    return "DARK";
                default:
                    return "LIGHT";
            }
        }

        public static Form OpenWindowMode(WindowType Type)
        {
            switch (Type)
            {
                case WindowType.EX:
                    return new EX();
                case WindowType.DARK:
                    return new DARK();
                default:
                    return new LIGHT();
            }
        }
    }
}
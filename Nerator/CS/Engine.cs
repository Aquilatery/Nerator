using System.Windows.Forms;
using static Nerator.CS.Window;
using static Nerator.CS.Setting;

namespace Nerator.CS
{
    public class Engine
    {
        public Engine()
        {
            new Setting(ConfigFileName);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(OpenWindowMode(WindowMode));
        }
    }
}
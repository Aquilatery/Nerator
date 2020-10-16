using System.Windows.Forms;
using static Nerator.CS.Window;
using static Nerator.CS.Setting;

namespace Nerator.CS
{
    public class Engine
    {
        public Engine()
        {
            try
            {
                new Setting(ConfigFileName);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(OpenWindowMode(WindowMode));
            }
            catch (System.Exception Ex)
            {
                MessageBox.Show(Ex.Message + "\n" + Ex.StackTrace);
            }
        }
    }
}
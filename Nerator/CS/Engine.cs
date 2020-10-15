using Nerator.UI;
using System.Windows.Forms;
using static Nerator.CS.Window;
using static Nerator.CS.Setting;

namespace Nerator.CS
{
    public class Engine
    {
        public Engine()
        {
            Form SUI = null;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            switch (WindowMode)
            {
                case WindowType.MAIN:
                    SUI = new MAIN();
                    break;
                case WindowType.TESTER:
                    SUI = new TESTER();
                    break;
                default:
                    SUI = new TEST();
                    break;
            }

            Application.Run(SUI);
        }
    }
}
using System;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using static Nerator.CS.Window;
using System.Collections.Generic;

namespace Nerator.CS
{
    public class Setting
    {
        private static WindowType _WindowMode = WindowType.TEST;
        public static WindowType WindowMode
        {
            get => _WindowMode;
            set => _WindowMode = value;
        }
    }
}
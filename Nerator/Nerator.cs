using System;
using Nerator.CS;

namespace Nerator
{
    internal static class Nerator
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [MTAThread]
        private static void Main()
        {
            new Engine();
        }
    }
}
#region Imports

using System;
using System.Runtime.InteropServices;

#endregion

namespace Harley.Native
{
    #region WinAPINative

    internal class WinAPI
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int AnimateWindow(IntPtr hwand, int dwTime, int dwFlag);
    }

    #endregion
}
#region Imports

using Harley.Enum.Transition;
using Harley.Native;
using System;

#endregion

namespace Harley.Transition.Form
{
    #region FormAnimateTransition

    public class Animate
    {
        public static void Window(IntPtr hwand, Speed dwTime, Direction dwFlag)
        {
            _ = WinAPI.AnimateWindow(hwand, (int)dwTime, (int)dwFlag);
        }
    }

    #endregion
}
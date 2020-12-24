#region Imports

using System;
using Harley.Native;
using Harley.Enum.Transition;

#endregion

namespace Harley.Transition.Form
{
    #region FormAnimateTransition

    public class Animate
    {
        public static void Window(IntPtr hwand, Speed dwTime, Direction dwFlag)
        {
            WinAPI.AnimateWindow(hwand, (int)dwTime, (int)dwFlag);
        }
    }

    #endregion
}
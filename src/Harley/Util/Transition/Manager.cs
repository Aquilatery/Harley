using System;
using System.Linq;
using System.Text;
using System.Timers;
using System.Collections.Generic;

namespace Harley.Util.Transition
{
    public class Manager
    {
        private readonly Timer Timer = new Timer
        {
            Interval = 5,
            Enabled = false
        };
    }
}
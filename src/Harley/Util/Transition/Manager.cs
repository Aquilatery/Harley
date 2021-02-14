using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace Harley.Util.Transition
{
    public class Manager
    {
        private readonly Timer Timer = new()
        {
            Interval = 5,
            Enabled = false
        };
    }
}
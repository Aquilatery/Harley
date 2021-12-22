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
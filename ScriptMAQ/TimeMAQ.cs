using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptMAQ
{
    public static class TimeMAQ
    {
        private static Stopwatch deltaWatch = new Stopwatch();
        private static Stopwatch startWatch = new Stopwatch();

        static TimeMAQ()
        {
            deltaWatch.Start();
            startWatch.Start();
        }

        public static double Elapsed()
        {
            return startWatch.ElapsedMilliseconds;
        }

        public static double TimeDelta()
        {
            double elapsed = deltaWatch.ElapsedMilliseconds;
            deltaWatch.Restart();
            return elapsed;
        }
    }
}

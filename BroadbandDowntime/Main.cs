using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace BroadbandDowntime
{
    class Main
    {
        public static void loop()
        {
            while (true)
            {
                CheckIfOnline();
                Thread.Sleep(1000 * 60);
            }
        }

        private static void CheckIfOnline()
        {
            throw new NotImplementedException();
        }
    }
}

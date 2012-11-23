using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;

namespace BroadbandDowntime
{
    public partial class BroadbandDowntime : ServiceBase
    {
        public BroadbandDowntime()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            ThreadStart ts = new ThreadStart(delegate { Main.loop(); });
            new Thread(ts).Start();
        }

        protected override void OnStop()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Net;

namespace BroadbandDowntime
{
    class Main
    {
        public static void Loop()
        {
            WebRequest wr = WebRequest.Create("http://www.google.com");
            Stream str = wr.GetResponse().GetResponseStream();
            StreamReader reader = new StreamReader(str);
            String respText = reader.ReadToEnd();
            TextWriter tw = new StreamWriter(Path.GetTempFileName());
            tw.WriteLine(respText);
            tw.Close();
            //while (true)
            //{
            //    CheckIfOnline();
            //    Thread.Sleep(1000 * 60);
            //}
        }

        private static void CheckIfOnline()
        {
            throw new NotImplementedException();
        }
    }
}

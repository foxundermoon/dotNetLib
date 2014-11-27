using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoxundermoonLib.Diagnostics;
using System.Threading;

namespace FoxundermoonLibTests
{
    class TestProgrom
    {
        //[STAThread]
        public static   void main(string[] args)
        {
            TraceManager.StartTrace();
            new Thread(() =>
            {
                new Temp.Form1().Show();
            }).Start();
        }
    }
}

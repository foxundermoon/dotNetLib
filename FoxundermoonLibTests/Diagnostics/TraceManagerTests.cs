using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoxundermoonLib.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
namespace FoxundermoonLib.Diagnostics.Tests
{
    [TestClass()]
    public class TraceManagerTests
    {
        [TestInitialize]
        public void  setup()
        {
            TraceManager.StartTrace();
            

        }
        [TestMethod()]
        public void StartTraceTest()
        {

            Trace.Write("111111111111");
            //Assert.Fail();
        }

        [TestMethod()]
        public void StartTraceTest1()
        {
            Trace.Write("111111111111");
            //Assert.Fail();
        }
    }
}

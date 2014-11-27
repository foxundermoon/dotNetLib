using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace FoxundermoonLibTests.MyTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Thread s1 =new Thread(() =>
            {
                new Temp.Form1().Show();
            });
            s1.Start();
            Thread.Sleep(1000000);
        }
    }
}

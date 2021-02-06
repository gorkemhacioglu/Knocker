using Microsoft.VisualStudio.TestTools.UnitTesting;
using KnockerCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KnockerCore.Tests
{
    [TestClass()]
    public class CoreTests
    {
        [TestMethod()]
        public void IsPortOpenTest()
        {
            Core core = new Core();

            var ret = core.IsPortOpen("1.1.1.1", 80);
            Assert.AreEqual(true, ret);
        }

        [TestMethod()]
        public void StartScanningTest()
        {
            Core core = new Core();

            try
            {
                bool ret = core.StartScanning("1.1.1.1", "1.1.1.2", 80, 81, 50, new System.Threading.CancellationToken());
                Assert.AreEqual(true, ret);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void StartTakingFromBagTest()
        {
            try
            {
                Core core = new Core();

                core.StartTakingFromBag();
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
    }
}
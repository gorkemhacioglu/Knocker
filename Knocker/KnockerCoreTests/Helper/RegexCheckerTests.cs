using Microsoft.VisualStudio.TestTools.UnitTesting;
using KnockerCore.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace KnockerCore.Helper.Tests
{
    [TestClass()]
    public class RegexCheckerTests
    {
        [TestMethod()]
        public void CheckIpAddressTest()
        {

            try
            {
                RegexChecker regex = new RegexChecker();

                if (regex.CheckIpAddress("1.1.1.1") != true)
                    Assert.Fail();

                if (regex.CheckIpAddress("a") != false)
                    Assert.Fail();

                if (regex.CheckIpAddress("") != false)
                    Assert.Fail();

                if (regex.CheckIpAddress("a.1.1.1") != false)
                    Assert.Fail();
            }
            catch (Exception)
            {
                Assert.Fail();
            }


        }

        [TestMethod()]
        public void CheckPortValueTest()
        {
            try
            {
                RegexChecker regex = new RegexChecker();

                if (regex.CheckPortValue("900000") != false)
                    Assert.Fail();

                if (regex.CheckPortValue("3000") != true)
                    Assert.Fail();

                if (regex.CheckPortValue("") != false)
                    Assert.Fail();

                if (regex.CheckPortValue("a") != false)
                    Assert.Fail();
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
    }
}
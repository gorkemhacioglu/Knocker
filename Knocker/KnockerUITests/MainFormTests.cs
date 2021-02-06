using Knocker;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Knocker.Tests
{
    [TestClass()]
    public class MainFormTests
    {
        [TestMethod()]
        public void GetFromResourceTest()
        {
            MainForm form = new MainForm();

            var ret = form.GetFromResource("Running");

            Assert.AreEqual(ret, "Running\r\n");
        }

        [TestMethod()]
        public void DeleteFromInfoTest()
        {
            try
            {
                MainForm form = new MainForm();

                form.DeleteFromInfo("Running");

                form.DeleteFromInfo("ItWontFindThisKeyOnResource");
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void btnExportToExcel_ClickTest()
        {
            try
            {
                MainForm form = new MainForm();

                form.btnExportToExcel_Click(null, null);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void AddToInfoTest()
        {
            try
            {
                MainForm form = new MainForm();

                form.AddToInfo("Running", true);
                form.AddToInfo("Running", false);
                form.AddToInfo("Running", null);
                form.AddToInfo("ItWontFindThisKeyOnResource", true);
                form.AddToInfo("ItWontFindThisKeyOnResource", false);
                form.AddToInfo("ItWontFindThisKeyOnResource", null);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
    }
}
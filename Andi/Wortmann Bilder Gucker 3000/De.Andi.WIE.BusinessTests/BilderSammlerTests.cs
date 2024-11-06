using Microsoft.VisualStudio.TestTools.UnitTesting;
using De.Andi.WIE.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;

namespace De.Andi.WIE.Business.Tests
{
    [TestClass()]
    public class BilderSammlerTests
    {
        [TestMethod()]
        public void StartTest()
        {
            var bs = new BilderSammler();

            bs.Start();
            Assert.IsTrue(bs.Bilders.Count >= 5);
        }

        [TestMethod()]
        public void WurzelTest()
        {
            Logger.LogMessage("Gefunden Wurzeln:");
            var bs = new BilderSammler();
            foreach (var item in bs.WurzelVerzeichnisse)
            {
                Logger.LogMessage(item);
            }
        }
    }
}
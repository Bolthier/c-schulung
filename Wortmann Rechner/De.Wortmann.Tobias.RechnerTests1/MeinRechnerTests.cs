using Microsoft.VisualStudio.TestTools.UnitTesting;
using De.Wortmann.Tobias.Rechner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De.Wortmann.Tobias.Rechner.Tests
{
    [TestClass()]
    public class MeinRechnerTests
    {
        [TestMethod()]
        public void AlleTest()
        {
            double erg = new MeinRechner().Plus(222).Mal(2).Minus(111).Mal(2).Summe;
            Assert.IsTrue(erg == 666);
        }
    }
}
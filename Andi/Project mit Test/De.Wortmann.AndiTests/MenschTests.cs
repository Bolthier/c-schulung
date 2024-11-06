using Microsoft.VisualStudio.TestTools.UnitTesting;
using De.Wortmann.Andi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De.Wortmann.Andi.Tests
{
    [TestClass()]
    public class MenschTests
    {
        [TestMethod()]
        public void MenschTest()
        {
            Mensch m=new Mensch();
            m.Groesse = 1.86;
            m.Gewicht = 95;
            Assert.AreEqual(27.46, m.Bmi, .1);
            Assert.IsTrue(m.Status==STATUS.ADIPOSITAS);
        }
    }
}
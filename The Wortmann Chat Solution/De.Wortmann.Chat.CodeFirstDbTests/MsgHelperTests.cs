using Microsoft.VisualStudio.TestTools.UnitTesting;
using De.Wortmann.Chat.CodeFirstDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De.Wortmann.Chat.CodeFirstDb.Tests
{
    [TestClass()]
    public class MsgHelperTests
    {
        [TestMethod()]
        public void AddMsgTest()
        {
            new MsgHelper().AddMsg("Hallo", "Klausi2");
        }
    }
}
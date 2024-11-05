using Microsoft.VisualStudio.TestTools.UnitTesting;
using De.Wortmann.Chat.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De.Wortmann.Chat.Db.Tests
{
    [TestClass()]
    public class MsgHelperTests
    {
        [TestMethod()]
        public void AddMsgTest()
        {
            using (var h = new MsgHelper())
            {
                int anz = h.CountMsgs;
                h.AddMsg("Testnachricht", "Hallo", "Tobi");
                Assert.AreEqual(anz + 1, h.CountMsgs);
            }
        }

        [TestMethod()]
        public void DeleteMsgTest()
        {
            using (var h = new MsgHelper())
            {
                int anz = h.CountMsgs;
                h.AddMsg("Testnachricht", "Hallo", "Tobi");
                h.DeleteMsg(h.Ctx.Chats.First().Id);
                Assert.AreEqual(anz, h.CountMsgs);
            }
        }
    }
}
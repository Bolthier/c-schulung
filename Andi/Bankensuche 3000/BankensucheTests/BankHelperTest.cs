using De.Wortmann.Bank.Implementations;
using De.Wortmann.Banken.Interfaces;

namespace BankensucheTests
{
    [TestClass]
    public class BankHelperTest
    {
        [TestMethod]
        public void TestStartSuche()
        {
            BankHelper toTest = new DateisystemBankHelper();
            toTest.StartSuche("32609");
            Assert.IsTrue(toTest.Result.Length>=2);
        }
    }
}
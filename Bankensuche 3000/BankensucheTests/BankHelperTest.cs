using De.Wortmann.Bank.Implementation;
using De.Wortmann.Banken.Interfaces;

namespace BankensucheTests
{
    [TestClass]
    public class BankHelperTest
    {
        [TestMethod]
        public void TestStartSuche()
        {
            BankHelper toTest = new DateiSystemBankHelper();
            toTest.StartSuche("32609");
            Assert.IsTrue(toTest.Result.Length >= 3);
        }
    }
}
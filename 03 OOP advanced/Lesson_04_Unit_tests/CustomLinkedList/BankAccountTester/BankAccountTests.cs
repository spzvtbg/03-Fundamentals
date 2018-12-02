namespace BankAccountTester
{
    using BankAccount;
    using NUnit.Framework;

    [TestFixture]
    public class BankAccountTests
    {
        [Test]
        public void DepositShouldIncreaseBalance()
        {
            var bankAccount = new Account();
            bankAccount.Deposit(10);

            //Assert.That(bankAccount.Balance, Is.EqualTo(100));
            Assert.AreEqual(10, bankAccount.Balance);
        }
    }
}

using LoveMyMoney.Domain.AggregateRoots;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LoveMyMoney.Domain.UnitTests
{
    /// <summary>
    /// Test methods for Account entity.
    /// </summary>
    [TestClass]
    public class AccountTests
    {
        public AccountTests()
        {
            // TODO: Add constructor logic if necessary.
        }

        /// <summary> Runs before each test. </summary>
        [TestInitialize()]
        public void AccountTestsInitialize() { }


        /// <summary> Code that run after each test. </summary>
        [TestCleanup()]
        public void AccountTestsCleanup()
        {
            // TODO: clean this up;
        }

        [TestMethod]
        public void AssertTransactionListIsNotNull()
        {
            var account = new Account();
            var transactions = account.Transactions;

            Assert.IsNotNull(transactions);
        }

        [TestMethod]
        public void AssertCantAddNullTransaction()
        {
            var account = Account.Create("TestAccount");
            try
            {
                account.AddTransaction(null);
                // if we got here something is wrong!
                Assert.Fail();
            }
            catch (Exception)
            {
                // test passed, just return;
            }
        }
    }
}

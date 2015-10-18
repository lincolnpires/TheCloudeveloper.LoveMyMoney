using LoveMyMoney.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LoveMyMoney.Domain.UnitTests
{
    [TestClass]
    public class TransactionTests
    {
        public TransactionTests() { }

        [TestMethod]
        public void TestCreateTransaction()
        {
            var transaction = Transaction.Create(
                    100m, "Credit card payment", null, new DateTime(), new Category(),
                    Shared.TransactionType.Expense);
        }
    }
}

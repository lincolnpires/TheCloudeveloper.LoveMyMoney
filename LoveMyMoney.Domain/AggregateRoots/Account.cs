using LoveMyMoney.Domain.Abstract;
using LoveMyMoney.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("LoveMyMoney.Domain.UnitTests")]

namespace LoveMyMoney.Domain.AggregateRoots
{
    public class Account : AggregateRoot
    {
        internal Account()
        {
            this.Transactions = new List<Transaction>();
        }

        public string Name { get; private set; }
        public bool Active { get; private set; }
        public IList<Transaction> Transactions { get; private set; }

        public static Account Create(string name)
        {
            var account = new Account();
            account.Name = name;
            account.Active = true;

            return account;
        }

        public void Deactivate()
        {
            this.Active = false;
        }

        public void AddTransaction(Transaction transaction)
        {
            //if (transaction == null)
            //    throw new ArgumentNullException("transaction", "It can't be null.");

            this.Transactions.Add(transaction);
        }
    }
}

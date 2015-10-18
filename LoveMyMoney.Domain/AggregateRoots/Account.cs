using LoveMyMoney.Domain.Abstract;
using LoveMyMoney.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveMyMoney.Domain.AggregateRoots
{
    public class Account : AggregateRoot
    {
        internal Account() { }

        public string Name { get; private set; }
        public bool Active { get; private set; }
        public List<Transaction> Transactions { get; private set; }
    }
}

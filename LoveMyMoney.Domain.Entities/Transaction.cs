using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveMyMoney.Domain.Entities
{
    public class Transaction
    {
        public Transaction()
        {

        }

        public decimal Value { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public Category Category { get; set; }
        public Account Account { get; set; }
        public TransactionType TransactionType { get; set; }

    }
}

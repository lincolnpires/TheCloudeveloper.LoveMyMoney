using LoveMyMoney.Domain.Abstract;
using LoveMyMoney.Domain.AggregateRoots;
using LoveMyMoney.Domain.Shared;
using LoveMyMoney.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveMyMoney.Domain.Entities
{
    public class Transaction : Entity
    {
        internal Transaction() { }

        public Decimal Value { get; private set; }
        public String Description { get; private set; }
        public String Notes { get; private set; }
        public DateTime EventDate { get; private set; }
        public DateTime Added { get; private set; }
        public Nullable<DateTime> LastModified { get; private set; }
        public Category Category { get; private set; }
        public TransactionType Type { get; private set; }
        public Account Account { get; private set; }

        private void SetValue(Decimal value)
        {
            if (value < 0m)
                throw new ArgumentOutOfRangeException(
                    "value", value, "it must be a positive decimal value.");

            this.Value = value;
        }

        public static Transaction Create(
            Decimal value, String description, String notes, DateTime eventDate,
            Category category, TransactionType type)
        {
            var dateNow = DateTime.Now;
            var transaction = new Transaction();

            // TODO: extension method to get the description of the type
            if (description == default(String) || String.IsNullOrEmpty(description))
                description = type.ToString() + dateNow.ToString();

            if (eventDate == default(DateTime))
                eventDate = dateNow;

            transaction.SetValue(value);
            transaction.Description = description;
            transaction.Notes = notes;
            transaction.EventDate = eventDate;
            transaction.LastModified = dateNow;
            transaction.Category = category;
            transaction.Type = type;

            return transaction;
        }

        public void Update()
        {
            this.LastModified = DateTime.Now;
        }
    }
}

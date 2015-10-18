using LoveMyMoney.Domain.Abstract;
using LoveMyMoney.Domain.AggregateRoots;
using LoveMyMoney.Domain.Shared;
using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("LoveMyMoney.Domain.UnitTests")]

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

        private void SetDescription(string description, TransactionType type)
        {
            // TODO: extension method to get the description of the type
            if (description == default(String) || String.IsNullOrEmpty(description))
                description = type.ToString() + DateTime.Now.ToString();

            this.Description = description;
        }

        private void SetEventDate(DateTime eventDate)
        {
            if (eventDate == default(DateTime))
                eventDate = DateTime.Now;

            this.EventDate = eventDate;
        }

        public static Transaction Create(
            Decimal value, String description, String notes, DateTime eventDate,
            Category category, TransactionType type)
        {
            var transaction = new Transaction();

            transaction.Added = DateTime.Now;
            SetProperties(
                value, description, notes, eventDate, category, type, transaction);

            return transaction;
        }

        public void Update(
            Decimal value, String description, String notes, DateTime eventDate,
            Category category, TransactionType type)
        {
            this.LastModified = DateTime.Now;
            SetProperties(
                value, description, notes, eventDate, category, type, this);
        }

        private static void SetProperties(
            decimal value, string description, string notes, DateTime eventDate,
            Category category, TransactionType type, Transaction transaction)
        {
            transaction.SetValue(value);
            transaction.SetDescription(description, type);
            transaction.Notes = notes;
            transaction.SetEventDate(eventDate);
            transaction.Category = category;
            transaction.Type = type;
        }
    }
}

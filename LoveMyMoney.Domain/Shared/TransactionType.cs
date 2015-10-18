using System.ComponentModel;

namespace LoveMyMoney.Domain.Shared
{
    /// <summary>
    /// Represents a type of transaction.
    /// </summary>
    public enum TransactionType : int
    {
        [Description("Revenue")]
        Revenue = 1,

        [Description("Expense")]
        Expense = 2
    }
}
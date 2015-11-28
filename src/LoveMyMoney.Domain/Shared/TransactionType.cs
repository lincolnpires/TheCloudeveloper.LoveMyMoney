using System.ComponentModel;

namespace LoveMyMoney.Domain.Shared
{
    /// <summary>
    /// Determine if the transaction is a revenue or expense.
    /// </summary>
    public enum TransactionType : int
    {
        [Description("Revenue")]
        Revenue = 1,

        [Description("Expense")]
        Expense = 2
    }
}
using System;

public class Transaction
{
    public string Type { get; private set; }
    public decimal Amount { get; private set; }
    public decimal BalanceAfterTransaction { get; private set; }
    public DateTime Date { get; private set; }

    public Transaction(string type, decimal amount, decimal balanceAfterTransaction)
    {
        Type = type;
        Amount = amount;
        BalanceAfterTransaction = balanceAfterTransaction;
        Date = DateTime.Now;
    }

    public override string ToString()
    {
        return $"{Date.ToString("g")} - {Type}: {Amount:C} - Balance: {BalanceAfterTransaction:C}";
    }
}

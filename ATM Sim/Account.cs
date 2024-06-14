using System;
using System.Collections.Generic;

public class Account
{
    public int AccountNumber { get; set; }
    public double Balance { get; private set; }
    public double InterestRate { get; set; }
    public string AccountHolderName { get; set; }
    private List<string> transactions;

    public Account(int accountNumber, double initialBalance, double interestRate, string accountHolderName)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
        InterestRate = interestRate;
        AccountHolderName = accountHolderName;
        transactions = new List<string>();
    }

    public void Deposit(double amount)
    {
        Balance += amount;
        transactions.Add($"Deposited: ${amount}");
    }

    public void Withdraw(double amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            transactions.Add($"Withdrew: ${amount}");
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
        }
        
    }

    public void DisplayTransactions()
    {
        foreach (var transaction in transactions)
        {
            Console.WriteLine(transaction);
        }
    }
}

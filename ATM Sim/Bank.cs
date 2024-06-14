using System;
using System.Collections.Generic;

public class Bank
{
    private List<Account> accounts;

    public Bank()
    {
        accounts = new List<Account>();
        for (int i = 100; i < 110; i++)
        {
            accounts.Add(new Account(i, 100.0, 0.03, $"Default User {i}"));
        }
    }

    public Account RetrieveAccount(int accountNumber)
    {
        return accounts.Find(a => a.AccountNumber == accountNumber);
    }

    public void AddAccount(Account account)
    {
        accounts.Add(account);
    }
}

using System;

public class AtmApplication
{
    private Bank bank;

    public AtmApplication()
    {
        bank = new Bank();
    }

    public void Run()
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("========== Welcome to ATM ==========");
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Select Account");
            Console.WriteLine("3. Exit");ok
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateAccount();
                    break;
                case 2:
                    SelectAccount();
                    break;
                case 3:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    private void CreateAccount()
    {
        Console.WriteLine("Enter Account Holder's Name: ");
        string accountHolderName = Console.ReadLine();
        Console.WriteLine("Enter Account Number: (Account number must be between 100 and 1000) ");
        int accountNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Initial Balance: ");
        double initialBalance = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Interest Rate:()Must be less then 3% ");
        double interestRate = double.Parse(Console.ReadLine());
       

        Account newAccount = new Account(accountNumber, initialBalance, interestRate, accountHolderName);
        bank.AddAccount(newAccount);

       
        Console.WriteLine($"Welcome, {accountHolderName}! Your account with number {accountNumber} has been created.");
        Console.WriteLine("");

    }

    private void SelectAccount()
    {
        Console.WriteLine("Enter Account Number: ");
        int accountNumber = int.Parse(Console.ReadLine());
        
        Account account = bank.RetrieveAccount(accountNumber);

        if (account != null)
        {
            bool exitAccountMenu = false;
            while (!exitAccountMenu)
            {
                Console.WriteLine("");
                Console.WriteLine("What would you like to do :");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Display Transactions");
                Console.WriteLine("5. Exit Account");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Balance: ${account.Balance}");
                        break;
                    case 2:
                        Console.WriteLine("Enter amount to deposit: ");
                        double depositAmount = double.Parse(Console.ReadLine());
                        account.Deposit(depositAmount);
                        break;
                    case 3:
                        Console.WriteLine("Enter amount to withdraw: ");
                        double withdrawAmount = double.Parse(Console.ReadLine());
                        account.Withdraw(withdrawAmount);
                        break;
                    case 4:
                        account.DisplayTransactions();
                        break;
                    case 5:
                        exitAccountMenu = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
        else
        {
            Console.WriteLine("Account not found.");
        }
    }
}

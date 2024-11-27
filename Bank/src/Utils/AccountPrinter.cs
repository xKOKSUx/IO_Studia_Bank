using System;
using Bank.src.Entities;

namespace Bank.src.Utils
{
    public class AccountPrinter
    {
        public void PrintDetails(AccountDetails account)
        {
            if (account == null)
                throw new ArgumentNullException(nameof(account));

            Console.WriteLine("Account Details:");
            Console.WriteLine($"Account Number: {account.AccountNumber}");
            Console.WriteLine($"Account Holder: {account.AccountHolderName}");
            Console.WriteLine($"Account Type: {account.AccountType}");
            Console.WriteLine($"Date Created: {account.DateCreated}");
            Console.WriteLine($"Status: {(account.IsActive ? "Active" : "Inactive")}");
            Console.WriteLine($"Balance: ${account.Balance:F2}");
        }
    }
} 
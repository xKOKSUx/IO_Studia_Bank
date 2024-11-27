using System;
using Bank.src.Utils;
using Bank.src.Entities;
using System.Text.RegularExpressions;

namespace Bank.src.Entities
{
    public class BankAccountManager
    {
        private readonly Random _random = new Random();

        public AccountDetails CreateAccount(string holderName, string accountType)
        {
            if (string.IsNullOrWhiteSpace(holderName))
                throw new ArgumentException("Account holder name cannot be empty");

            if (string.IsNullOrWhiteSpace(accountType))
                throw new ArgumentException("Account type cannot be empty");

            return new AccountDetails
            {
                AccountNumber = GenerateAccountNumber(),
                AccountHolderName = ValidateAndFormatName(holderName),
                AccountType = ValidateAccountType(accountType),
                DateCreated = DateTime.Now,
                IsActive = true,
                Balance = 0
            };
        }

        private string GenerateAccountNumber()
        {
            // Generate a 10-digit account number
            const int accountNumberLength = 10;
            var numbers = new char[accountNumberLength];
            
            for (int i = 0; i < accountNumberLength; i++)
            {
                numbers[i] = (char)(_random.Next(10) + '0');
            }

            return new string(numbers);
        }

        private string ValidateAndFormatName(string name)
        {
            // Remove extra spaces and special characters
            string cleanName = Regex.Replace(name.Trim(), @"[^a-zA-Z\s]", "");
            
            if (string.IsNullOrWhiteSpace(cleanName))
                throw new ArgumentException("Name contains no valid characters");

            // Capitalize first letter of each word
            return string.Join(" ", 
                cleanName.Split(' ')
                    .Where(x => !string.IsNullOrWhiteSpace(x))
                    .Select(x => char.ToUpper(x[0]) + x.Substring(1).ToLower()));
        }

        private string ValidateAccountType(string accountType)
        {
            string[] validTypes = { "Savings", "Checking", "Business" };
            string formattedType = accountType.Trim();

            string matchedType = validTypes.FirstOrDefault(t => 
                t.Equals(formattedType, StringComparison.OrdinalIgnoreCase));

            if (matchedType == null)
                throw new ArgumentException($"Invalid account type. Valid types are: {string.Join(", ", validTypes)}");

            return matchedType;
        }

        public void PrintAccountDetails(AccountDetails account)
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
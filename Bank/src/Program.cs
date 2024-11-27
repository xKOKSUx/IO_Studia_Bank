using System;
using Bank.src.Entities;
using Bank.Services;

namespace Bank.src
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileManagement = new FileManagement();
            fileManagement.CreateFile();

            Display.Logo();
            Display.MainMenu();
            var manager = new BankAccountManager();

            try
            {
                // Create a few sample accounts
                var savingsAccount = manager.CreateAccount("John Doe", "Savings");
                var checkingAccount = manager.CreateAccount("Jane Smith", "Checking");
                var businessAccount = manager.CreateAccount("Acme Corp", "Business");

                Console.WriteLine("Created three accounts successfully:\n");

                // Print details for each account
                manager.PrintAccountDetails(savingsAccount);
                Console.WriteLine("\n-------------------\n");
                
                manager.PrintAccountDetails(checkingAccount);
                Console.WriteLine("\n-------------------\n");
                
                manager.PrintAccountDetails(businessAccount);

                // Demonstrate validation error
                Console.WriteLine("\nTrying to create account with invalid type...");
                var invalidAccount = manager.CreateAccount("Test User", "Invalid");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"\nValidation Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nUnexpected Error: {ex.Message}");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

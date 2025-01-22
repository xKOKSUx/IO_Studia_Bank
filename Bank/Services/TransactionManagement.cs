
using Bank.Services;
using System.Transactions;

namespace Bank.Services
{
    public class TransactionManagement
    {
        private readonly FileManagement _fileManagement = new();
        public void DisplayExpensesHistory()
        {
            var transactions = _fileManagement.ReadFromFile<List<Transaction>>(FileManagement.ConfigPath) ?? [];
            decimal total = 0;

            foreach (var transaction in transactions)
            {

                Console.Write($"[{transaction.Date.ToString("yyyy.MM.dd")}]");
                Console.Write(" ");

                if (transaction.Amount > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                string amount = transaction.Amount.ToString("0.00");
                while (amount.Length - amount.IndexOf('.') < 3)
                {
                    amount += "0";
                }

                Console.WriteLine($"[{amount}]");
                Console.ForegroundColor = ConsoleColor.DarkGray;

                if (!string.IsNullOrEmpty(transaction.Note))
                {
                    Console.WriteLine(transaction.Note);
                }

                total += transaction.Amount;
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.WriteLine($"Bilans z {month}/{year} wynosi {total:C}");
            Console.ReadKey();
        }

        public void AddTransaction(decimal amount, string note)
        {
            var transactions = _fileManagement.ReadFromFile<List<Transaction>>(FileManagement.ConfigPath) ?? [];
            transactions.Add(new Transaction
            {
                Date = DateTime.Now,
                Amount = amount,
                Note = note
            });

            _fileManagement.SaveToFile(FileManagement.ConfigPath, transactions);
        }

        public void Transfer()
        {
            Console.WriteLine("Transfer");
        }

        public void Withdraw()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("$$$");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

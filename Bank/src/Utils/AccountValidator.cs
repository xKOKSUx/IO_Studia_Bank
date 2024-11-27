using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace Bank.src.Utils
{
    public class AccountValidator
    {
        private readonly string[] _validAccountTypes = { "Savings", "Checking", "Business" };

        public string ValidateAndFormatName(string name)
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

        public string ValidateAccountType(string accountType)
        {
            string formattedType = accountType.Trim();

            string matchedType = _validAccountTypes.FirstOrDefault(t => 
                t.Equals(formattedType, StringComparison.OrdinalIgnoreCase));

            if (matchedType == null)
                throw new ArgumentException($"Invalid account type. Valid types are: {string.Join(", ", _validAccountTypes)}");

            return matchedType;
        }
    }
} 
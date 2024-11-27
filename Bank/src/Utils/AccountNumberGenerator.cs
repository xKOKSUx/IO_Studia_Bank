using System;

namespace Bank.src.Utils
{
    public class AccountNumberGenerator
    {
        private readonly Random _random = new Random();

        public string Generate()
        {
            const int accountNumberLength = 10;
            var numbers = new char[accountNumberLength];
            
            for (int i = 0; i < accountNumberLength; i++)
            {
                numbers[i] = (char)(_random.Next(10) + '0');
            }

            return new string(numbers);
        }
    }
} 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.src.Entities
{
    public class AccountDetails
    {
        public string AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public string AccountType { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsActive { get; set; }
        public decimal Balance { get; set; }
    }
}

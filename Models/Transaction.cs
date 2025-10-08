using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem_AponteCatiban.Models
{
    internal class Transaction
    {
        public string customerAccountNumber { get; set; }
        public DateTime date {  get; set; }
        public string type { get; set; }
        public decimal amount { get; set; }
        public decimal previousBalance { get; set; }
        public decimal newBalance { get; set; }

    }
}

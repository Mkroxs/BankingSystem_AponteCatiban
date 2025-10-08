using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem_AponteCatiban.Models
{
    internal class Customer
    {
        public string customerID {  get; set; }
        public string customerName { get; set; }
        public DateTime birthdate { get; set; }
        public string customerContactInfo { get; set; }
        public string customerEmailAddress { get; set; }
        public string customerAccountNumber { get; set; }
        public decimal customerBalance { get; set; }

        public string name { get; set; }

    }
}

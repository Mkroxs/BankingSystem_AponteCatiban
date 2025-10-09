using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem_AponteCatiban.Models
{
    public class Customer
    {
        public string CustomerId { get; set; }
        public string AccountNumber { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public DateTime Birthdate { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string CivilStatus { get; set; }
        public decimal Balance { get; set; }
        public string ImagePath { get; set; }

    }
}

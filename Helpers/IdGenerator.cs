using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem_AponteCatiban.Helpers
{
    public static class IdGenerator
    {
        public static string GenerateCustomerId(int sequence)
        {
            
            string formatted = sequence.ToString("D4");
           
            return $"CUST{formatted}";
        }

        public static string GenerateAccountNumber(DateTime birthdate, int sequence)
        {
            int birthYear = birthdate.Year;         
            int currentYear = DateTime.Now.Year;     
       
            return $"{birthYear}-{currentYear}-{sequence}";
        }
    }
}

using BankingSystem_AponteCatiban;
using BankingSystem_AponteCatiban.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem_AponteCatiban.Helpers
{
    public static class DataStore
    {
        // mga paths sa folders
        private static readonly string dataFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");

        private static readonly string customerPath = Path.Combine(dataFolder, "customers.txt");

        private static readonly string transactionPath = Path.Combine(dataFolder, "transactions.txt");

        // Para dili gamiton og sabay ang isa ka file
        private static readonly object fileLocker = new object();

        // Kuhaon tanan customers gikan sa file
        public static List<Customer> GetAllCustomers()
        {
            lock (fileLocker)
            {
                // Kung wala pa ang file, mobalik lang og empty list
                if (!File.Exists(customerPath))
                    return new List<Customer>();

                // Basahon ang sulod sa file
                string text = File.ReadAllText(customerPath);

                // Kung walay sulod, empty list gihapon
                if (string.IsNullOrWhiteSpace(text))
                    return new List<Customer>();

                // eh convert ang JSON text balik sa list sa Customer
                return JsonConvert.DeserializeObject<List<Customer>>(text)
                       ?? new List<Customer>();
            }
        }

        // eh save tanan customers paadto sa text file
        public static void SaveAllCustomers(List<Customer> customers)
        {
            lock (fileLocker)
            {
                // double check nga naay "Data" folder
                Directory.CreateDirectory(dataFolder);

                // eh convert ang list paadto sa JSON text
                string json = JsonConvert.SerializeObject(customers, Formatting.Indented);

                // Isulat ang JSON text sa customers.txt
                File.WriteAllText(customerPath, json);
            }
        }


        // Kuhaon tanan transactions gikan sa file
        public static List<Transaction> GetAllTransactions()
        {
            lock (fileLocker)
            {
                // Kung wala pa ang file, empty list lang
                if (!File.Exists(transactionPath))
                    return new List<Transaction>();

                // Basahon ang sulod sa transactions.txt
                string text = File.ReadAllText(transactionPath);

                // Kung walay sulod, empty list gihapon
                if (string.IsNullOrWhiteSpace(text))
                    return new List<Transaction>();

                // eh convert balik gikan JSON paadto sa list sa Transaction
                return JsonConvert.DeserializeObject<List<Transaction>>(text)
                       ?? new List<Transaction>();
            }
        }

        // eh add ang new transaction tas eh save ulit
        public static void AddTransaction(Transaction item)
        {
            lock (fileLocker)
            {
                // eh load ang existing na mga transaction
                var list = GetAllTransactions();

                // eh dugang ang bag-ong transaction
                list.Add(item);

                // double check na naay "Data" folder
                Directory.CreateDirectory(dataFolder);

                // eh convert balik paadto sa JSON
                string json = JsonConvert.SerializeObject(list, Formatting.Indented);

                // Isulat tanan balik sa transactions.txt
                File.WriteAllText(transactionPath, json);
            }
        }


    }


}

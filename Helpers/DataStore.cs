using BankingSystem_AponteCatiban.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BankingSystem_AponteCatiban.Helpers
{
    public static class DataStore
    {
        private static readonly string dataFolder =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");

        private static readonly string customersFile =
            Path.Combine(dataFolder, "customers.txt");

        private static readonly string transactionsFile =
            Path.Combine(dataFolder, "transactions.txt");

        private static readonly object fileLock = new object();

        public static void UpdateCustomerBalance(string accountNumber, decimal newBalance)
        {
            var customers = LoadCustomers();
            var customer = customers.FirstOrDefault(c => c.AccountNumber == accountNumber);
            if (customer != null)
            {
                customer.Balance = newBalance;
                SaveCustomers(customers);
            }
        }
        public static List<Customer> LoadCustomers()
        {
            lock (fileLock)
            {
                try
                {
                    if (!File.Exists(customersFile))
                        return new List<Customer>();

                    string text = File.ReadAllText(customersFile);
                    if (string.IsNullOrWhiteSpace(text))
                        return new List<Customer>();

                    return JsonConvert.DeserializeObject<List<Customer>>(text)
                        ?? new List<Customer>();
                }
                catch
                {
                    return new List<Customer>();
                }
            }
        }


        public static void SaveCustomers(List<Customer> customers)
        {
            lock (fileLock)
            {
                try
                {
                    Directory.CreateDirectory(dataFolder);
                    string json = JsonConvert.SerializeObject(customers, Formatting.Indented);
                    File.WriteAllText(customersFile, json);
                }
                catch
                {

                }
            }
        }

        public static List<Transaction> LoadTransactions()
        {
            lock (fileLock)
            {
                try
                {
                    if (!File.Exists(transactionsFile)) return new List<Transaction>();

                    string text = File.ReadAllText(transactionsFile);
                    if (string.IsNullOrWhiteSpace(text)) return new List<Transaction>();

                    return JsonConvert.DeserializeObject<List<Transaction>>(text) ?? new List<Transaction>();
                }
                catch
                {
                    return new List<Transaction>();
                }
            }
        }
        public static void AppendTransaction(Transaction transaction)
        {
            lock (fileLock)
            {
                try
                {
                    var transactions = LoadTransactions();
                    transactions.Add(transaction);
                    Directory.CreateDirectory(dataFolder);
                    string json = JsonConvert.SerializeObject(transactions, Formatting.Indented);
                    File.WriteAllText(transactionsFile, json);
                }
                catch
                {

                }
            }
        }
    }
}

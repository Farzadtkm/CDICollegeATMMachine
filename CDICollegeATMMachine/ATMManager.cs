using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CDICollegeATMMachine
{
    class ATMManager
    {

        Bank bank;
        Customers customers;
        SavingAccounts savingAccounts;
        CheckingAccounts checkingAccounts;

        private double currentBalance;

        public List<Customer> readCustomrs() {
            List<Customer> customerList = new List<Customer>();
            try {
                String[] lines = File.ReadAllLines("C:\\Users\\Farzad\\source\\repos\\CDICollegeATMMachine\\Customers.txt");

                for (int i = 0; i < 5; i++) {
                    Customer AddCustomer = new Customer();
                    String[] each = lines[i].Split(',');
                    AddCustomer.setName(each[0]);
                    AddCustomer.setPinNumber(each[1]);
                    customerList.Add(AddCustomer);
                }

            } catch (IOException e) {
                Console.Write("There was an error when loading the file");
            }
            return customerList;
            //for (int i = 0; i < 5; i++) {       
            //    for (int j = 0; j < 2; j++) {
            //        Console.Write(customers[i, j]);
            //    }
            //    Console.WriteLine();
            //}
        }




        public Boolean validateUser(string name, int PinNumber)
        {

            return true;
        }

        public Boolean WithdrawChecking(int PIN, double amount)
        {
            return true;
        }

        public Boolean WithdrawSavings(int PIN, double amount)
        {
            return true;
        }
        public Boolean DepositChecking(int PIN, double amount)
        {
            return true;
        }
        public Boolean DepositSavings(int PIN, double amount)
        {
            return true;
        }
        public Boolean PayBill(int PIN, double amount)
        {
            return true;
        }
        public void TransferFunds(int pin, string amount, string accountType)
        {

        }

        public void DisplayAccountBalance()
        {
            Console.WriteLine("Your current balance is: " + currentBalance);
        }
        public Boolean ReadCustomers()
        {
            return true;
            
        }
        public Boolean ReadAccounts()
        {
            return true;
        }
        public Boolean WriteAccounts()
        {
            return true;
        }

    }
}

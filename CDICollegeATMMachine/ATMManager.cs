using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDICollegeATMMachine
{
    class ATMManager
    {
        Bank bank { get; set; }
        Customers customers { get; set; }
        SavingAccounts savingAccounts { get; set; }
        CheckingAccounts checkingAccounts { get; set; }

        private double currentBalance;

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

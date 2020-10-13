using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDICollegeATMMachine
{
    class Checking : Account
    {

        private double billFee;
        private double maximumBillAmount;
        private string pinNumber;
        private string accountNumber;
        private double accountBalance;

        public double payBill(double amount)
        {
            return 0;
        }

        public void setPinNumber(string pinNumber) {
            this.pinNumber = pinNumber;
        }
        public string getPinNumber() {
            return this.pinNumber;
        }

        public void setAccountNumber(string accountNumber) {
            this.accountNumber = accountNumber;
        }
        public string getAccountNumber() {
            return this.accountNumber;
        }

        public void setAccountBalance(double accountBalance) {
            this.accountBalance = accountBalance;
        }
        public double getAccountBalance() {
            return this.accountBalance;
        }
    }
}

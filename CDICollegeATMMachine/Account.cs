using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDICollegeATMMachine
{
    class Account
    {

        private int pinNumber;
        private string accountNumber;
        private double accountBalance;
        private int maximumWithDrawal = 10000;
        private int maximumTransferAmount;

        public double withdarw(double amount)
        {
            return 0;
        }

        public double deposit(double deposit)
        {
            return 0;
        }

        public double transferOut(double deposit)
        {
            return 0;
        }

        public double transferIn(double deposit)
        {
            return 0;
        }

        public int getPIN()
        {
            return this.pinNumber;
        }
    }
}

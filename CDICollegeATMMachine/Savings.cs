using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDICollegeATMMachine {
    public class Savings : Account {

        private double intrestRate;
        public double payIntrest() {
            return intrestRate * 1.45;
        }
    }
}

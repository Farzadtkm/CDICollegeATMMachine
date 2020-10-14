using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDICollegeATMMachine {
    public partial class Supervisor : Form {
        public Supervisor() {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e) {
            KeyPadTxt.Text = KeyPadTxt.Text + "1";
        }

        private void button12_Click(object sender, EventArgs e) {
            KeyPadTxt.Text = KeyPadTxt.Text + "2";
        }

        private void button5_Click(object sender, EventArgs e) {
            KeyPadTxt.Text = KeyPadTxt.Text + "3";
        }

        private void button13_Click(object sender, EventArgs e) {
            KeyPadTxt.Text = KeyPadTxt.Text + "4";
        }

        private void button6_Click(object sender, EventArgs e) {
            KeyPadTxt.Text = KeyPadTxt.Text + "5";
        }

        private void button9_Click(object sender, EventArgs e) {
            KeyPadTxt.Text = KeyPadTxt.Text + "6";
        }

        private void button4_Click(object sender, EventArgs e) {
            KeyPadTxt.Text = KeyPadTxt.Text + "7";
        }

        private void button7_Click(object sender, EventArgs e) {
            KeyPadTxt.Text = KeyPadTxt.Text + "8";
        }

        private void button8_Click(object sender, EventArgs e) {
            KeyPadTxt.Text = KeyPadTxt.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e) {
            KeyPadTxt.Text = KeyPadTxt.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e) {
            KeyPadTxt.Text = KeyPadTxt.Text + ".";
        }

        private void button2_Click(object sender, EventArgs e) {
            MessageBox.Show("The ATM is out of Service");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (Convert.ToDouble(supervisorKeyPad.Text) % 5000 > 0) {
                MessageBox.Show("The amount should be multiples of 5000", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (Convert.ToDouble(KeyPadTxt.Text) < 0)
                MessageBox.Show("The amount cannot be less than zero", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

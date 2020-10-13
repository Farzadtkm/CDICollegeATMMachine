using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CDICollegeATMMachine {
    public partial class SignInForm : Form {
        public SignInForm() {
            InitializeComponent();
        }
        ATMManager atmManger;
        private string pinNumber;
        private double amount;
        private Boolean readAccounts;
        private int attempt;
        public static String user;
        public static String pass;

        


        private void Button1_Click(object sender, EventArgs e) {
            Passwordtxt.Text = Passwordtxt.Text + "1";
            
        }

        private void button3_Click(object sender, EventArgs e) {
            Passwordtxt.Text = Passwordtxt.Text + "2";
        }

        private void button5_Click(object sender, EventArgs e) {
            Passwordtxt.Text = Passwordtxt.Text + "3";
        }

        private void button2_Click(object sender, EventArgs e) {
            Passwordtxt.Text = Passwordtxt.Text + "4";
        }

        private void button6_Click(object sender, EventArgs e) {
            Passwordtxt.Text = Passwordtxt.Text + "5";
        }

        private void button9_Click(object sender, EventArgs e) {
            Passwordtxt.Text = Passwordtxt.Text + "6";
        }

        private void button4_Click(object sender, EventArgs e) {
            Passwordtxt.Text = Passwordtxt.Text + "7";
        }

        private void button7_Click(object sender, EventArgs e) {
            Passwordtxt.Text = Passwordtxt.Text + "8";
        }

        private void button8_Click(object sender, EventArgs e) {
            Passwordtxt.Text = Passwordtxt.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e) {
            Passwordtxt.Text = Passwordtxt.Text + "0";
        }

        private void button12_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void LogIn_Click(object sender, EventArgs e) {

            ATMManager atmManager = new ATMManager();
            List<Customer> loadedCustomers = atmManager.readCustomrs();

            user = UserNameTxt.Text;
            pass = Passwordtxt.Text;

            #region login check
            foreach (Customer customerItem in loadedCustomers) {
                if (customerItem.getName().Equals(user) && customerItem.getPinNumber().Equals(pass.Trim())){
                    this.Hide();
                    MainMenu mainMenu = new MainMenu();
                    mainMenu.Show();
                    return;
                }
            }
            attempt++;
            if (attempt < 3) {
                MessageBox.Show("The User Name or PIN is Inccorect you have " + (3 - attempt) + " attempt more");
            } else if (attempt == 3) {
                MessageBox.Show("Your session has been terminated", "Wrong Inputs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            #endregion



            //for (int i = 0; i < 5; i++) {
            //    if (customers[i, 0] == user && customers[i, 1] == pass) {

            //        this.Hide();
            //        MainMenu mainMenu = new MainMenu();
            //        mainMenu.Show();

            //        return;
            //    }
            //}

            //attempt++;
            //if (attempt < 3) {
            //    MessageBox.Show("The User Name or PIN is Inccorect you have " + (3 - attempt) + " attempt more");
            //} else if (attempt == 3) {
            //    MessageBox.Show("Your session has been terminated", "Wrong Inputs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    this.Close();
            //}

        }

        private void Passwordtxt_TextChanged(object sender, EventArgs e) {

        }
    }
}

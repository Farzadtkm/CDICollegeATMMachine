using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CDICollegeATMMachine
{
    public partial class MainMenu : Form
    {

        public MainMenu()
        {
            InitializeComponent();
        }

        ATMManager atmManager;
        private string user;
        private string pinNumber;
        private int counter;
        private string[,] accounts = new string[11, 4];

        
        
        public void readAccoounts() {

            try {
                String[] lines = File.ReadAllLines("C:\\Users\\Farzad\\source\\repos\\CDICollegeATMMachine\\Accounts.txt");

                for (int i = 0; i < 11; i++) {
                    String[] each = lines[i].Split(',');

                    for (int j = 0; j < 4; j++) {
                        accounts[i, j] = each[j];
                    }
                }

            } catch (IOException e) {
                Console.Write("There was an error when loading the file");
            }

            for (int i = 0; i < 11; i++) {
                for (int j = 0; j < 4; j++) {
                    Console.Write(accounts[i, j]);
                }
                Console.WriteLine();
            }
        }

        public void InputNumber(String number)
        {

        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            KeyPadTxt.Text = KeyPadTxt.Text + "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KeyPadTxt.Text = KeyPadTxt.Text + "2";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            KeyPadTxt.Text = KeyPadTxt.Text + "3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KeyPadTxt.Text = KeyPadTxt.Text + "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            KeyPadTxt.Text = KeyPadTxt.Text + "5";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            KeyPadTxt.Text = KeyPadTxt.Text + "6";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KeyPadTxt.Text = KeyPadTxt.Text + "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            KeyPadTxt.Text = KeyPadTxt.Text + "8";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            KeyPadTxt.Text = KeyPadTxt.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            KeyPadTxt.Text = KeyPadTxt.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            KeyPadTxt.Text = KeyPadTxt.Text + ".";
        }

        private void SubmitButton_Click(object sender, EventArgs e) {
            
        }

        private void CheckingRadio_CheckedChanged(object sender, EventArgs e) {
            if(CheckingRadio.Checked == true) {
                
            }
        }
    }
}

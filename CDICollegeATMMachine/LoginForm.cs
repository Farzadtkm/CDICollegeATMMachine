using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDICollegeATMMachine
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private int attempt;

        private void Button1_Click(object sender, EventArgs e)
        {
            Passwordtxt.Text = Passwordtxt.Text + "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Passwordtxt.Text = Passwordtxt.Text + "2";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Passwordtxt.Text = Passwordtxt.Text + "3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Passwordtxt.Text = Passwordtxt.Text + "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Passwordtxt.Text = Passwordtxt.Text + "5";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Passwordtxt.Text = Passwordtxt.Text + "6";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Passwordtxt.Text = Passwordtxt.Text + "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Passwordtxt.Text = Passwordtxt.Text + "8";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Passwordtxt.Text = Passwordtxt.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Passwordtxt.Text = Passwordtxt.Text + "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            attempt++;
            if(attempt < 3)
            {
                MessageBox.Show("The User Name or PIN is Inccorect you have " + ( 3 - attempt) + " attempt more");
            }
            else if(attempt == 3)
            {
                MessageBox.Show("Your session has been terminated", "Wrong Inputs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void Passwordtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

﻿namespace CDICollegeATMMachine
{
    partial class SignInForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SignIN = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.UserName = new System.Windows.Forms.Label();
            this.PIN = new System.Windows.Forms.Label();
            this.UserNameTxt = new System.Windows.Forms.TextBox();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.LogIn = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.SignIN.SuspendLayout();
            this.SuspendLayout();
            // 
            // SignIN
            // 
            this.SignIN.Controls.Add(this.button12);
            this.SignIN.Controls.Add(this.LogIn);
            this.SignIN.Controls.Add(this.button10);
            this.SignIN.Controls.Add(this.button9);
            this.SignIN.Controls.Add(this.button8);
            this.SignIN.Controls.Add(this.button7);
            this.SignIN.Controls.Add(this.button6);
            this.SignIN.Controls.Add(this.button5);
            this.SignIN.Controls.Add(this.button4);
            this.SignIN.Controls.Add(this.button3);
            this.SignIN.Controls.Add(this.button2);
            this.SignIN.Controls.Add(this.Button1);
            this.SignIN.Controls.Add(this.Passwordtxt);
            this.SignIN.Controls.Add(this.UserNameTxt);
            this.SignIN.Controls.Add(this.PIN);
            this.SignIN.Controls.Add(this.UserName);
            this.SignIN.Location = new System.Drawing.Point(301, 31);
            this.SignIN.Name = "SignIN";
            this.SignIN.Size = new System.Drawing.Size(359, 398);
            this.SignIN.TabIndex = 0;
            this.SignIN.TabStop = false;
            this.SignIN.Text = "Sign In";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(52, 58);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(74, 15);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "User Name: ";
            // 
            // PIN
            // 
            this.PIN.AutoSize = true;
            this.PIN.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PIN.Location = new System.Drawing.Point(52, 96);
            this.PIN.Name = "PIN";
            this.PIN.Size = new System.Drawing.Size(35, 15);
            this.PIN.TabIndex = 1;
            this.PIN.Text = "PIN: ";
            // 
            // UserNameTxt
            // 
            this.UserNameTxt.Location = new System.Drawing.Point(133, 52);
            this.UserNameTxt.Name = "UserNameTxt";
            this.UserNameTxt.Size = new System.Drawing.Size(125, 20);
            this.UserNameTxt.TabIndex = 2;
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Location = new System.Drawing.Point(133, 94);
            this.Passwordtxt.MaxLength = 4;
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.PasswordChar = '*';
            this.Passwordtxt.Size = new System.Drawing.Size(125, 20);
            this.Passwordtxt.TabIndex = 3;
            this.Passwordtxt.TextChanged += new System.EventHandler(this.Passwordtxt_TextChanged);
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(38, 148);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(65, 30);
            this.Button1.TabIndex = 4;
            this.Button1.Text = "1";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(38, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "4";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(133, 148);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 30);
            this.button3.TabIndex = 6;
            this.button3.Text = "2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(38, 239);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 30);
            this.button4.TabIndex = 7;
            this.button4.Text = "7";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(222, 148);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(65, 30);
            this.button5.TabIndex = 8;
            this.button5.Text = "3";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(133, 191);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(65, 30);
            this.button6.TabIndex = 9;
            this.button6.Text = "5";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(133, 239);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(65, 30);
            this.button7.TabIndex = 10;
            this.button7.Text = "8";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(222, 239);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(65, 30);
            this.button8.TabIndex = 11;
            this.button8.Text = "9";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(222, 191);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(65, 30);
            this.button9.TabIndex = 12;
            this.button9.Text = "6";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(133, 284);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(65, 30);
            this.button10.TabIndex = 13;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // LogIn
            // 
            this.LogIn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LogIn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogIn.Location = new System.Drawing.Point(55, 334);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(86, 30);
            this.LogIn.TabIndex = 14;
            this.LogIn.Text = "Log In";
            this.LogIn.UseVisualStyleBackColor = false;
            this.LogIn.Click += new System.EventHandler(this.LogIn_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(189, 334);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(85, 30);
            this.button12.TabIndex = 15;
            this.button12.Text = "Exit";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 493);
            this.Controls.Add(this.SignIN);
            this.Name = "SignInForm";
            this.Text = "Sign In";
            this.SignIN.ResumeLayout(false);
            this.SignIN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SignIN;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button LogIn;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.TextBox Passwordtxt;
        private System.Windows.Forms.TextBox UserNameTxt;
        private System.Windows.Forms.Label PIN;
        private System.Windows.Forms.Label UserName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

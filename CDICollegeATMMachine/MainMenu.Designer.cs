﻿namespace CDICollegeATMMachine
{
    partial class MainMenu
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
            this.KeyPadGB = new System.Windows.Forms.GroupBox();
            this.KeyPadTxt = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SelectTransaction = new System.Windows.Forms.GroupBox();
            this.PayBillRadio = new System.Windows.Forms.RadioButton();
            this.TransferFundsRadio = new System.Windows.Forms.RadioButton();
            this.WithdrawalRadio = new System.Windows.Forms.RadioButton();
            this.DepositRadio = new System.Windows.Forms.RadioButton();
            this.SelectAccount = new System.Windows.Forms.GroupBox();
            this.SavingRadio = new System.Windows.Forms.RadioButton();
            this.CheckingRadio = new System.Windows.Forms.RadioButton();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Checkingtxt = new System.Windows.Forms.TextBox();
            this.Savingtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FullName = new System.Windows.Forms.Label();
            this.transferFunds = new System.Windows.Forms.GroupBox();
            this.transferlbl = new System.Windows.Forms.Label();
            this.tolbl = new System.Windows.Forms.Label();
            this.fromlbl = new System.Windows.Forms.Label();
            this.transferFundsSavingsRadio = new System.Windows.Forms.RadioButton();
            this.transferFundsCheckingRadio = new System.Windows.Forms.RadioButton();
            this.ExitTheATM = new System.Windows.Forms.Button();
            this.KeyPadGB.SuspendLayout();
            this.SelectTransaction.SuspendLayout();
            this.SelectAccount.SuspendLayout();
            this.transferFunds.SuspendLayout();
            this.SuspendLayout();
            // 
            // KeyPadGB
            // 
            this.KeyPadGB.Controls.Add(this.KeyPadTxt);
            this.KeyPadGB.Controls.Add(this.button11);
            this.KeyPadGB.Controls.Add(this.button10);
            this.KeyPadGB.Controls.Add(this.button9);
            this.KeyPadGB.Controls.Add(this.button8);
            this.KeyPadGB.Controls.Add(this.button7);
            this.KeyPadGB.Controls.Add(this.button6);
            this.KeyPadGB.Controls.Add(this.button5);
            this.KeyPadGB.Controls.Add(this.button4);
            this.KeyPadGB.Controls.Add(this.button3);
            this.KeyPadGB.Controls.Add(this.button2);
            this.KeyPadGB.Controls.Add(this.Button1);
            this.KeyPadGB.Location = new System.Drawing.Point(24, 42);
            this.KeyPadGB.Name = "KeyPadGB";
            this.KeyPadGB.Size = new System.Drawing.Size(279, 294);
            this.KeyPadGB.TabIndex = 0;
            this.KeyPadGB.TabStop = false;
            this.KeyPadGB.Text = "Key Pad";
            // 
            // KeyPadTxt
            // 
            this.KeyPadTxt.Location = new System.Drawing.Point(49, 217);
            this.KeyPadTxt.Name = "KeyPadTxt";
            this.KeyPadTxt.Size = new System.Drawing.Size(163, 20);
            this.KeyPadTxt.TabIndex = 1;
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(190, 164);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(65, 30);
            this.button11.TabIndex = 24;
            this.button11.Text = ".";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(101, 164);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(65, 30);
            this.button10.TabIndex = 23;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(190, 71);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(65, 30);
            this.button9.TabIndex = 22;
            this.button9.Text = "6";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(190, 119);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(65, 30);
            this.button8.TabIndex = 21;
            this.button8.Text = "9";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(101, 119);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(65, 30);
            this.button7.TabIndex = 20;
            this.button7.Text = "8";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(101, 71);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(65, 30);
            this.button6.TabIndex = 19;
            this.button6.Text = "5";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(190, 28);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(65, 30);
            this.button5.TabIndex = 18;
            this.button5.Text = "3";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(6, 119);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 30);
            this.button4.TabIndex = 17;
            this.button4.Text = "7";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(101, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 30);
            this.button3.TabIndex = 16;
            this.button3.Text = "2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(6, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 30);
            this.button2.TabIndex = 15;
            this.button2.Text = "4";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(6, 28);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(65, 30);
            this.Button1.TabIndex = 14;
            this.Button1.Text = "1";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // SelectTransaction
            // 
            this.SelectTransaction.Controls.Add(this.PayBillRadio);
            this.SelectTransaction.Controls.Add(this.TransferFundsRadio);
            this.SelectTransaction.Controls.Add(this.WithdrawalRadio);
            this.SelectTransaction.Controls.Add(this.DepositRadio);
            this.SelectTransaction.Location = new System.Drawing.Point(320, 42);
            this.SelectTransaction.Name = "SelectTransaction";
            this.SelectTransaction.Size = new System.Drawing.Size(122, 177);
            this.SelectTransaction.TabIndex = 1;
            this.SelectTransaction.TabStop = false;
            this.SelectTransaction.Text = "Select Transaction";
            this.SelectTransaction.Enter += new System.EventHandler(this.SelectTransaction_Enter);
            // 
            // PayBillRadio
            // 
            this.PayBillRadio.AutoSize = true;
            this.PayBillRadio.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayBillRadio.Location = new System.Drawing.Point(7, 133);
            this.PayBillRadio.Name = "PayBillRadio";
            this.PayBillRadio.Size = new System.Drawing.Size(69, 19);
            this.PayBillRadio.TabIndex = 3;
            this.PayBillRadio.TabStop = true;
            this.PayBillRadio.Text = "Pay Bill";
            this.PayBillRadio.UseVisualStyleBackColor = true;
            this.PayBillRadio.CheckedChanged += new System.EventHandler(this.PayBillRadio_CheckedChanged);
            // 
            // TransferFundsRadio
            // 
            this.TransferFundsRadio.AutoSize = true;
            this.TransferFundsRadio.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransferFundsRadio.Location = new System.Drawing.Point(6, 98);
            this.TransferFundsRadio.Name = "TransferFundsRadio";
            this.TransferFundsRadio.Size = new System.Drawing.Size(109, 19);
            this.TransferFundsRadio.TabIndex = 2;
            this.TransferFundsRadio.TabStop = true;
            this.TransferFundsRadio.Text = "Transfer Funds";
            this.TransferFundsRadio.UseVisualStyleBackColor = true;
            this.TransferFundsRadio.CheckedChanged += new System.EventHandler(this.TransferFundsRadio_CheckedChanged);
            // 
            // WithdrawalRadio
            // 
            this.WithdrawalRadio.AutoSize = true;
            this.WithdrawalRadio.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithdrawalRadio.Location = new System.Drawing.Point(6, 61);
            this.WithdrawalRadio.Name = "WithdrawalRadio";
            this.WithdrawalRadio.Size = new System.Drawing.Size(89, 19);
            this.WithdrawalRadio.TabIndex = 1;
            this.WithdrawalRadio.TabStop = true;
            this.WithdrawalRadio.Text = "Withdrawal";
            this.WithdrawalRadio.UseVisualStyleBackColor = true;
            this.WithdrawalRadio.CheckedChanged += new System.EventHandler(this.WithdrawalRadio_CheckedChanged);
            // 
            // DepositRadio
            // 
            this.DepositRadio.AutoSize = true;
            this.DepositRadio.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositRadio.Location = new System.Drawing.Point(7, 30);
            this.DepositRadio.Name = "DepositRadio";
            this.DepositRadio.Size = new System.Drawing.Size(66, 19);
            this.DepositRadio.TabIndex = 0;
            this.DepositRadio.TabStop = true;
            this.DepositRadio.Text = "Deposit";
            this.DepositRadio.UseVisualStyleBackColor = true;
            this.DepositRadio.CheckedChanged += new System.EventHandler(this.DepositRadio_CheckedChanged);
            // 
            // SelectAccount
            // 
            this.SelectAccount.Controls.Add(this.SavingRadio);
            this.SelectAccount.Controls.Add(this.CheckingRadio);
            this.SelectAccount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SelectAccount.Location = new System.Drawing.Point(320, 225);
            this.SelectAccount.Name = "SelectAccount";
            this.SelectAccount.Size = new System.Drawing.Size(122, 111);
            this.SelectAccount.TabIndex = 2;
            this.SelectAccount.TabStop = false;
            this.SelectAccount.Text = "Select Account";
            // 
            // SavingRadio
            // 
            this.SavingRadio.AutoSize = true;
            this.SavingRadio.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavingRadio.Location = new System.Drawing.Point(7, 70);
            this.SavingRadio.Name = "SavingRadio";
            this.SavingRadio.Size = new System.Drawing.Size(68, 19);
            this.SavingRadio.TabIndex = 5;
            this.SavingRadio.Text = "Savings";
            this.SavingRadio.UseVisualStyleBackColor = true;
            this.SavingRadio.CheckedChanged += new System.EventHandler(this.SavingRadio_CheckedChanged);
            // 
            // CheckingRadio
            // 
            this.CheckingRadio.AutoSize = true;
            this.CheckingRadio.Checked = true;
            this.CheckingRadio.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckingRadio.Location = new System.Drawing.Point(7, 34);
            this.CheckingRadio.Name = "CheckingRadio";
            this.CheckingRadio.Size = new System.Drawing.Size(79, 19);
            this.CheckingRadio.TabIndex = 4;
            this.CheckingRadio.TabStop = true;
            this.CheckingRadio.Text = "Checking";
            this.CheckingRadio.UseVisualStyleBackColor = true;
            this.CheckingRadio.CheckedChanged += new System.EventHandler(this.CheckingRadio_CheckedChanged);
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SubmitButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(24, 357);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(86, 30);
            this.SubmitButton.TabIndex = 15;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.CloseButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(125, 357);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(141, 30);
            this.CloseButton.TabIndex = 16;
            this.CloseButton.Text = "Login Form";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(495, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Checking Balance:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(497, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Saving Balance: ";
            // 
            // Checkingtxt
            // 
            this.Checkingtxt.Location = new System.Drawing.Point(607, 72);
            this.Checkingtxt.Name = "Checkingtxt";
            this.Checkingtxt.Size = new System.Drawing.Size(163, 20);
            this.Checkingtxt.TabIndex = 23;
            // 
            // Savingtxt
            // 
            this.Savingtxt.Location = new System.Drawing.Point(607, 113);
            this.Savingtxt.Name = "Savingtxt";
            this.Savingtxt.Size = new System.Drawing.Size(163, 20);
            this.Savingtxt.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(494, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Hello";
            // 
            // FullName
            // 
            this.FullName.AutoSize = true;
            this.FullName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FullName.Location = new System.Drawing.Point(604, 43);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(0, 15);
            this.FullName.TabIndex = 26;
            // 
            // transferFunds
            // 
            this.transferFunds.Controls.Add(this.transferlbl);
            this.transferFunds.Controls.Add(this.tolbl);
            this.transferFunds.Controls.Add(this.fromlbl);
            this.transferFunds.Controls.Add(this.transferFundsSavingsRadio);
            this.transferFunds.Controls.Add(this.transferFundsCheckingRadio);
            this.transferFunds.Enabled = false;
            this.transferFunds.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.transferFunds.Location = new System.Drawing.Point(448, 225);
            this.transferFunds.Name = "transferFunds";
            this.transferFunds.Size = new System.Drawing.Size(267, 111);
            this.transferFunds.TabIndex = 27;
            this.transferFunds.TabStop = false;
            this.transferFunds.Text = "Transfer Funds";
            this.transferFunds.KeyDown += new System.Windows.Forms.KeyEventHandler(this.transferFunds_KeyDown);
            this.transferFunds.Enter += new System.EventHandler(this.transferFunds_Enter);
            // 
            // transferlbl
            // 
            this.transferlbl.AutoSize = true;
            this.transferlbl.Location = new System.Drawing.Point(199, 39);
            this.transferlbl.Name = "transferlbl";
            this.transferlbl.Size = new System.Drawing.Size(0, 13);
            this.transferlbl.TabIndex = 8;
            // 
            // tolbl
            // 
            this.tolbl.AutoSize = true;
            this.tolbl.Location = new System.Drawing.Point(159, 39);
            this.tolbl.Name = "tolbl";
            this.tolbl.Size = new System.Drawing.Size(20, 13);
            this.tolbl.TabIndex = 7;
            this.tolbl.Text = "To";
            // 
            // fromlbl
            // 
            this.fromlbl.AutoSize = true;
            this.fromlbl.Location = new System.Drawing.Point(6, 34);
            this.fromlbl.Name = "fromlbl";
            this.fromlbl.Size = new System.Drawing.Size(30, 13);
            this.fromlbl.TabIndex = 6;
            this.fromlbl.Text = "From";
            this.fromlbl.Click += new System.EventHandler(this.fromlbl_Click);
            // 
            // transferFundsSavingsRadio
            // 
            this.transferFundsSavingsRadio.AutoSize = true;
            this.transferFundsSavingsRadio.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferFundsSavingsRadio.Location = new System.Drawing.Point(68, 70);
            this.transferFundsSavingsRadio.Name = "transferFundsSavingsRadio";
            this.transferFundsSavingsRadio.Size = new System.Drawing.Size(68, 19);
            this.transferFundsSavingsRadio.TabIndex = 5;
            this.transferFundsSavingsRadio.Text = "Savings";
            this.transferFundsSavingsRadio.UseVisualStyleBackColor = true;
            this.transferFundsSavingsRadio.CheckedChanged += new System.EventHandler(this.transferFundsSavingsRadio_CheckedChanged);
            // 
            // transferFundsCheckingRadio
            // 
            this.transferFundsCheckingRadio.AutoSize = true;
            this.transferFundsCheckingRadio.Checked = true;
            this.transferFundsCheckingRadio.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferFundsCheckingRadio.Location = new System.Drawing.Point(68, 35);
            this.transferFundsCheckingRadio.Name = "transferFundsCheckingRadio";
            this.transferFundsCheckingRadio.Size = new System.Drawing.Size(79, 19);
            this.transferFundsCheckingRadio.TabIndex = 4;
            this.transferFundsCheckingRadio.TabStop = true;
            this.transferFundsCheckingRadio.Text = "Checking";
            this.transferFundsCheckingRadio.UseVisualStyleBackColor = true;
            this.transferFundsCheckingRadio.CheckedChanged += new System.EventHandler(this.transferFundsCheckingRadio_CheckedChanged);
            // 
            // ExitTheATM
            // 
            this.ExitTheATM.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ExitTheATM.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitTheATM.Location = new System.Drawing.Point(629, 357);
            this.ExitTheATM.Name = "ExitTheATM";
            this.ExitTheATM.Size = new System.Drawing.Size(86, 30);
            this.ExitTheATM.TabIndex = 28;
            this.ExitTheATM.Text = "EXIT";
            this.ExitTheATM.UseVisualStyleBackColor = false;
            this.ExitTheATM.Click += new System.EventHandler(this.ExitTheATM_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitTheATM);
            this.Controls.Add(this.transferFunds);
            this.Controls.Add(this.FullName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Savingtxt);
            this.Controls.Add(this.Checkingtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.SelectAccount);
            this.Controls.Add(this.SelectTransaction);
            this.Controls.Add(this.KeyPadGB);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.KeyPadGB.ResumeLayout(false);
            this.KeyPadGB.PerformLayout();
            this.SelectTransaction.ResumeLayout(false);
            this.SelectTransaction.PerformLayout();
            this.SelectAccount.ResumeLayout(false);
            this.SelectAccount.PerformLayout();
            this.transferFunds.ResumeLayout(false);
            this.transferFunds.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox KeyPadGB;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button11;
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
        private System.Windows.Forms.TextBox KeyPadTxt;
        private System.Windows.Forms.GroupBox SelectTransaction;
        private System.Windows.Forms.RadioButton PayBillRadio;
        private System.Windows.Forms.RadioButton TransferFundsRadio;
        private System.Windows.Forms.RadioButton WithdrawalRadio;
        private System.Windows.Forms.RadioButton DepositRadio;
        private System.Windows.Forms.GroupBox SelectAccount;
        private System.Windows.Forms.RadioButton SavingRadio;
        private System.Windows.Forms.RadioButton CheckingRadio;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Checkingtxt;
        private System.Windows.Forms.TextBox Savingtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label FullName;
        private System.Windows.Forms.GroupBox transferFunds;
        private System.Windows.Forms.KeyEventHandler keyDown;
        private System.Windows.Forms.Label fromlbl;
        private System.Windows.Forms.RadioButton transferFundsSavingsRadio;
        private System.Windows.Forms.RadioButton transferFundsCheckingRadio;
        private System.Windows.Forms.Label transferlbl;
        private System.Windows.Forms.Label tolbl;
        private System.Windows.Forms.Button ExitTheATM;
    }
}
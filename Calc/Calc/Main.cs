﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            CenterToScreen();
        }
        private void btn_deposit_Click(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit();
            deposit.ShowDialog();
        }
        private void btn_credit_Click(object sender, EventArgs e)
        {
            Credit credit = new Credit();
            credit.ShowDialog();
        }
    }
}

using System;
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
    public partial class Credit : Form
    {
        public Credit()
        {
            InitializeComponent();
            CenterToScreen();
        }
        private void btn_total_Click(object sender, EventArgs e)
        {
            double sum = Convert.ToDouble(tb_sum.Text);
            double perc = Convert.ToDouble(tb_percent.Text);
            double term = Convert.ToDouble(tb_term.Text);
            double month_perc = perc / 1200;
            double factor = month_perc * Math.Pow((1 + month_perc), term * 12) / (Math.Pow((1 + month_perc), term * 12) - 1);
            double pay_month = Math.Round((sum * factor),2);
            double total_sum = Math.Round((pay_month * term * 12), 2);
            double total_pay = total_sum - sum;
            MessageBox.Show("Начисленные проценты: " + total_pay + " руб. \n" + "Платёж в месяц: " + pay_month + " руб. \n" + "Долг + проценты: " + total_sum + " руб.");
        }
    }
}

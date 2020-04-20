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
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
            CenterToScreen();
        }
        private void btn_total_Click(object sender, EventArgs e)
        {
            int sum = Convert.ToInt32(tb_sum.Text);
            double perc = Convert.ToDouble(tb_percent.Text);
            int days = (dtp_end.Value - dtp_start.Value).Days;
            double total_perc = Math.Round((sum * days * perc / 36500),2);
            double tax = Math.Round(((total_perc - (sum * days * 11 / 36500)) * 0.35),2);
            double total_sum = total_perc - tax;
            MessageBox.Show(" Здесь исходные данные \n" + sum + " " + perc + " " + days + "\n" + "Итоги за " + days + " дней: \n" + "Начисленные проценты: " + total_perc + " руб. \n" + "Удержано налогов: " + tax + " руб. \n" + "Доход с вычетом налогов: " + total_sum + " руб.");
        }
    }
}

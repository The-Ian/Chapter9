using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter9
{
    public partial class Tutorial9_3 : Form
    {
        private BankAccount account = new BankAccount(1000);

        public Tutorial9_3()
        {
            InitializeComponent();
        }

        private void Tutorial9_3_Load(object sender, EventArgs e)
        {
            balanceLabel.Text = account.Balance.ToString("c");
        }

        private void depositBtn_Click(object sender, EventArgs e)
        {
            decimal amount;

            if (decimal.TryParse(depositTB.Text, out amount))
            {
                account.Deposit(amount);

                balanceLabel.Text = account.Balance.ToString("c");

                depositTB.Clear();
            }
            else
            {
                MessageBox.Show("Invalid amount");
            }
        }

        private void withdrawBtn_Click(object sender, EventArgs e)
        {
            decimal amount;

            if (decimal.TryParse(withdrawTB.Text, out amount))
            {
                account.Withdraw(amount);

                balanceLabel.Text = account.Balance.ToString("c");

                withdrawTB.Clear();
            }
            else
            {
                MessageBox.Show("Invalid amount");
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

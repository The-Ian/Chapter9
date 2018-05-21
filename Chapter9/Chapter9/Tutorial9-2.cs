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
    public partial class Tutorial9_2 : Form
    {
        public Tutorial9_2()
        {
            InitializeComponent();
        }

        private void GetPhoneData (CellPhone phone)
        {
            decimal price;

            phone.Brand = brandTextBox.Text;
            phone.Model = modelTextBox.Text;

            if (decimal.TryParse(priceTextBox.Text, out price))
            {
                phone.Price = price;
            }
            else
            {
                MessageBox.Show("Invalid Price");
            }
        }

        private void createObjectButton_Click(object sender, EventArgs e)
        {
            CellPhone myPhone = new CellPhone();

            GetPhoneData(myPhone);

            brandLabel.Text = myPhone.Brand;
            modelLabel.Text = myPhone.Model;
            priceLabel.Text = myPhone.Price.ToString("c");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}

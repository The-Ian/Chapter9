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
    public partial class Tutorial9_5 : Form
    {
        public Tutorial9_5()
        {
            InitializeComponent();
        }

        private void displayFormBtn_Click(object sender, EventArgs e)
        {
            MessageForm message = new MessageForm();

            message.ShowDialog();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

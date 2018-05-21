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
    public partial class Tutorial9_6 : Form
    {
        public Tutorial9_6()
        {
            InitializeComponent();
        }

        private void displayBtn_Click(object sender, EventArgs e)
        {
            NutritionForm nutriForm = new NutritionForm();

            if (bananaRB.Checked)
            {
                nutriForm.foodLabel.Text = "1 banana";
                nutriForm.caloriesLabel.Text = "100";
            }
        }
    }
}

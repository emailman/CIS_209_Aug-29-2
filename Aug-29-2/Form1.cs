using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aug_29_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            
            // Try to parse the text box to a double value
            double number;
            if (Double.TryParse(tbxNumber.Text, out number))
            {
                // Do the math and write the result
                double result = number * 2;
                lblOutput.Text = $"Two times your number = {result}";
            }
            else
            {
                // Show an error and cleanup the form
                MessageBox.Show($"You must enter a number", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxNumber.Clear();
                lblOutput.Text = "";
            }
        }
    }
}

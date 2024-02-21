using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
Label: titleLabel
Label: slicesLabel
TextBox: slicesInput
Button: calculateButton
Label: subtotalLabel
Label: subTotalOutput
Label: taxLabel
Label: taxOutput
Label: totalLabel
Label: totalOutput
   */
namespace PizzaParlour
{


    public partial class Form1 : Form
    {
        double slicePrice = 3.25;
        int numOfSlices = 0;
        double subtotal;
        double taxRate = 0.13;

        public Form1()
        {
            InitializeComponent();
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void slicesInput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                numOfSlices = Convert.ToInt32(slicesInput.Text);
                subtotal = slicePrice * numOfSlices;
                subtotalOutput.Text = $"${subtotal.ToString(".00")}";
                double taxAmount = subtotal * taxRate;
                taxOutput.Text = $"${taxAmount.ToString(".00")}";
                double totalPrice = subtotal + taxAmount;
                totalOutput.Text = $"${totalPrice.ToString(".00")}";

            }
            catch
            {
                subtotalOutput.Text = "ERROR";
                taxOutput.Text = "ERROR";
                totalOutput.Text = "ERROR";

            }
        }
    }
}

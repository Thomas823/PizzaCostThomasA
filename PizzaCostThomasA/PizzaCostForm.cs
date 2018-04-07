/*
 * Created by: Thomas Aubin
 * Created on: 7 April, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #11 - Pseudocode
 * This program calculates the cost of pizza regarding it's diameter in inches
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaCostThomasA
{
    public partial class frmPizzaCost : Form
    {

        // Create variables
        const double HST = 0.13;
        const double LABOUR = 0.75;
        const double RENT = 0.99;
        const double MATERIALS = 0.5;
        double diameter, subtotal, hstCost, total;

        public frmPizzaCost()
        {
            InitializeComponent();

            // Hide total cost at beginning
            lblTotalPrompt.Hide();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Get diameter of pizza
            diameter = Convert.ToInt32(txtDiameter.Text);

            // Calculate subtotal
            subtotal = LABOUR + RENT + (diameter * MATERIALS);

            // Calculate hst
            hstCost = subtotal * HST;

            // Calcualte total
            total = subtotal + hstCost;

            // Display total and total prompt
            lblTotal.Text = String.Format("${0:0.00}", total);
            lblTotalPrompt.Show();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestPizzaGUI
{
    public partial class Form1 : Form
    {
        // global variables
        double total;
        int count,
            pieCount = 0,
            diameter;
        string toppings,
               size;
        Pizza[] pies = new Pizza[3];

        public Form1()
        {
            InitializeComponent();
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            if (!smallRadio.Checked && !mediumRadio.Checked && !largeRadio.Checked)
            {
                subtotalLabel.Text = "You must choose a size.";
            } // end if
            else
            {
                total = 0.0;
                count = 0;
                toppings = "";
                size = "";
                if (smallRadio.Checked)
                {
                    total = 8.99;
                    diameter = 8;
                    size = "Small";
                } // end if
                else if (mediumRadio.Checked)
                {
                    total = 10.99;
                    diameter = 10;
                    size = "Medium";
                } // end else if
                else
                {
                    total = 11.99;
                    diameter = 12;
                    size = "Large";
                } // end else
                if (pepperoniCheckBox.Checked)
                {
                    count++;
                    toppings = "Pepperoni";
                } // end if
                if (cheeseCheckBox.Checked)
                {
                    count++;
                    if (toppings != "")
                    {
                        toppings += ", ";
                    } // end if
                    toppings += "Extra Cheese";
                } // end if
                if (sausageCheckBox.Checked)
                {
                    count++;
                    if (toppings != "")
                    {
                        toppings += ", ";
                    } // end if
                    toppings += "Sausage";
                } // end if
                if (pineappleCheckBox.Checked)
                {
                    count++;
                    if (toppings != "")
                    {
                        toppings += ", ";
                    } // end if
                    toppings += "Pineapple";
                } // end if
                if (jalapenoCheckBox.Checked)
                {
                    count++;
                    if (toppings != "")
                    {
                        toppings += ", ";
                    } // end if
                    toppings += "Jalapeno";
                } // end if
                if (onionCheckBox.Checked)
                {
                    count++;
                    if (toppings != "")
                    {
                        toppings += ", ";
                    } // end if
                    toppings += "Onion";
                } // end if
                if (mushroomCheckBox.Checked)
                {
                    count++;
                    if (toppings != "")
                    {
                        toppings += ", ";
                    } // end if
                    toppings += "Mushroom";
                } // end if
                if (oliveCheckBox.Checked)
                {
                    count++;
                    if (toppings != "")
                    {
                        toppings += ", ";
                    } // end if
                    toppings += "Olive";
                } // end if
                if (count > 2)
                {
                    count -= 2;
                    total += (count * 0.5);
                } // end if
                subtotalLabel.Text = "$" + total;
                addButton.Enabled = true;
            } // end else
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (pieCount < 3)
            {
                pies[pieCount] = new Pizza(toppings, diameter, total);
                string output = size + " " + diameter + "\"\r\n" + "Toppings: " +
                    toppings + "\r\nPrice: $" + total + "\r\n\r\n";
                orderTextBox.Text += output;
                pieCount++;
                double grandTotal = 0.0;
                for (int x = 0; x < pieCount; x++)
                {
                    grandTotal += pies[x].Price;
                } // end for
                totalLabel.Text = "Total: $" + grandTotal;
                addButton.Enabled = false;
            } // end if
            else
            {
                subtotalLabel.Text = "Max of 3 pizzas!";
            } // end else
        }
    }
}

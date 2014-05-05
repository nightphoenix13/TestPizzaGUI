using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPizzaGUI
{
    class Pizza
    {
        // class attributes
        private string toppings;
        private int diameter;
        private double price;

        // constructor
        public Pizza(string t, int d, double p)
        {
            setClass(t, d, p);
        } // constructor end

        // properties
        public string Toppings {get; set;} // Toppings property end
        public int Diameter
        {
            get
            {
                return diameter;
            } // end get
            set
            {
                if (value == 8 || value == 10 || value == 12)
                {
                    diameter = value;
                } // end if
                else
                {
                    diameter = 8;
                } // end else
            } // end set
        } // Diameter property end
        public double Price
        {
            get
            {
                return price;
            } // end get
            set
            {
                if (value > 0.0)
                {
                    price = value;
                } // end if
                else
                {
                    price = 9.99;
                } // end else

            } // end set
        } // Price property end

        // class set method
        private void setClass(string t, int d, double p)
        {
            Toppings = t;
            Diameter = d;
            Price = p;
        } // class set method end
    } // Pizza class end
}

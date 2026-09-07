using System.Net;
using System.Numerics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LunchOrder
{
    public partial class Form1 : Form
    {
        //Nady Fotie
        public Form1()
        {
            InitializeComponent();


        }

        //Nady Fotie
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        //Nady Fotie 
        private void ClearTotals()
        {
            txtSubtotal.Text = string.Empty;
            txtSalesTax.Text = string.Empty;
            txtOrderTotal.Text = string.Empty;
        }
        //Nady Fotie
        private void ClearAddOns()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;

        }
        //Nady Fotie
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Text = "Add-on items ($0.75/each)";
            checkBox1.Text = "Lettuce, tomato, and onions";
            checkBox2.Text = "Ketchup, mustard, and mayo";
            checkBox3.Text = "French fries";

       
            ClearAddOns();

        }
        //Nady Fotie
        public void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ClearTotals();
        }
        //Nady Fotie

        public void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            decimal mainCoursePrice = 0m;
            decimal addOnPrice = 0.75m;
            decimal taxRate = 0.0775m;


            // Determine the price of the selected main course
            if (rbHamburger.Checked)
                mainCoursePrice = 6.95m; // Hamburger
            else if (rbPizza.Checked)
                mainCoursePrice = 5.95m; // Pizza
            else if (rbSalad.Checked)
                mainCoursePrice = 4.95m; // Salad
            // Calculate the subtotal based on selected add-ons
            int addOnCount = 0;
            if (checkBox1.Checked)
                addOnCount += 1;
            if (checkBox2.Checked)
                addOnCount += 1;
            if (checkBox3.Checked)
                addOnCount += 1;
            var subtotal = mainCoursePrice + (addOnCount * addOnPrice);
            var tax = subtotal * taxRate;
            var orderTotal = subtotal + tax;
            // Display the results in the text boxes
            txtSubtotal.Text = subtotal.ToString("C");
            txtSalesTax.Text = tax.ToString("C");
            txtOrderTotal.Text = orderTotal.ToString("C");
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffeeShop
{
    public partial class CoffeeShop : Form
    {
        public CoffeeShop()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void customerInformation_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int totalPrice=0, quantity;
            MessageBox.Show("Welcome to Coffee Shop....");
            label1.Text = nameTextBox.Text;
            label2.Text = contactTextBox.Text;
            label3.Text = addressTextBox.Text;
            label4.Text = orderComboBox.Text;
            label5.Text = quantityTextBox.Text;
            quantity = Int32.Parse(quantityTextBox.Text);

            if (orderComboBox.Text == "Black - 120")
            {
              totalPrice=120*quantity;
            }
            else if (orderComboBox.Text == "Cold -100")
            {
                totalPrice = 100 * quantity;
            }
            else if (orderComboBox.Text == "Hot -90")
            {
                totalPrice = 90 * quantity;
            }
            else if (orderComboBox.Text == "Regular -80")
            {
                totalPrice = 80 * quantity;
            }


            label6.Text = "Total Price: " + totalPrice.ToString();

        }

        private void orderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

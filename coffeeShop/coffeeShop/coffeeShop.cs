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
        List<string> names = new List<string> { };
        List<string> addresses = new List<string> { };
        List<string> contacts = new List<string> { };
        List<string> orders = new List<string> { };
        List<string> quantities = new List<string> { };

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
            string message = " ";

            for (int i = 0; i < names.Count; i++)
            {
             message += "Name : " + names.ElementAt(i) + "\n" +
                           "Contacts: " + contacts.ElementAt(i) + "\n" +
                           "Address: " + addresses.ElementAt(i) + "\n" +
                            "Order: " + orders.ElementAt(i) + "\n" +
                            "Quantites: " + quantities.ElementAt(i) + "\n";



                int total = 0, quant;
                quant = Int32.Parse(quantities.ElementAt(i));

                if (orderComboBox.Text == "Black - 120")
                {
                    total = 120 * quant;
                }
                else if (orderComboBox.Text == "Cold -100")
                {
                    total = 100 * quant;
                }
                else if (orderComboBox.Text == "Hot -90")
                {
                    total = 90 * quant;
                }
                else if (orderComboBox.Text == "Regular -80")
                {
                    total = 80 * quant;
                }
                string finalmessage = message + "Total price: " + total + "\n";
                richTextBox.Text = finalmessage;


            }


        }  
        private void ShowCustomer()
        {

            string message = " ";
            
            for(int i =0; i<names.Count;i++)
            {



                message += "Name : " + names.ElementAt(i) + "\n" +
                           "Contacts: "+ contacts.ElementAt(i) + "\n" +
                           "Address: " + addresses.ElementAt(i) + "\n" +
                            "Order: " + orders.ElementAt(i) + "\n" +
                            "Quantites: " + quantities.ElementAt(i) + "\n";
          
                

                int total = 0, quant;
                quant = Int32.Parse(quantityTextBox.Text);

                if (orderComboBox.Text == "Black - 120")
                {
                    total = 120 * quant;
                }
                else if (orderComboBox.Text == "Cold -100")
                {
                    total = 100 * quant;
                }
                else if (orderComboBox.Text == "Hot -90")
                {
                    total = 90 * quant;
                }
                else if (orderComboBox.Text == "Regular -80")
                {
                    total = 80 * quant;
                }
                string finalmessage = message + "Total price: " + total +"\n"+"\n";
                message = "";
                richTextBox.Text = finalmessage;
            }
            
        }

        private Boolean isExists(string cur_con)
        {
            for(int i=0; i<contacts.Count; i++)
            {
                if(cur_con== contacts.ElementAt(i))
                {
                    return true;
                }
            }
            return false;
        }

        private void orderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(names.Count);

            if (names.Count < 3)
            {
                if (isExists(contactTextBox.Text) == true)
                {
                    MessageBox.Show("enter another number");
                }

                else
                {
                    names.Add(nameTextBox.Text);
                    contacts.Add(contactTextBox.Text);
                    addresses.Add(addressTextBox.Text);
                    orders.Add(orderComboBox.Text);
                    quantities.Add(quantityTextBox.Text);
                    ShowCustomer();
                    nameTextBox.Text = "";
                    contactTextBox.Text = "";
                    addressTextBox.Text = "";
                    orderComboBox.Text = "";
                    quantityTextBox.Text = "";
                }

            }
            else
            {
                MessageBox.Show("Customer limit exceed ..!");

            }
        }
    }
}

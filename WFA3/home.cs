using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA3
{
    public partial class home : Form
    {
        private object showLabel;

        public home()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello " + nameTextBox.Text);
            showLabel1.Text = nameTextBox.Text;

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox.Text == "")
            {
                MessageBox.Show("Select items");
            }
            else
            {
                MessageBox.Show(comboBox.Text + " is selected");
            }
        }
    }
}

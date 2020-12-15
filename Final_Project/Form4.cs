using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form4 : Form
    {

        Customer cus = new Customer();

        public void cusInfo(Customer ncus)
        {
            cus = ncus;
            label3.Text = cus.getTag();
        }

        public Form4()
        {
            
            InitializeComponent();
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            Deer temp = cus.getDeer();
            temp.setWeight(Convert.ToDouble(Weight.Text));
            cus.setDeer(temp);
            this.Hide();
            DoeXMLWriter.write(cus);
            f5.Show();

        }
    }
}

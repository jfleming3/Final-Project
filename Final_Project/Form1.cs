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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            listBox1.Items.Add("104"); listBox1.Items.Add("107"); listBox1.Items.Add("109"); listBox1.Items.Add("111"); listBox1.Items.Add("110");
            listBox1.Items.Add("126"); listBox1.Items.Add("131"); listBox1.Items.Add("133"); listBox1.Items.Add("169"); listBox1.Items.Add("173");
            listBox1.Items.Add("176"); listBox1.Items.Add("177"); listBox1.Items.Add("178"); listBox1.Items.Add("179"); listBox1.Items.Add("181");
            listBox1.Items.Add("197"); listBox1.Items.Add("234"); listBox1.Items.Add("237"); listBox1.Items.Add("238"); listBox1.Items.Add("250");
            listBox1.Items.Add("251"); listBox1.Items.Add("252"); listBox1.Items.Add("253"); listBox1.Items.Add("259"); listBox1.Items.Add("269");
            listBox1.Items.Add("272"); listBox1.Items.Add("274"); listBox1.Items.Add("275"); listBox1.Items.Add("278"); listBox1.Items.Add("279");
            listBox1.Items.Add("280"); listBox1.Items.Add("282"); listBox1.Items.Add("283"); listBox1.Items.Add("284"); listBox1.Items.Add("286");
            listBox1.Items.Add("288"); listBox1.Items.Add("289"); listBox1.Items.Add("291"); listBox1.Items.Add("294"); listBox1.Items.Add("295");
            listBox1.Items.Add("296"); listBox1.Items.Add("299");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            


        }

        private  void button2_Click(object sender, EventArgs e)
        {

            
            string fname = FNAME.Text;
            string lname = LNAME.Text;
            string license = HL.Text;
            string tag = TAG.Text;
            string zone = listBox1.GetItemText(listBox1.SelectedItem);

            


            if (BUCK.Checked)
            {
                Form3 f3 = new Form3();
                Deer deerB = new Buck();
                Customer cus = new Customer(fname, lname, license, tag, zone, deerB);

                // CustomerController control = new CustomerController(cus);

                f3.cusInfo(cus);
                this.Hide();
                f3.Show();
            } else if (DOE.Checked)
            {
                DOE.Text = "Checked";
                Form4 f4 = new Form4();
                Deer deerD = new Doe();
                Customer cus = new Customer(fname, lname, license, tag, zone, deerD);

                // CustomerController control = new CustomerController(cus);
                f4.cusInfo(cus);
                this.Hide();
                f4.Show();
            } 



        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        Customer cus = new Customer();

        public void cusInfo(Customer ncus)
        {
            cus = ncus;
            label3.Text = cus.getTag();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
     
               int points = Int32.Parse(POINTS.Text);
               double spread = Convert.ToDouble(SPREAD.Text);
               double beam = Convert.ToDouble(BEAM.Text);
               double weight = Convert.ToDouble(WEIGHT.Text);

            Deer buck = new Buck(points,spread,beam);
            buck.setWeight(weight);
            cus.setDeer(buck);
            XMLwriter.write(cus);
            this.Hide();
            f5.Show();
        }
    }
}

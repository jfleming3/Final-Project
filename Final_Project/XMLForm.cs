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
    public partial class XMLForm : Form
    {
        public XMLForm()
        {
            InitializeComponent();
        }

        public void setformcus(Customer cus)
        {
            Buck deer = new Buck();
            deer = (Buck)cus.getDeer();
            lbeam.Text = deer.getBeam().ToString();
            lpoints.Text = deer.getPoints().ToString();
            lspread.Text = deer.getSpread().ToString();
            lweight.Text = cus.getDeer().getWeight().ToString();
            fname.Text = cus.getFname();
            lname.Text = cus.getLname();
            license.Text = cus.getLicense();
            tag.Text = cus.getTag();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void XMLForm_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lname_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void tag_Click(object sender, EventArgs e)
        {

        }

        private void weight_Click(object sender, EventArgs e)
        {

        }

        private void lweight_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            this.Hide();
            f5.Show();
        }
    }
}

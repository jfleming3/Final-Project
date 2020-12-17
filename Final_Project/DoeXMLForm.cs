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
    public partial class DoeXMLForm : Form
    {
        public DoeXMLForm()
        {
            InitializeComponent();
        }


        public void setformcus(Customer cus)
        {

            lweight.Text = cus.getDeer().getWeight().ToString();
            fname.Text = cus.getFname();
            lname.Text = cus.getLname();
            license.Text = cus.getLicense();
            tag.Text = cus.getTag();

        }

        private void DoeXMLForm_Load(object sender, EventArgs e)
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

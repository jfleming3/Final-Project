using Microsoft.VisualStudio.TestTools.UnitTesting;
using Final_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Tests
{
    [TestClass()]
    public class Form3Tests
    {



        [TestMethod()]
        public void getf3CusTest()
        {
            Form3 f3 = new Form3();

            Customer cus = new Customer();
        
            Assert.IsInstanceOfType(f3.getf3Cus(),typeof(Customer));
           // Assert.AreEqual(cus, f3.getf3Cus());
        }


        [TestMethod()]
        public void cusInfoTest()
        {
            Form3 f3 = new Form3();
            Deer deer = new Doe();
            Customer cus = new Customer("Justin","Fleming","555","666","131",deer);

            f3.cusInfo(cus);


            Assert.AreEqual(cus, f3.getf3Cus());
        }
    }
}
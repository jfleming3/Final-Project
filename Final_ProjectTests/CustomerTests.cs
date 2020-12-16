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
    public class CustomerTests
    {
       
        [TestMethod()]
        public void getLnameTest()
        {

            Customer cus = new Customer();
            cus.setLname("Fleming");

            string lname = cus.getLname();

            Assert.AreEqual("Fleming", lname);


        }

        [TestMethod()]
        public void getFnameTest()
        {

            Customer cus = new Customer();
            cus.setFname("Justin");

            string fname = cus.getFname();

            Assert.AreEqual("Justin", fname);


        }
        [TestMethod()]
        public void getTagTest()
        {

            Customer cus = new Customer();
            cus.setTag("555");

            string tag = cus.getTag();

            Assert.AreEqual("555", tag);


        }


    }
}
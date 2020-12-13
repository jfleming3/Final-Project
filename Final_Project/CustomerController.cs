using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class CustomerController
    {
        private Customer cus;

        public CustomerController(Customer ncus)
        {
            cus = ncus;
        }


        public string getFname()
        {
            return cus.getFname();
        }

        public void setDeer(Deer deer1)
        {
            cus.setDeer(deer1);
        }

        public Deer getDeer()
        {
            return cus.getDeer();
        }

        public void setFname(string name)
        {
            cus.setFname(name);
        }

        public string getLname()
        {
            return cus.getLname();
        }

        public void setLname(string name)
        {
            cus.setLname(name);
        }

        public string getLicense()
        {
            return cus.getLicense();
        }

        public void setLicense(string lic)
        {
            cus.setLicense(lic);
        }

        public string getTag()
        {
            return cus.getTag();
        }

        public void setTag(string ntag)
        {
            cus.setTag(ntag);
        }
        public string getZone()
        {
            return cus.getZone();
        }

        public void setZone(string nzone)
        {
            cus.setZone(nzone);
        }


    }
}

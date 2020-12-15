using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    [Serializable()]
    public class Customer
    {

        private string fname;
        private string lname;
        private string license;
        private string tag;
        private string zone;
        Deer deer = new Deer();
        public Customer()
        {
            fname = null;
            lname = null;
            license = null;
            tag = null;
            zone = null;
            deer = null;
            
          
        }

        public Customer(string nfname, string nlname, string nlicense, string ntag, string nzone, Deer ndeer)
        {
            fname = nfname;
            lname = nlname;
            license = nlicense;
            tag = ntag;
            zone = nzone;
            deer = ndeer;

        }

        public string getFname()
        {
            return fname;
        }

        public void setDeer(Deer deer1)
        {
            deer = deer1;
        }

        public Deer getDeer()
        {
            return deer;
        }
          
        public void setFname(string name)
        {
            fname = name;
        }

        public string getLname()
        {
            return lname;
        }

        public void setLname(string name)
        {
            lname = name;
        }

        public string getLicense()
        {
            return license;
        }

        public void setLicense(string lic)
        {
            license = lic;
        }

        public string getTag()
        {
            return tag;
        }

        public void setTag(string ntag)
        {
            tag = ntag;
        }
        public string getZone()
        {
            return zone;
        }

        public void setZone(string nzone)
        {
            zone = nzone;
        }



    }
}

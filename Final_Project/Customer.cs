﻿using System;
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

        public string fname;
        public string lname;
        public string license;
        public string tag;
        public string zone;
        public Deer deer = new Deer();
        public string deertype;
        public Customer()
        {
            fname = null;
            lname = null;
            license = null;
            tag = null;
            zone = null;
            deer = null;
            deertype = null;
            
          
        }

        public Customer(string nfname, string nlname, string nlicense, string ntag, string nzone, Deer ndeer,string deerT)
        {
            fname = nfname;
            lname = nlname;
            license = nlicense;
            tag = ntag;
            zone = nzone;
            deer = ndeer;
            deertype = deerT;

        }




        public string getdeertype()
        {
            return deertype;
        }

        public void setdeertype(string type)
        {
            if (type.Equals("Doe") || type.Equals("Buck"))
            {
                deertype = type;
            }
            else
            {
                deertype = "Error";
            }
            
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

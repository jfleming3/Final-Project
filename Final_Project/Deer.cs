using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Final_Project
{
    [XmlInclude(typeof(Buck))]
    [XmlInclude(typeof(Doe))]
    public class Deer
    {

        public string tag;
        public double weight;

       
        public void setTag(string ntag)
        {
            tag = ntag;
        }

        public string getTag()
        {
            return tag;
        }

        public void setWeight(double nweight)
        {
            weight = nweight;
        }

        public double getWeight()
        {
            return weight;
        }

        public string getWeightXML()
        {
            string t = Convert.ToString(weight);
            return t;
        }



    }
}

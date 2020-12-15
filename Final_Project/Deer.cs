using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Final_Project
{
    [Serializable()]
    public class Deer
    {

         string tag;
         double weight;

        public virtual void write(ref XmlTextWriter writer)
        {

        }

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

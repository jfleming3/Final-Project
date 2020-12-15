using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Final_Project
{
    class DoeXMLWriter
    {
        public static void write(Customer cus)
        {
            string filname = "D:\\Users\\jfleming2\\DeerHarvest.xml";
            XmlTextWriter xmlWriter = new XmlTextWriter(filname, null);

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("Customer");
            xmlWriter.WriteElementString("Name", cus.getFname() + " " + cus.getLname());
            xmlWriter.WriteElementString("License", cus.getLicense());
            xmlWriter.WriteElementString("Tag", cus.getTag());
            xmlWriter.WriteElementString("Zone", cus.getZone());
           
            xmlWriter.WriteStartElement("Doe");
            xmlWriter.WriteElementString("Weight",cus.getDeer().getWeightXML());
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
        }
    }
}

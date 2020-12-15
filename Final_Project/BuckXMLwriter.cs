using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Final_Project
{
    [Serializable()]
    class BuckXMLwriter
    {
        public static void write(Customer cus)
        {
            
            string filname = "D:\\Users\\jfleming2\\DeerHarvest.xml";
            XmlTextWriter xmlwriter = new XmlTextWriter(filname,null);

            XmlSerializer writer = new XmlSerializer(typeof(Customer));
            writer.Serialize(xmlwriter, cus);
            /*
            xmlwriter.WriteStartDocument();
            xmlwriter.WriteStartElement("Customer");
            xmlwriter.WriteElementString("Name", cus.getFname() + " " + cus.getLname());
            xmlwriter.WriteElementString("License", cus.getLicense());
            xmlwriter.WriteElementString("Tag", cus.getTag());
            xmlwriter.WriteElementString("Zone", cus.getZone());

            xmlwriter.WriteStartElement("Buck");
            xmlwriter.WriteElementString("Weight", cus.getDeer().getWeightXML());
            //xmlwriter.WriteElementString()
            cus.getDeer().write(ref xmlwriter);
            xmlwriter.WriteEndElement();
            xmlwriter.WriteEndDocument();
            */
            xmlwriter.Close();

        }

    }
}

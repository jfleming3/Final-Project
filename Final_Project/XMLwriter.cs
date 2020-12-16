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
    [Serializable()]
   public class XMLwriter
    {
        public static void write(Customer cus)
        {

            string filname = "D:\\Users\\jfleming2\\DeerHarvest.xml";
            TextWriter xmlWriter = new StreamWriter(filname);

            XmlSerializer writer = new XmlSerializer(cus.GetType());
            writer.Serialize(xmlWriter, cus);
           
            xmlWriter.Close();
            
        }

    }
}

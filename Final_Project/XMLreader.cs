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
    class XMLreader
    {

        public static Customer DeSerialize<Customer>(string fileName)
        {
            if (string.IsNullOrEmpty(fileName)) { return default(Customer); }

            Customer objectOut = default(Customer);

            
            
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(fileName);
                string xmlString = xmlDocument.OuterXml;

                using (StringReader read = new StringReader(xmlString))
                {
                   

                    XmlSerializer serializer = new XmlSerializer(typeof(Customer));
                    using (XmlReader reader = new XmlTextReader(read))
                    {
                        objectOut = (Customer)serializer.Deserialize(reader);
                    }
                }
            
           

            return objectOut;
        }

    }
}

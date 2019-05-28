using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Xml.Serialization;

namespace TestApp2019_2
{
    [XmlRoot]
    public class XMLReader
    {
        public static string GetXMLFromObject(object o)
        {
            StringWriter sw = new StringWriter();
            XmlTextWriter tw = null;
            try
            {
                XmlSerializer serializer = new XmlSerializer(o.GetType());
                tw = new XmlTextWriter(sw);
                serializer.Serialize(tw, o);
            }
            catch (Exception ex)
            {
                //Handle Exception Code
            }
            finally
            {
                sw.Close();
                if (tw != null)
                {
                    tw.Close();
                }
            }
            return sw.ToString();
        }

        public static Object ObjectToXML(string xml, Type objectType)
        {
            StringReader strReader = null;
            XmlSerializer serializer = null;
            XmlTextReader xmlReader = null;
            Object obj = null;
            try
            {
                strReader = new StringReader(xml);
                serializer = new XmlSerializer(objectType);
                xmlReader = new XmlTextReader(strReader);
                obj = serializer.Deserialize(xmlReader);
            }
            catch (Exception exp)
            {
                //Handle Exception Code
            }
            finally
            {
                if (xmlReader != null)
                {
                    xmlReader.Close();
                }
                if (strReader != null)
                {
                    strReader.Close();
                }
            }
            return obj;
        }

        public void XMLcreate(List<Users> xUser)
        {
            XmlSerializer xs = new XmlSerializer(typeof(Users));
            using (FileStream fs = new FileStream("Data.xml", FileMode.Create))
            {
                foreach(Users i in xUser)
                {
                    xs.Serialize(fs, i);
                }
                
            }
            return;
        }


        public void XMLload()
        {
            Users SelectedUser;
            XmlSerializer xs = new XmlSerializer(typeof(Users));
            using (FileStream fs = new FileStream("Data.xml", FileMode.Open))
            {
                // This will read the XML from the file and create the new instance
                // of CustomerData
                SelectedUser = xs.Deserialize(fs) as Users;
                //MessageBox.Show(SelectedUser.Firstname);
            }
        }
    }
}

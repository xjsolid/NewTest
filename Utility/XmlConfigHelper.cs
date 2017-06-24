using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace TTSM2.Utility
{
    public class XmlConfigHelper
    {
        public static void Save<T>(T obj, string filePath)
        {
            XmlSerializer ser = new XmlSerializer(obj.GetType());
            XmlWriter xmlwrite = XmlWriter.Create(filePath, new XmlWriterSettings { Indent = true });
            ser.Serialize(xmlwrite, obj);
            xmlwrite.Close();
        }

        public static T Load<T>(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentNullException("filePath");
            }
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException(filePath);
            }

            XmlSerializer serializer = new XmlSerializer(typeof(T));
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            T obj = (T)serializer.Deserialize(fs);
            fs.Close();
            return obj;
        }
    }
}

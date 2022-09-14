using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading;
using System.Xml;
using System.Xml.Serialization;
using static System.Console;

namespace Stadtbücherei_Verwaltungssystem
{
    public class XMLWriter
    {
        /// <summary>
        /// Speichert aktuellen Datensatz in einer XML File
        /// </summary>
        public void WriteXml(Organization organization)
        {
            if (File.Exists(Settings.XmlFile))
            {
                File.Delete(Settings.XmlFile);
                XmlSerializer writer = new XmlSerializer(typeof(Organization));

                using (FileStream file = File.OpenWrite(Settings.XmlFile))
                {
                    writer.Serialize(file, organization);
                }
            }
            else
            {
                XmlSerializer writer = new XmlSerializer(typeof(Organization));

                using (FileStream file = File.OpenWrite(Settings.XmlFile))
                {
                    writer.Serialize(file, organization);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace I4GUI
{
    class OpenSave
    {
        private Agents agenter;

        public Agents readAgents(string path) // Brugt i Undervisning ved JRT: Construction
        {
            string mypath = @"" + path;

            using (FileStream xmlStream = new FileStream(mypath, FileMode.Open))
            {
                using (XmlReader xmlReader = XmlReader.Create(xmlStream))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Agents));

                    Agents deserializedMembers = serializer.Deserialize(xmlReader) as Agents;

                    agenter = deserializedMembers;

                    xmlReader.Close();

                    return agenter;
                }
            }
        }
         


        public void saveAgents(Agents agenter, string path) // Brugt i Undervisning ved JRT: Construction
        {
            string mypath = @"" + path;

            using (FileStream xmlStream = new FileStream(mypath, FileMode.OpenOrCreate))
            {

                using (XmlWriter xmlWriter = XmlWriter.Create(xmlStream))

                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Agents));

                    serializer.Serialize(xmlWriter, agenter);
                    xmlWriter.Flush();
                    xmlWriter.Close();
                }
            }
        }
    }
}

using Simul.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace Simul.Helpers
{
    public static class ContentReader
    {
        private const string RESOURCES_PATH = "Content/resources.xml";

        public static List<Resource> ReadResources()
        {
            List<Resource> resources = new List<Resource>();

            StreamReader reader = new StreamReader(RESOURCES_PATH);
            var xmlDoc = XDocument.Parse(reader.ReadToEnd());
            reader.Close();

            foreach(XElement resource in xmlDoc.Descendants("resources"))
            {
                string name = resource.Descendants("name").First().Value;
                ResourceType type = new ResourceType(resource.Descendants("type").First().Value);
                Skill improvedSkill = new Skill(resource.Descendants("improvedSkill").First().Value);

                resources.Add(new Resource(name, type, improvedSkill));
            }

            return resources;
        }
    }
}

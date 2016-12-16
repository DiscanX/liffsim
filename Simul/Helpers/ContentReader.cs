using Simul.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Simul.Helpers
{
    public static class ContentReader
    {
        private const string RESOURCES_PATH = "Content/resources.xml";

        public static List<Resource> ReadResources()
        {
            List<Resource> resources = new List<Resource>();

            using (XmlReader reader = XmlReader.Create(RESOURCES_PATH))
            {
                while (reader.Read())
                {
                    if(reader.Name == "resource")
                    {
                        ResourceType type = new ResourceType(reader.GetAttribute("type"));
                        Skill improvedSkill = new Skill(reader.GetAttribute("improvedSkill"));

                        resources.Add(new Resource(reader.GetAttribute("name"), type, improvedSkill));
                    }
                }
            }

            return resources;
        }
    }
}

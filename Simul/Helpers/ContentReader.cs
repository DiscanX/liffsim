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

        private static List<Resource> resources = new List<Resource>();
        private static List<Skill> skills = new List<Skill>();

        public static List<Resource> ReadResources()
        {
            if (resources.Count == 0)
            {
                StreamReader reader = new StreamReader(RESOURCES_PATH);
                var xmlDoc = XDocument.Parse(reader.ReadToEnd());
                reader.Close();

                foreach (XElement resource in xmlDoc.Descendants("resources"))
                {
                    string name = resource.Descendants("name").First().Value;
                    ResourceType type = new ResourceType(resource.Descendants("type").First().Value);
                    Skill improvedSkill = new Skill(resource.Descendants("improvedSkill").First().Value);

                    resources.Add(new Resource(name, type, improvedSkill));
                }
            }

            return resources;
        }

        public static List<Skill> ReadSkills()
        {
            if (skills.Count == 0)
            {
                if (resources.Count == 0)
                {
                    ReadResources();
                }

                foreach (Resource resource in resources)
                {
                    skills.Add(resource.improvedSkill);
                }
            }

            return skills;
        }
    }
}

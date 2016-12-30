using Simul.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.ComponentModel;

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

                foreach (XElement resource in xmlDoc.Elements("resources").Nodes())
                {
                    string name = resource.Element("name").Value;
                    string type = resource.Element("type").Value;
                    Skill improvedSkill = new Skill(resource.Element("improvedSkill").Value);
                    int productionCost = int.Parse(resource.Element("productionCost").Value);

                    //Possible because we are certain that primary resources are red before any 2nd or 3rd level resources
                    Dictionary<Resource, int> requirements = new Dictionary<Resource, int>();
                    foreach(XElement requirement in resource.Elements("requirements").Nodes())
                    {
                        Resource requiredResource = resources.First(x => x.name == requirement.Element("name").Value);
                        int requiredQuantity = int.Parse(requirement.Element("quantity").Value);
                        requirements.Add(requiredResource, requiredQuantity);
                    }

                    Resource createdResource;
                    switch(type)
                    {
                        case "primary":
                            createdResource = new PrimaryResource(name, improvedSkill, productionCost);
                            break;
                        case "secondary":
                            createdResource = new SecondaryResource(name, improvedSkill, productionCost, requirements);
                            break;
                        case "tertiary":
                            createdResource = new TertiaryResource(name, improvedSkill, productionCost, requirements);
                            break;
                        default:
                            throw new InvalidEnumArgumentException();
                    }

                    resources.Add(createdResource);
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

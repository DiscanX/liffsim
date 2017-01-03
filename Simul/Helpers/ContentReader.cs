using Simul.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.ComponentModel;
using Simul.Properties;
using System.Windows.Forms;
using System.Drawing;

namespace Simul.Helpers
{
    public static class ContentReader
    {
        private static List<Resource> resources = new List<Resource>();
        private static List<Skill> skills = new List<Skill>();
        private static ImageList resourcesImages;

        public static List<Resource> GetResources()
        {
            if (resources.Count == 0)
            {
                var xmlDoc = XDocument.Parse(Resources.resources);

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
                        case "Primary":
                            createdResource = new PrimaryResource(name, improvedSkill, productionCost);
                            break;
                        case "Secondary":
                            createdResource = new SecondaryResource(name, improvedSkill, productionCost, requirements);
                            break;
                        case "Tertiary":
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

        public static List<Skill> GetSkills()
        {
            if (skills.Count == 0)
            {
                if (resources.Count == 0)
                {
                    GetResources();
                }

                foreach (Resource resource in resources)
                {
                    skills.Add(resource.improvedSkill);
                }
            }

            return skills;
        }

        public static ImageList GetResourcesImages()
        {
            if(resourcesImages == null)
            {
                resourcesImages = new ImageList();
                resourcesImages.Images.Add("wheat", Resources.wheat);
                resourcesImages.Images.Add("iron", Resources.iron);
                resourcesImages.Images.Add("bread", Resources.bread);
                resourcesImages.Images.Add("weapon", Resources.weapon);
                resourcesImages.ImageSize = new Size(50, 50);
                resourcesImages.ColorDepth = ColorDepth.Depth24Bit;
            }

            return resourcesImages;
        }
    }
}

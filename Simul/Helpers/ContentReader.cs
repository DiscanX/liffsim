using Simul.Models;
using Simul.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Simul.Helpers
{
    public enum eResourceName
    {
        wheat,
        iron,
        bread,
        weapon
    }

    public enum eResourceType
    {
        primary,
        secondary,
        tertiary
    }

    public static class ContentReader
    {
        private static readonly List<Resource> _resources = new List<Resource>();
        private static readonly List<Skill> _skills = new List<Skill>();
        private static ImageList _resourcesImages;

        public static List<Resource> GetResources()
        {
            if (_resources.Count == 0)
            {
                var xmlDoc = XDocument.Parse(Resources.resources);

                foreach (XElement resource in xmlDoc.Elements("resources").Nodes())
                {
                    eResourceName name;
                    Enum.TryParse(resource.Element("name").Value, out name);

                    eResourceType type;
                    Enum.TryParse(resource.Element("type").Value, out type);

                    var improvedSkill = new Skill(resource.Element("improvedSkill").Value);
                    var productionCost = int.Parse(resource.Element("productionCost").Value);

                    //Possible because we are certain that primary resources are red before any 2nd or 3rd level resources
                    var requirements = new Dictionary<Resource, int>();
                    foreach (XElement requirement in resource.Elements("requirements").Nodes())
                    {
                        var requiredResource = _resources.First(x => x.Name.ToString() == requirement.Element("name").Value);
                        var requiredQuantity = int.Parse(requirement.Element("quantity").Value);
                        requirements.Add(requiredResource, requiredQuantity);
                    }

                    var isEdible = resource.Element("edible") != null;

                    Resource createdResource;
                    switch (type)
                    {
                        case eResourceType.primary:
                            createdResource = new PrimaryResource(name, improvedSkill, productionCost, isEdible);
                            break;
                        case eResourceType.secondary:
                            createdResource = new SecondaryResource(name, improvedSkill, productionCost, requirements, isEdible);
                            break;
                        case eResourceType.tertiary:
                            createdResource = new TertiaryResource(name, improvedSkill, productionCost, requirements, isEdible);
                            break;
                        default:
                            throw new InvalidEnumArgumentException();
                    }

                    _resources.Add(createdResource);
                }
            }

            return _resources;
        }

        public static List<Skill> GetSkills()
        {
            if (_skills.Count == 0)
            {
                if (_resources.Count == 0)
                {
                    GetResources();
                }

                foreach (Resource resource in _resources)
                {
                    _skills.Add(resource.ImprovedSkill);
                }
            }

            return _skills;
        }

        public static ImageList GetResourcesImages()
        {
            if (_resourcesImages == null)
            {
                _resourcesImages = new ImageList();
                _resourcesImages.Images.Add(eResourceName.wheat.ToString(), Resources.wheat);
                _resourcesImages.Images.Add(eResourceName.iron.ToString(), Resources.iron);
                _resourcesImages.Images.Add(eResourceName.bread.ToString(), Resources.bread);
                _resourcesImages.Images.Add(eResourceName.weapon.ToString(), Resources.weapon);
                _resourcesImages.ImageSize = new Size(50, 50);
                _resourcesImages.ColorDepth = ColorDepth.Depth24Bit;
            }

            return _resourcesImages;
        }
    }
}

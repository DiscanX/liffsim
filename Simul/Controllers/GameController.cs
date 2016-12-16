using Simul.Models;
using Simul.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul.Controllers
{
    public class GameController
    {
        public Person controlledPerson { get; set; }
        public List<Person> persons { get; set; }
        public List<Company> companies { get; set; }

        public GameController()
        {
            controlledPerson = new Person("Keven", 10, new Skillset(new Dictionary<Skill, float>()), new Inventory(), 5);

            persons = new List<Person>();
            persons.Add(controlledPerson);
            persons.Add(new Person("Noèmie", 10, new Skillset(new Dictionary<Skill, float>()), new Inventory(), 5));
            persons.Add(new Person("David", 10, new Skillset(new Dictionary<Skill, float>()), new Inventory(), 5));

            companies = new List<Company>();
            //Where ReadResources()[0] is wheat (see resources.xml)
            companies.Add(new Company("Sample Company", ContentReader.ReadResources()[0], 100, new Inventory()));
        }

        public void ForwardDays(int nbrDays)
        {

        }

    }
}

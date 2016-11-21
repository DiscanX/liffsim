using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul
{
    public class PersonController
    {
        public List<Person> persons { get; set; }

        public PersonController()
        {
            persons = new List<Person>();
            persons.Add(new Person("Keven", 10, new Dictionary<Skill, float>(), new Inventory(), 5));
            persons.Add(new Person("Noèmie", 10, new Dictionary<Skill, float>(), new Inventory(), 5));
            persons.Add(new Person("David", 10, new Dictionary<Skill, float>(), new Inventory(), 5));
        }
    }
}

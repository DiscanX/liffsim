using Simul.Models;
using Simul.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simul.Controllers
{
    public class PersonController
    {
        public List<Person> persons { get; set; }

        public PersonController()
        {
            persons = new List<Person>();
            persons.Add(new Person("Keven", 10, new Skillset(), new Inventory(), 100, 5));
            persons.Add(new Person("Noèmie", 10, new Skillset(), new Inventory(), 100, 5));
            persons.Add(new Person("David", 10, new Skillset(), new Inventory(), 100, 5));
        }

        public Person GetPersonByName(string name)
        {
            return persons.First(x => x.name == name);
        }
    }
}

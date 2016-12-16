using Simul.Models;
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

        public PersonController(List<Person> persons)
        {
            this.persons = persons;
        }

        public Person GetPersonByName(string name)
        {
            return persons.First(x => x.name == name);
        }
    }
}
